using Newtonsoft.Json;
using System;
using System.Globalization;

namespace FaithVentures.Models {
    public class FaithVenturesDate {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("timezone_type")]
        public string TimezoneType { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        public DateTime ToDateTime() {
            return DateTime.Parse(this.Date, new CultureInfo("en-US"), DateTimeStyles.AssumeUniversal);
        }
    }
}
