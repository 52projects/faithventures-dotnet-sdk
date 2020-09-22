using System;
using Newtonsoft.Json;

namespace FaithVentures.Models {
    public class InvoicePayment {
        // "type": "CREDIT_CARD",
        [JsonProperty("type")]
        public string Type { get; set; }

        // "cardVendor": "CA",
        [JsonProperty("cardVendor")]
        public string CardVendor { get; set; }

        // "cardLastFourDigits": "4508",
        [JsonProperty("cardLastFourDigits")]
        public string CardLastFourDigits { get; set; }

        // "cardExpirationMonth": "04",
        [JsonProperty("cardExpirationMonth")]
        public string CardExpirationMonth { get; set; }

        // "cardExpirationYear": "24",
        [JsonProperty("cardExpirationYear")]
        public string CardExpirationYear { get; set; }

        // "billingFirstName": "Archie",
        [JsonProperty("billingFirstName")]
        public string BillingFirstName { get; set; }

        // "billingMiddleName": "",
        [JsonProperty("billingMiddleName")]
        public string BillingMiddleName { get; set; }

        // "billingLastName": "Smith",
        [JsonProperty("billingLastName")]
        public string BillingLastName { get; set; }

        // "billingName": null,
        [JsonProperty("billingName")]
        public string BillingName { get; set; }

        // "billingAddress1": "123 Main Street",
        [JsonProperty("billingAddress1")]
        public string BillingAddress1 { get; set; }

        // "billingAddress2": "",
        [JsonProperty("billingAddress2")]
        public string BillingAddress2 { get; set; }

        // "billingCity": "Dallas",
        [JsonProperty("billingCity")]
        public string BillingCity { get; set; }

        // "billingStateCode": "TX",
        [JsonProperty("billingStateCode")]
        public string BillingStateCode { get; set; }

        // "billingPostalCode": "77777",
        [JsonProperty("billingPostalCode")]
        public string BillingPostalCode { get; set; }

        // "billingCountryCode": "US",
        [JsonProperty("billingCountryCode")]
        public string BillingCountryCode { get; set; }

        [JsonProperty("dateCreated")]
        public FaithVenturesDate DateCreated { get; set; }

        [JsonProperty("dateUpdated")]
        public FaithVenturesDate DateUpdated { get; set; }

        // "dateCheckReceived": null
        [JsonProperty("dateCheckReceived")]
        public FaithVenturesDate DateCheckReceived { get; set; }
    }
}
