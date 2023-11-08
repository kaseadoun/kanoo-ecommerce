using System.Net;
using System.Net.Http.Headers;

namespace Kanoo.Models
{
    /// <summary>
    /// Class <c>PopulateSqlTable</c> will handle calling the APIs and writing the values into rows in the database
    /// <para>Method <c>PopulateFlightTable()</c> submits a GET request to the API and populates the DB with the JSON contents</para>
    /// Method <c>PopulateAirportTable()</c> reads a local JSON file in full and seeds the DB with the JSON contents
    /// <para><param name="_context">_context : Represents the table of the database being worked with</param></para>
    /// <para><param name="_httpClient">_httpClient : Represents the protocol used to GET the API response</param></para>
    /// </summary>
    public class PopulateSqlTable
    {
        static readonly HttpClient _httpClient = new HttpClient();

        /*
           !IMPORTANT:
               - We want to limit the amount of times we call an API due to the Freemium limitations on most common APIs
               - Ie., we only want to update our DB on command, not every time we load a page (I'm broke and can't afford it)
               - Automatically execute these methods in the Create() method of applicable controllers
               - This will fill our DB with data every time we click "Create New"
       */

        /// <summary>
        /// Data pulled from: https://rapidapi.com/DataCrawler/api/tripadvisor16
        /// </summary>
        public static void PopulateFlightTable(ApplicationDbContext _context, Flight flight)
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
        public static void PopulateDestinationTable(ApplicationDbContext _context, Destination destination)
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
        public static void PopulateStayTable(ApplicationDbContext _context, Stay stay)
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
                var totalEntries = JsonToObject.JsonToStay(responseMessage.Content.ReadAsStringAsync().Result, _context, stay);

                foreach (var entry in totalEntries) {
                     _context.Stays.Add(entry);
                }
                _context.SaveChanges();
            } 
        }

        /// <summary>
        /// Method <c>PopulateAirportTable()</c> reads a local JSON file in full and seeds the DB with the JSON contents
        /// <para>JSON was pulled from: https://rapidapi.com/aviolog-aviolog-default/api/akrx</para>
        /// <para>Saved as a local file for performance purposes (it returns a ton of data)</para>
        /// <para><param name="_context">_context : Represents the table of the database being worked with</param></para>
        /// <para><param name="_httpClient">_httpClient : Represents the protocol used to GET the API response</param></para>
        /// </summary>
        public static void PopulateAirportTable(ApplicationDbContext _context)
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