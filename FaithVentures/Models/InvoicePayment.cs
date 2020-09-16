using System;
using Newtonsoft.Json;

namespace FaithVentures.Models {
    public class InvoicePayment {
        // "type": "CREDIT_CARD",
        [JsonProperty("type")]
        public string type { get; set; }

        // "cardVendor": "CA",
        [JsonProperty("cardVendor")]
        public string cardVendor { get; set; }

        // "cardLastFourDigits": "4508",
        [JsonProperty("cardLastFourDigits")]
        public string cardLastFourDigits { get; set; }

        // "cardExpirationMonth": "04",
        [JsonProperty("cardExpirationMonth")]
        public string cardExpirationMonth { get; set; }

        // "cardExpirationYear": "24",
        [JsonProperty("cardExpirationYear")]
        public string cardExpirationYear { get; set; }

        // "billingFirstName": "Archie",
        [JsonProperty("billingFirstName")]
        public string billingFirstName { get; set; }

        // "billingMiddleName": "",
        [JsonProperty("billingMiddleName")]
        public string billingMiddleName { get; set; }

        // "billingLastName": "Smith",
        [JsonProperty("billingLastName")]
        public string billingLastName { get; set; }

        // "billingName": null,
        [JsonProperty("billingName")]
        public string billingName { get; set; }

        // "billingAddress1": "123 Main Street",
        [JsonProperty("billingAddress1")]
        public string billingAddress1 { get; set; }

        // "billingAddress2": "",
        [JsonProperty("billingAddress2")]
        public string billingAddress2 { get; set; }

        // "billingCity": "Dallas",
        [JsonProperty("billingCity")]
        public string billingCity { get; set; }

        // "billingStateCode": "TX",
        [JsonProperty("billingStateCode")]
        public string billingStateCode { get; set; }

        // "billingPostalCode": "77777",
        [JsonProperty("billingPostalCode")]
        public string billingPostalCode { get; set; }

        // "billingCountryCode": "US",
        [JsonProperty("billingCountryCode")]
        public string billingCountryCode { get; set; }

        [JsonProperty("dateCreated")]
        public FaithVenturesDate dateCreated { get; set; }

        [JsonProperty("dateUpdated")]
        public FaithVenturesDate dateUpdated { get; set; }

        // "dateCheckReceived": null
        [JsonProperty("dateCheckReceived")]
        public FaithVenturesDate dateCheckReceived { get; set; }
    }
}
