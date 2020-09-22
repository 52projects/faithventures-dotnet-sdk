using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FaithVentures.Models {
    public class Invoice {
        // "invoiceId": 114277,
        [JsonProperty("invoiceId")]
        public int InvoiceId { get; set; }

        // "number": "201109420377",
        [JsonProperty("number")]
        public string Number { get; set; }

        // "expeditionNumber": "201109420377",
        [JsonProperty("expeditionNumber")]
        public string ExpeditionNumber { get; set; }

        [JsonProperty("invoiceItems")]
        public List<InvoiceItem> InvoiceItems { get; set; }

        [JsonProperty("invoicePayment")]
        public InvoicePayment InvoicePayment { get; set; }

        // "description": "Headcount | Reserved Seats | Submit applicati",
        [JsonProperty("description")]
        public string Description { get; set; }

        // "contactFirstName": "Test",
        [JsonProperty("contactFirstName")]
        public string ContactFirstName { get; set; }

        // "contactLastName": "Test",
        [JsonProperty("contactLastName")]
        public string ContactLastName { get; set; }

        // "contactAddress1": "123 Test ST",
        [JsonProperty("contactAddress1")]
        public string ContactAddress1 { get; set; }

        // "contactAddress2": "SUITE 456",
        [JsonProperty("contactAddress2")]
        public string ContactAddress2 { get; set; }

        // "contactCountryCode": "US",
        [JsonProperty("contactCountryCode")]
        public string ContactCountryCode { get; set; }

        // "contactStateCode": "MN",
        [JsonProperty("contactStateCode")]
        public string ContactStateCode { get; set; }

        // "contactCity": "Testville",
        [JsonProperty("contactCity")]
        public string ContactCity { get; set; }

        // "contactPostalCode": "55544",
        [JsonProperty("contactPostalCode")]
        public string ContactPostalCode { get; set; }

        // "contactPhone": "555-555-5555",
        [JsonProperty("contactPhone")]
        public string ContactPhone { get; set; }

        // "groupName": null,
        [JsonProperty("groupName")]
        public string GroupName { get; set; }

        // "groupAddress1": null,
        [JsonProperty("groupAddress1")]
        public string GroupAddress1 { get; set; }

        // "groupAddress2": null,
        [JsonProperty("groupAddress2")]
        public string GroupAddress2 { get; set; }

        // "groupCountryCode": null,
        [JsonProperty("groupCountryCode")]
        public string GroupCountryCode { get; set; }

        // "groupStateCode": null,
        [JsonProperty("groupStateCode")]
        public string GroupStateCode { get; set; }

        // "groupCity": null,
        [JsonProperty("groupCity")]
        public string GroupCity { get; set; }

        // "groupPostalCode": null,
        [JsonProperty("groupPostalCode")]
        public string GroupPostalCode { get; set; }

        // "groupPhone": null,
        [JsonProperty("groupPhone")]
        public string GroupPhone { get; set; }

        // "groupUrl": null,
        [JsonProperty("groupUrl")]
        public string GroupUrl { get; set; }

        [JsonProperty("sellingPriceAmountsByProductType")]
        public Dictionary<string, string> SellingPriceAmountsByProductType { get; set; }
        
        // "totalSaleAmountForMainProductsOnly": 90,
        [JsonProperty("totalSaleAmountForMainProductsOnly")]
        public int TotalSaleAmountForMainProductsOnly { get; set; }

        // "totalNumberOfMainProducts": 3,
        [JsonProperty("totalNumberOfMainProducts")]
        public int TotalNumberOfMainProducts { get; set; }

        // "totalRetailPrice": 90,
        [JsonProperty("totalRetailPrice")]
        public int TotalRetailPrice { get; set; }

        // "totalShippingCost": 0,
        [JsonProperty("totalShippingCost")]
        public int TotalShippingCost { get; set; }

        // "totalNumberOfCardsToShip": 3,
        [JsonProperty("totalNumberOfCardsToShip")]
        public int TotalNumberOfCardsToShip { get; set; }

        // "totalDiscountAmount": 0,
        [JsonProperty("totalDiscountAmount")]
        public int TotalDiscountAmount { get; set; }

        // "totalSaleAmount": 90,
        [JsonProperty("totalSaleAmount")]
        public int TotalSaleAmount { get; set; }

        [JsonProperty("totalSaleAmountByProductType")]
        public Dictionary<string, string> TotalSaleAmountByProductType { get; set; }

        [JsonProperty("totalNumberOfTravelersByProductType")]
        public Dictionary<string, string> TotalNumberOfTravelersByProductType { get; set; }

        [JsonProperty("dateCreated")]
        public FaithVenturesDate DateCreated { get; set; }
    }
}
