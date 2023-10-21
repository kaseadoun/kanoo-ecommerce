using System.ComponentModel.DataAnnotations;

namespace Kanoo.Models
{
    // ! THIS MODEL IS ONLY FOR TESTING PURPOSES!
    public class Api
    {
        // Mirror this data based on what is returned by the JSON
        // Use this tool to get an accurate data model: https://json2csharp.com/

        [Key]
        public int id { get; set; }
        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }
        public int hour { get; set; }
        public int minute { get; set; }
        public int seconds { get; set; }
        public int milliSeconds { get; set; }
        public DateTime dateTime { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public string timeZone { get; set; }
        public string dayOfWeek { get; set; }
        public bool dstActive { get; set; }

    }
}