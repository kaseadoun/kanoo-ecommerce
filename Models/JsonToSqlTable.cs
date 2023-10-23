using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Text.Json.Nodes;

namespace Kanoo.Models
{
    /// <summary>
    /// Class <c>JsonToSqlTable</c> will handle calling the APIs and writing the values into rows in the database
    /// </summary>
    public class JsonToSqlTable
    {
        /*
           !IMPORTANT:
               - We want to limit the amount of times we call an API due to the Freemium limitations on most common APIs
               - Ie., we only want to update our DB on command, not every time we load a page (I'm broke and can't afford it)
               - Automatically execute these methods in the Create() method of applicable controllers
               - This will fill our DB with data every time we click "Create New"
       */
        private static Uri baseAddress = new Uri("https://www.timeapi.io/api");

        public JsonToSqlTable() { }

        /* 
            * Sends HTTP GET to the API and returns an HttpResponseMessage. 
            * The response body will contain the JSON if it succeeds
            * ReadAsStringAsync() will read the JSON returned by the API as a string
            * DeserializeObject() will convert the JSON into an object of type API
            * Said object can then be added to the database and saved as a row
        */
        /// <summary>
        /// Method <c>PopulateApiTable</c> submits a GET request to the API and populates the DB with the JSON contents
        /// <para><param name="_context">_context : Represents the table of the database being worked with</param></para>
        /// <para><param name="_httpClient">_httpClient : Represents the protocol used to GET the API response</param></para>
        /// </summary>
        public static void PopulateApiTable(ApplicationDbContext _context, HttpClient _httpClient)
        {
            _httpClient.BaseAddress = baseAddress;
            Api data = new Api();
            HttpResponseMessage responseMessage = _httpClient.GetAsync(_httpClient.BaseAddress + "/Time/current/zone?timeZone=Europe/Amsterdam").Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                string json = responseMessage.Content.ReadAsStringAsync().Result;
                data = JsonConvert.DeserializeObject<Api>(json);
                _context.Api.Add(data);
                _context.SaveChanges();
            }
        }

        public static void PopulateTravelTable(ApplicationDbContext _context, HttpClient _httpClient)
        {
            _httpClient.BaseAddress = baseAddress;

            // Create a secure ConfigurationBuilder() to read the API key and host from a hidden JSON
            // instead of hard-coding the values in the method
            var builder = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.Development.json");

            var config = builder.Build();
            var key = config["TravelAdvisorApi:X-RapidAPI-Key"];
            var host = config["TravelAdvisorApi:X-RapidAPI-Host"];

            // Create the request using the API URL and our hidden credentials
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://travel-advisor.p.rapidapi.com/locations/v2/auto-complete?query=Boston&lang=en_US&units=km"),
                Headers =
                {
                    { "X-RapidAPI-Key", key },
                    { "X-RapidAPI-Host", host },
                },
            };

            HttpResponseMessage responseMessage = _httpClient.SendAsync(request).Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                // GET the API JSON result and pass it as a string to JsonToObject()
                // JsonToObject() will extract all of the data we need to add to our object
                var totalEntries = JsonToObject(responseMessage.Content.ReadAsStringAsync().Result);

                // Add each new object to the database
                foreach (var entry in totalEntries) {
                     _context.TravelAdvisor.Add(entry);
                }
                _context.SaveChanges();
            }
        }

        /* https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/use-dom#how-to-search-a-jsondocument-and-jsonelement-for-sub-elements

        https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonnode?view=net-7.0
            
            * TL;DR: Turn the JSON into a DOM and navigate through it to find the values we want.
                     Assign the values as properties of the Model we are using.
        */
        private static List<TravelAdvisor> JsonToObject(string json)
        {
            // JsonNode() takes a JsonObject and turns it into a DOM
            // We can access parts of data in the DOM in a very similar way to CSS/JS
            JsonNode node = JsonNode.Parse(json)!;

            // Create an empty list of objects to hold the data we will extract
            List<TravelAdvisor> totalEntries = new List<TravelAdvisor>();

            // Count how many entries were returned by the API
            int totalNodes =
                node!["data"]["Typeahead_autocomplete"]["results"].AsArray().Count();

            // For each entry returned by the API, make a new object representing its data
            for (var i = 0; i < totalNodes; i++)
            {
                TravelAdvisor n = new TravelAdvisor();

                try {
                    n.text = node!["data"]["Typeahead_autocomplete"]["results"][i]["text"].ToString();
                    totalEntries.Add(n);
                }
                // If the JSON object does not have the property, catch the error and make the property null
                catch (NullReferenceException e) {
                    n.text = null;
                    Console.WriteLine(e.Message);
                }
            }
            // Return all of the JSON data as a list of objects
            return totalEntries;
        }
    }
}