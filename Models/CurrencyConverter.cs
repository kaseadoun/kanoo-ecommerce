using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kanoo.Models
{
    public class CurrencyConverter
    {
        static readonly HttpClient _httpClient = new HttpClient();

        /// <summary>
        /// Data pulled from: https://rapidapi.com/fyhao/api/currency-exchange/
        /// <para>"GET/HExchange"</para>
        /// </summary>
        public static decimal ConvertToCAD(string currency, decimal amount)
        {
             var builder = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.Development.json");

            var config = builder.Build();
            var key = config["Api:X-RapidAPI-Key"];
            var host = config["Api:X-RapidAPI-Currency-Host"];

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,

                RequestUri = new Uri(String
                    .Format("https://currency-exchange.p.rapidapi.com/exchange?to=CAD&from={0}&q={1}", 
                            currency, amount)),
                Headers =
                {
                    { "X-RapidAPI-Key", key },
                    { "X-RapidAPI-Host", host },
                },
            };

            HttpResponseMessage responseMessage = _httpClient.SendAsync(request).Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                return Convert.ToDecimal(responseMessage.Content.ReadAsStringAsync().Result);
            } 
            else
            {
                return amount;
            }
        }
    }
}