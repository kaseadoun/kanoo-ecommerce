using System.Net;
using System.Net.Http.Headers;

namespace Kanoo.Models
{
    /// <summary>
    /// Class <c>PopulateSqlTable</c> will handle calling the APIs and writing the values into the database
    /// upon using the Create() function in any applicable Controller
    /// <para>Method <c>PopulateFlightTable()</c> submits a GET request to the API and populates the DB with the JSON contents</para>
    /// Method <c>PopulateAirportTable()</c> reads a local JSON file in full and seeds the DB with the JSON contents
    /// <para><param name="_context">_context : Represents the table of the database being worked with</param></para>
    /// <para><param name="_httpClient">_httpClient : Represents the protocol used to GET the API response</param></para>
    /// </summary>
    public class PopulateSqlTable
    {
        static readonly HttpClient _httpClient = new HttpClient();

        /// <summary>
        /// Data pulled from: https://rapidapi.com/DataCrawler/api/tripadvisor16
        /// </summary>
        public static async void PopulateFlightTable(ApplicationDbContext _context, Flight flight)
        {
            // Create a secure ConfigurationBuilder() to read the API key and host from a hidden JSON
            // instead of hard-coding the values in the method
             var builder = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.Development.json");

            var config = builder.Build();
            var key = config["Api:X-RapidAPI-Key"];
            var host = config["Api:X-RapidAPI-Flight-Host"];

            // Create the request using the API URL and our hidden credentials
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                // Send a request to the API from the inputted form data
                RequestUri = new Uri(String
                    .Format("https://tripadvisor16.p.rapidapi.com/api/v1/flights/searchFlights?sourceAirportCode={0}&destinationAirportCode={1}&date={2}&itineraryType=ONE_WAY&sortOrder=PRICE&numAdults={3}&numSeniors={4}&classOfService={5}&pageNumber=1&currencyCode=CAD", 
                            flight.From, flight.To, DateOnly.FromDateTime(flight.Departure), flight.NumOfAdults, 
                            flight.NumOfSeniors, flight.ServiceClass)),
                Headers =
                {
                    { "X-RapidAPI-Key", key },
                    { "X-RapidAPI-Host", host },
                },
            };

            HttpResponseMessage responseMessage = _httpClient.SendAsync(request).Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                // GET the API JSON result and pass it as a string to JsonToFlight()
                // JsonToFlight() will extract all of the data from the JSON and convert it into a Flight object
                var totalEntries = JsonToObject.JsonToFlight(responseMessage.Content.ReadAsStringAsync().Result, _context, flight);

