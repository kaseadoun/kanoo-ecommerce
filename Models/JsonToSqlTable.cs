
using Newtonsoft.Json;

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
                - Later, add this class to the Create() method of applicable controllers
                - This will fill our DB with data and not take too many calls
        */
        static Uri baseAddress = new Uri("https://www.timeapi.io/api");

        public JsonToSqlTable(){}

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
    }
}