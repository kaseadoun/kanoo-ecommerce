using System.Text.Json.Nodes;

namespace Kanoo.Models
{
    /// <summary>
    /// Class <c>JsonToObject</c> will turns JSON strings into a DOM, then translates the JSON into a specified object
    /// <para>Method <c>JsonToFlight()</c> Creates new Flight objects from the JSON</para>
    /// <para>Method <c>JsonToAirport()</c> Creates new Airport objects from the JSON</para>
    /// <para><param name="json">json : Represents the JSON being read from</param></para>
    /// </summary>
    public class JsonToObject
    {
        private JsonToObject() {}

        /*  https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/use-dom#how-to-search-a-jsondocument-and-jsonelement-for-sub-elements
            https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonnode?view=net-7.0
            
            * TL;DR: Turn the JSON into a DOM and navigate through it to find the values we want. Assign the values as properties of the Model we are using. */
        
        public static List<Flight> JsonToFlight(string json, ApplicationDbContext _context, Flight flight)
        {
            // JsonNode() takes a JSON string and turns it into a DOM
            // We can access parts of data in the DOM in a very similar way to CSS/JS
            JsonNode node = JsonNode.Parse(json)!;

            // Create an empty list of objects to hold the data we will extract
            List<Flight> totalEntries = new List<Flight>();

            try
            {
                // Count how many entries were returned by the API
                int totalNodes = node!["data"]["flights"].AsArray().Count();

                // If there is more than 5 entries returned, only evaluate the first 5
                totalNodes = (totalNodes > 5) ? 5 : totalNodes;
                
                // For each entry returned by the API, make a new object representing its data
                for (var i = 0; i < totalNodes; i++)
                {
                    Flight n = new Flight();

                    var ArriveCode = _context.Airports
                        .FirstOrDefault(entity => entity.IataCode == node!["data"]["flights"][i]["segments"][0]["legs"][0]["originStationCode"].ToString());
                    var DepartCode = _context.Airports
                        .FirstOrDefault(entity => entity.IataCode == node!["data"]["flights"][i]["segments"][0]["legs"][0]["destinationStationCode"].ToString());

                    n.From = ArriveCode.IataCode.ToString();
                    n.To = DepartCode.IataCode.ToString();
                    n.Departure = (DateTime)node!["data"]["flights"][i]["segments"][0]["legs"][0]["departureDateTime"];
                    // n.Return = (DateTime)node!["data"]["flights"][i]["segments"][0]["legs"][0]["arrivalDateTime"];
                    n.ServiceClass = flight.ServiceClass;
                    n.ArrivalAirportId = ArriveCode.Id;
                    n.DepartureAirportId = DepartCode.Id;

                    // Get the cost in local currency
                    var localCost = (decimal)node!["data"]["flights"][i]["purchaseLinks"][0]["totalPrice"];
                    var localCurrency = node!["data"]["flights"][i]["purchaseLinks"][0]["currency"].ToString();
                    
                    // Convert local currency into CAD
                    if (localCurrency != "CAD")
                    {
                        n.Price = CurrencyConverter.ConvertToCAD(localCurrency, localCost);
                    }
                    else
                    {
                        n.Price = localCost;
                    }

                    // Only add to the DB if it is a valid flight that can be purchased
                    if (n.Price > 0)
                    {
                        totalEntries.Add(n);
                    }
                }
                // Return all of the JSON data as a list of objects
                return totalEntries;
            }
            // If the JSON object does not have the property, catch the error and make the property null
            catch (NullReferenceException e) 
            {
                Console.WriteLine(e.Message);
                return totalEntries;
            }
        }

        public static List<Destination> JsonToDestination(string json)
        {
            JsonNode node = JsonNode.Parse(json)!;

            List<Destination> totalEntries = new List<Destination>();

            try
            {
                int totalNodes = node!["data"].AsArray().Count();
                
                for (var i = 0; i < totalNodes; i++)
                {
                    if (node!["data"][i]["type"].ToString() == "CITY")
                    {
                        Destination n = new Destination();
                        
                        n.Id = Convert.ToInt32(node!["data"][i]["gaiaId"].ToString());
                        n.Country = node!["data"][i]["hierarchyInfo"]["country"]["name"].ToString();
                        n.City = node!["data"][i]["regionNames"]["shortName"].ToString();
                        n.Latitude = Convert.ToDouble(node!["data"][i]["coordinates"]["lat"].ToString());
                        n.Longitude = Convert.ToDouble(node!["data"][i]["coordinates"]["long"].ToString());
                        
                        totalEntries.Add(n);
                    }
                }
                return totalEntries;
            }
            catch (NullReferenceException e) 
            {
                Console.WriteLine(e.Message);
                return totalEntries;
            }
        }
        