                // Add each new object to the database
                foreach (var entry in totalEntries) {
                     _context.Flights.Add(entry);
                }
                _context.SaveChanges();
            } 
        }

        /// <summary>
        /// Data pulled from: https://rapidapi.com/tipsters/api/hotels-com-provider
        /// <para>"GET/Regions Search"</para>
        /// </summary>
        public static async void PopulateDestinationTable(ApplicationDbContext _context, Destination destination)
        {
             var builder = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.Development.json");

            var config = builder.Build();
            var key = config["Api:X-RapidAPI-Key"];
            var host = config["Api:X-RapidAPI-Stay-Host"];

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                // Send a request to the API from the inputted form data
                RequestUri = new Uri(String
                    .Format("https://hotels-com-provider.p.rapidapi.com/v2/regions?locale=en_GB&domain=GB&query={0}", 
                            destination.City)),
                Headers =
                {
                    { "X-RapidAPI-Key", key },
                    { "X-RapidAPI-Host", host },
                },
            };

            HttpResponseMessage responseMessage = _httpClient.SendAsync(request).Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                var totalEntries = JsonToObject.JsonToDestination(responseMessage.Content.ReadAsStringAsync().Result);

                foreach (var entry in totalEntries) {
                     _context.Destinations.Add(entry);
                }
                _context.SaveChanges();
            } 
        }

        /// <summary>
        /// Data pulled from: https://rapidapi.com/tipsters/api/hotels-com-provider
        /// <para>"GET/Hotels Search"</para>
        /// </summary>
        public static async void PopulateStayTable(ApplicationDbContext _context, Stay stay)
        {
            // Establish relationship with the Destinations table
            var region = _context.Destinations
                .FirstOrDefault(entity => entity.Id == stay.RegionId);
            stay.RegionId = region.Id;

            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.Development.json");

            var config = builder.Build();
            var key = config["Api:X-RapidAPI-Key"];
            var host = config["Api:X-RapidAPI-Stay-Host"];

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                // Send a request to the API from the inputted form data
                RequestUri = new Uri(String
                    .Format("https://hotels-com-provider.p.rapidapi.com/v2/hotels/search?checkout_date={0}&domain=GB&adults_number={1}&sort_order=RECOMMENDED&checkin_date={2}&locale=en_GB&region_id={3}&available_filter=SHOW_AVAILABLE_ONLY&guest_rating_min=8&payment_type=PAY_LATER%2CFREE_CANCELLATION&amenities=WIFI%2CPARKING&price_max=500&page_number=1&meal_plan=FREE_BREAKFAST&star_rating_ids=3%2C4%2C5&price_min=10&lodging_type=HOTEL%2CHOSTEL%2CAPART_HOTEL&children_ages={4}", 
                            DateOnly.FromDateTime(stay.EndDate), stay.Adults, DateOnly.FromDateTime(stay.StartDate), stay.RegionId, stay.Children)),
                Headers =
                {
                    { "X-RapidAPI-Key", key },
                    { "X-RapidAPI-Host", host },
                },
            };

            HttpResponseMessage responseMessage = _httpClient.SendAsync(request).Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                var totalEntries = JsonToObject.JsonToStay(responseMessage.Content.ReadAsStringAsync().Result, stay);

                foreach (var entry in totalEntries) {
                     _context.Stays.Add(entry);
                }
                _context.SaveChanges();
            } 
        }

        /// <summary>
        /// Data pulled from: https://rapidapi.com/tipsters/api/booking-com
        /// <para>"GET/Search Car Rental"</para>
        /// </summary>
        public static async void PopulateCarTable(ApplicationDbContext _context, Car car)
        {
             // Establish relationship with the Destinations table
            var region = _context.Destinations
                .FirstOrDefault(entity => entity.Id == car.RegionId);
            car.Region = region;
            car.RegionId = region.Id;

            // Get the latitude and longitude of the location to search for nearby rentals
            /*var latitude = region.Latitude;
            var longitude = region.Longitude;

            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.Development.json");

            var config = builder.Build();
            var key = config["Api:X-RapidAPI-Key"];
            var host = config["Api:X-RapidAPI-Car-Host"];

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                // Send a request to the API from the inputted form data
                RequestUri = new Uri(String
                    .Format("https://booking-com.p.rapidapi.com/v1/car-rental/search?pick_up_longitude={0}&drop_off_longitude={1}&pick_up_datetime={2}&locale=en-gb&pick_up_latitude={3}&from_country=ca&drop_off_datetime={4}&sort_by=recommended&drop_off_latitude={5}&currency=CAD", 
                           longitude, longitude, car.StartDate.ToString("yyyy-MM-dd HH'%3A'mm'%3A'ss"), latitude, car.EndDate.ToString("yyyy-MM-dd HH'%3A'mm'%3A'ss"), latitude)),
                Headers =
                {
                    { "X-RapidAPI-Key", key },
                    { "X-RapidAPI-Host", host },
                },
            };

            HttpResponseMessage responseMessage = _httpClient.SendAsync(request).Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                var totalEntries = JsonToObject.JsonToCar(responseMessage.Content.ReadAsStringAsync().Result, car);

                foreach (var entry in totalEntries) {
                     _context.Cars.Add(entry);
                }
                _context.SaveChanges();
            }  */
            StreamReader reader = new StreamReader("test.json");
            string json = reader.ReadToEnd();
        
            // Pass the JSON as a string to JsonToAirport() to get the translated Airport objects
            var totalEntries = JsonToObject.JsonToCar(json, car);

            // Add each new object to the database
            foreach (var entry in totalEntries) {
                    _context.Cars.Add(entry);
            }
            /* 
             Innermost exception 	 MySql.Data.MySqlClient.MySqlException : Cannot add or update a child row: a foreign key constraint fails (`kanoo`.`cars`, CONSTRAINT `FK_Cars_Destinations_RegionId` FOREIGN KEY (`RegionId`) REFERENCES `destinations` (`Id`) ON DELETE CASCADE)
            */
            _context.SaveChanges();
        }

        /// <summary>
        /// Method <c>PopulateAirportTable()</c> reads a local JSON file in full and seeds the DB with the JSON contents
        /// <para>JSON was pulled from: https://rapidapi.com/aviolog-aviolog-default/api/akrx</para>
        /// <para>Saved as a local file for performance purposes (it returns a ton of data)</para>
        /// <para><param name="_context">_context : Represents the table of the database being worked with</param></para>
        /// <para><param name="_httpClient">_httpClient : Represents the protocol used to GET the API response</param></para>
        /// </summary>
        public static async void PopulateAirportTable(ApplicationDbContext _context)
        {
            StreamReader reader = new StreamReader("allsirports.json");
            string json = reader.ReadToEnd();
        
            // Pass the JSON as a string to JsonToAirport() to get the translated Airport objects
            var totalEntries = JsonToObject.JsonToAirport(json);

            // Add each new object to the database
            foreach (var entry in totalEntries) {
                    _context.Airports.Add(entry);
            }
            _context.SaveChanges();
            
        }
    }
}