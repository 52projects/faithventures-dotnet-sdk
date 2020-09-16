using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FaithVentures.Models {
    public class Expedition {
        // "expeditionId": 114277,
        [JsonProperty("expeditionId")]
        public int ExpeditionId { get; set; }

        // "number": "201109420377",
        [JsonProperty("number")]
        public string Number { get; set; }

        // "contactFirstName": "Test",
        [JsonProperty("contactFirstName")]
        public string ContactFirstName { get; set; }

        // "contactMiddleName": null,
        [JsonProperty("contactMiddleName")]
        public string ContactMiddleName { get; set; }

        // "contactLastName": "Test",
        [JsonProperty("contactLastName")]
        public string ContactLastName { get; set; }

        // "contactEmail": "contact@email.com",
        [JsonProperty("contactEmail")]
        public string ContactEmail { get; set; }

        // "contactAddress1": "123 Test ST",
        [JsonProperty("contactAddress1")]
        public string ContactAddress1 { get; set; }

        // "contactAddress2": "SUITE 456",
        [JsonProperty("contactAddress2")]
        public string ContactAddress2 { get; set; }

        // "contactCity": "Testville",
        [JsonProperty("contactCity")]
        public string ContactCity { get; set; }

        // "contactStateCode": "MN",
        [JsonProperty("contactStateCode")]
        public string ContactStateCode { get; set; }

        // "contactPostalCode": "55544",
        [JsonProperty("contactPostalCode")]
        public string ContactPostalCode { get; set; }

        // "contactCountryCode": "US",
        [JsonProperty("contactCountryCode")]
        public string ContactCountryCode { get; set; }

        // "contactOrganizationName": "52projects Church",
        [JsonProperty("contactOrganizationName")]
        public string ContactOrganizationName { get; set; }

        // "groupName": null,
        [JsonProperty("groupName")]
        public string GroupName { get; set; }

        // "groupEmail": null,
        [JsonProperty("groupEmail")]
        public string GroupEmail { get; set; }

        // "groupAddress1": null,
        [JsonProperty("groupAddress1")]
        public string GroupAddress1 { get; set; }

        // "groupAddress2": null,
        [JsonProperty("groupAddress2")]
        public string GroupAddress2 { get; set; }

        // "groupCity": null,
        [JsonProperty("groupCity")]
        public string GroupCity { get; set; }

        // "groupStateCode": null,
        [JsonProperty("groupStateCode")]
        public string GroupStateCode { get; set; }

        // "groupPostalCode": null,
        [JsonProperty("groupPostalCode")]
        public string GroupPostalCode { get; set; }

        // "groupCountryCode": null,
        [JsonProperty("groupCountryCode")]
        public string GroupCountryCode { get; set; }

        // "policies"
        [JsonProperty("policies")]
        public List<Policy> Policies { get; set; }

        // "invoices"
        [JsonProperty("invoices")]
        public List<Invoice> Invoices { get; set; }
            
        // "description": "Headcount | Reserved Seats | Submit application",
        [JsonProperty("description")]
        public string Description { get; set; }

        // "departureCountryCode": null,
        [JsonProperty("departureCountryCode")]
        public string DepartureCountryCode { get; set; }

        // "arrivalCountryCode": "US",
        [JsonProperty("arrivalCountryCode")]
        public string ArrivalCountryCode { get; set; }

        // "dateVerified": null,
        [JsonProperty("dateVerified")]
        public FaithVenturesDate DateVerified { get; set; }

        // "dateCreated"
        [JsonProperty("dateCreated")]
        public FaithVenturesDate DateCreated { get; set; }

    }
}
