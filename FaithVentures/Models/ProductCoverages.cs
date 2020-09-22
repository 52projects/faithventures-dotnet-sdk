using Newtonsoft.Json;

namespace FaithVentures.Models {
    public class ProductCoverage {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("valueType")]
        public string ValueType { get; set; }

        [JsonProperty("sortOrder")]
        public string SortOrder { get; set; }
    }
}