        public static List<Stay> JsonToStay(string json, Stay stay)
        {
            JsonNode node = JsonNode.Parse(json)!;

            List<Stay> totalEntries = new List<Stay>();

            try
            {
                int totalNodes = node!["properties"].AsArray().Count();

                // If there is more than 5 entries returned, only evaluate the first 5.=
                totalNodes = (totalNodes > 5) ? 5 : totalNodes;
                
                for (var i = 0; i < totalNodes; i++)
                {
                    Stay n = new Stay();

                    n.DestinationName = node!["properties"][i]["neighborhood"]["name"].ToString();
                    n.HotelName = node!["properties"][i]["name"].ToString();
                    n.RegionId = stay.RegionId;
                    n.StartDate = stay.StartDate;
                    n.EndDate = stay.EndDate;
                    n.Rooms = stay.Rooms;
                    n.Adults = stay.Adults;

                    // Get the cost in local currency
                    var localCost = (decimal)node!["properties"][i]["price"]["lead"]["amount"];
                    var localCurrency = node!["properties"][i]["price"]["lead"]["currencyInfo"]["code"].ToString();
                    
                    // Convert local currency into CAD
                    if (localCurrency != "CAD")
                    {
                        n.PricePerDay = CurrencyConverter.ConvertToCAD(localCurrency, localCost);
                    }
                    else
                    {
                        n.PricePerDay = localCost;
                    }

                    totalEntries.Add(n);
                }
                // Return all of the JSON data as a list of objects
                return totalEntries;
            }
            // If the JSON object does not have the property, catch the error and make the property null
            catch (NullReferenceException e) 
            {
                Console.WriteLine(e.Message);
                return totalEntries;
            }
        }
        
        public static List<Car> JsonToCar(string json, Car car)
        {
            JsonNode node = JsonNode.Parse(json)!;

            List<Car> totalEntries = new List<Car>();

            try
            {
                int totalNodes = node!["search_results"].AsArray().Count();

                // If there is more than 5 entries returned, only evaluate the first 5
                totalNodes = (totalNodes > 5) ? 5 : totalNodes;
                
                for (var i = 0; i < totalNodes; i++)
                {
                    // Some of the objects returned have different formatting. We only want ones with pricing info
                    if (node!["search_results"][i]["pricing_info"] != null)
                    {
                        Car n = new Car();

                        n.DestinationName = node!["search_results"][i]["route_info"]["pickup"]["name"].ToString();
                        n.CompanyName = node!["search_results"][i]["supplier_info"]["name"].ToString();
                        n.Region = car.Region;
                        n.StartDate = car.StartDate;
                        n.EndDate = car.EndDate;
                        n.TypeOfCar = node!["search_results"][i]["vehicle_info"]["v_name"].ToString();
                        n.NumOfDrivers = car.NumOfDrivers;

                        // Get the cost in local currency
                        var localCost = (decimal)node!["search_results"][i]["pricing_info"]["drive_away_price"];
                        var localCurrency = node!["search_results"][i]["pricing_info"]["currency"].ToString();

                        // Convert local currency into CAD
                        if (localCurrency != "CAD")
                        {
                            n.PricePerDay = CurrencyConverter.ConvertToCAD(localCurrency, localCost);
                        }
                        else
                        {
                            n.PricePerDay = localCost;
                        }
                    
                    totalEntries.Add(n);
                    }
                }
                // Return all of the JSON data as a list of objects
                return totalEntries;
            }
            // If the JSON object does not have the property, catch the error and make the property null
            catch (NullReferenceException e) 
            {
                Console.WriteLine(e.Message);
                return totalEntries;
            }
        }

        public static List<Airport> JsonToAirport(string json)
        {
            JsonNode node = JsonNode.Parse(json)!;
            List<Airport> totalEntries = new List<Airport>();
            int totalNodes =
                node!["airports"].AsArray().Count();

            for (var i = 0; i < totalNodes; i++)
            {
                Airport n = new Airport();

                try 
                {
                    if (node!["airports"][i]["airportIata"] != null)
                    {
                        n.IataCode = node!["airports"][i]["airportIata"].ToString();
                        n.AirportName = node!["airports"][i]["airportName"].ToString();
                        totalEntries.Add(n);
                    }
                }
                
                // If the JSON object does not have the property, catch the error and make the property null
                catch (NullReferenceException e) 
                {
                    Console.WriteLine(e.Message);
                }
            }
            return totalEntries;
        }
    }
}