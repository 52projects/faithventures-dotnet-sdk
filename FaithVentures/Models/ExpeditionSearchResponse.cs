using Newtonsoft.Json;
using System.Collections.Generic;

namespace FaithVentures.Models {
    public class ExpeditionSearchResponse : IFaithVenturesSearchResponse {
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
        public Dictionary<string, dynamic> OriginalRequest { get; set; }
    }

    public class ExpeditionSearchResponse<Expedition> : ExpeditionSearchResponse, IFaithVenturesSearchResponse<Expedition> where Expedition : new() {
        public List<Expedition> CurrentPageItems { get; set; }
    }
}
