using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FaithVentures.Models {
    public class Invoice {
        // "invoiceId": 114277,
        [JsonProperty("invoiceId")]
        public int invoiceId { get; set; }

        // "number": "201109420377",
        [JsonProperty("number")]
        public string number { get; set; }

        // "expeditionNumber": "201109420377",
        [JsonProperty("expeditionNumber")]
        public string expeditionNumber { get; set; }

        [JsonProperty("invoiceItems")]
        public List<InvoiceItem> invoiceItems { get; set; }

        [JsonProperty("invoicePayment")]
        public InvoicePayment invoicePayment { get; set; }

        // "description": "Headcount | Reserved Seats | Submit applicati",
        [JsonProperty("description")]
        public string description { get; set; }

        // "contactFirstName": "Test",
        [JsonProperty("contactFirstName")]
        public string contactFirstName { get; set; }

        // "contactLastName": "Test",
        [JsonProperty("contactLastName")]
        public string contactLastName { get; set; }

        // "contactAddress1": "123 Test ST",
        [JsonProperty("contactAddress1")]
        public string contactAddress1 { get; set; }

        // "contactAddress2": "SUITE 456",
        [JsonProperty("contactAddress2")]
        public string contactAddress2 { get; set; }

        // "contactCountryCode": "US",
        [JsonProperty("contactCountryCode")]
        public string contactCountryCode { get; set; }

        // "contactStateCode": "MN",
        [JsonProperty("contactStateCode")]
        public string contactStateCode { get; set; }

        // "contactCity": "Testville",
        [JsonProperty("contactCity")]
        public string contactCity { get; set; }

        // "contactPostalCode": "55544",
        [JsonProperty("contactPostalCode")]
        public string contactPostalCode { get; set; }

        // "contactPhone": "555-555-5555",
        [JsonProperty("contactPhone")]
        public string contactPhone { get; set; }

        // "groupName": null,
        [JsonProperty("groupName")]
        public string groupName { get; set; }

        // "groupAddress1": null,
        [JsonProperty("groupAddress1")]
        public string groupAddress1 { get; set; }

        // "groupAddress2": null,
        [JsonProperty("groupAddress2")]
        public string groupAddress2 { get; set; }

        // "groupCountryCode": null,
        [JsonProperty("groupCountryCode")]
        public string groupCountryCode { get; set; }

        // "groupStateCode": null,
        [JsonProperty("groupStateCode")]
        public string groupStateCode { get; set; }

        // "groupCity": null,
        [JsonProperty("groupCity")]
        public string groupCity { get; set; }

        // "groupPostalCode": null,
        [JsonProperty("groupPostalCode")]
        public string groupPostalCode { get; set; }

        // "groupPhone": null,
        [JsonProperty("groupPhone")]
        public string groupPhone { get; set; }

        // "groupUrl": null,
        [JsonProperty("groupUrl")]
        public string groupUrl { get; set; }

        [JsonProperty("sellingPriceAmountsByProductType")]
        public Dictionary<string, string> sellingPriceAmountsByProductType { get; set; }
        
        // "totalSaleAmountForMainProductsOnly": 90,
        [JsonProperty("totalSaleAmountForMainProductsOnly")]
        public int totalSaleAmountForMainProductsOnly { get; set; }

        // "totalNumberOfMainProducts": 3,
        [JsonProperty("totalNumberOfMainProducts")]
        public int totalNumberOfMainProducts { get; set; }

        // "totalRetailPrice": 90,
        [JsonProperty("totalRetailPrice")]
        public int totalRetailPrice { get; set; }

        // "totalShippingCost": 0,
        [JsonProperty("totalShippingCost")]
        public int totalShippingCost { get; set; }

        // "totalNumberOfCardsToShip": 3,
        [JsonProperty("totalNumberOfCardsToShip")]
        public int totalNumberOfCardsToShip { get; set; }

        // "totalDiscountAmount": 0,
        [JsonProperty("totalDiscountAmount")]
        public int totalDiscountAmount { get; set; }

        // "totalSaleAmount": 90,
        [JsonProperty("totalSaleAmount")]
        public int totalSaleAmount { get; set; }

        [JsonProperty("totalSaleAmountByProductType")]
        public Dictionary<string, string> totalSaleAmountByProductType { get; set; }

        [JsonProperty("totalNumberOfTravelersByProductType")]
        public Dictionary<string, string> totalNumberOfTravelersByProductType { get; set; }

        [JsonProperty("dateCreated")]
        public FaithVenturesDate dateCreated { get; set; }
    }
}
