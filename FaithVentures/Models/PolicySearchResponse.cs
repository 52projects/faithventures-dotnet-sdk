using Newtonsoft.Json;
using System.Collections.Generic;

namespace FaithVentures.Models {
    public class PolicySearchResponse : IFaithVenturesSearchResponse {
        // "currentPageItemsCount": 2,
        [JsonProperty("currentPageItemsCount")]
        public int CurrentPageItemsCount { get; set; }

        // "currentPageNumber": 1,
        [JsonProperty("currentPageNumber")]
        public int CurrentPageNumber { get; set; }

        // "totalNumberOfPages": 1,
        [JsonProperty("totalNumberOfPages")]
        public int TotalNumberOfPages { get; set; }

        // "maxNumberOfItemsPerPage": 500,
        [JsonProperty("maxNumberOfItemsPerPage")]
        public int MaxNumberOfItemsPerPage { get; set; }

        [JsonProperty("originalRequest")]
        public Dictionary<string, string> OriginalRequest { get; set; }
    }

    public class PolicySearchResponse<Policy> : PolicySearchResponse, IFaithVenturesSearchResponse<Policy> where Policy : new() {
        public List<Policy> CurrentPageItems { get; set; }
    }
}
