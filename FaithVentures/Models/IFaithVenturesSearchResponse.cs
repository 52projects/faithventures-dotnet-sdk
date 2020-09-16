using Newtonsoft.Json;
using System.Collections.Generic;

namespace FaithVentures.Models {
    public interface IFaithVenturesSearchResponse {
        int CurrentPageItemsCount { get; set; }

        int CurrentPageNumber { get; set; }

        int TotalNumberOfPages { get; set; }

        int MaxNumberOfItemsPerPage { get; set; }

        Dictionary<string, string> OriginalRequest { get; set; }
    }

    public interface IFaithVenturesSearchResponse<T> : IFaithVenturesSearchResponse {
        List<T> CurrentPageItems { get; set; }
    }
    public class FaithVenturesSearchResponse : IFaithVenturesSearchResponse {
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

    public class FaithVenturesSearchResponse<T> : FaithVenturesSearchResponse, IFaithVenturesSearchResponse<T> where T : new() {
        public List<T> CurrentPageItems { get; set; }
    }
}
