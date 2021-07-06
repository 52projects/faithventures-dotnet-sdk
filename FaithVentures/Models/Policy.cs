using Newtonsoft.Json;
using System.Collections.Generic;

namespace FaithVentures.Models {
    public class Policy {
        // "policyId": 712845,
        [JsonProperty("policyId")]
        public int PolicyID { get; set; }

        // "expedition_expeditionId": 114278,
        [JsonProperty("expedition_expeditionId")]
        public int ExpeditionID { get; set; }

        // "contact_contactId": null,
        [JsonProperty("contact_contactId")]
        public string ContactID { get; set; }

        // "travelerFirstName": "Baby",
        [JsonProperty("travelerFirstName")]
        public string FirstName { get; set; }

        // "travelerMiddleName": "",
        [JsonProperty("travelerMiddleName")]
        public string MiddleName { get; set; }

        // "travelerLastName": "Bear",
        [JsonProperty("travelerLastName")]
        public string LastName { get; set; }

        // "travelerEmail": "",
        [JsonProperty("travelerEmail")]
        public string Email { get; set; }

        // "previousPolicyId": 0,
        [JsonProperty("previousPolicyId")]
        public int PreviousPolicyId { get; set; }

        // "addedOnToPolicyId": null,
        [JsonProperty("addedOnToPolicyId")]
        public string AddedOnToPolicyId { get; set; }

        // "policyDependents": [],
        [JsonProperty("policyDependents")]
        public List<string> PolicyDependents { get; set; }

        // "productCategory": "SHORT",
        [JsonProperty("productCategory")]
        public string ProductCategory { get; set; }

        // "productType": "PLUS",
        [JsonProperty("productType")]
        public string ProductType { get; set; }

        // "productTypeLabel": "Travel Insurance Cards",
        [JsonProperty("productTypeLabel")]
        public string ProductTypeLabel { get; set; }

        // "productAbbreviation": null,
        [JsonProperty("productAbbreviation")]
        public string ProductAbbreviation { get; set; }

        // "productShortDescription": null,
        [JsonProperty("productShortDescription")]
        public string ProductShortDescription { get; set; }

        // "productName": "Plus Plan",
        [JsonProperty("productName")]
        public string ProductName { get; set; }

        // "productInsuranceNumber": "Faith Ventures Plus Plan",
        [JsonProperty("productInsuranceNumber")]
        public string ProductInsuranceNumber { get; set; }

        // "productInsuranceNumberLabel": "Plan Name",
        [JsonProperty("productInsuranceNumberLabel")]
        public string ProductInsuranceNumberLabel { get; set; }

        // "productInsuranceDocument": "https://www.faithventures.com/descriptionofcoverage-plus/",
        [JsonProperty("productInsuranceDocument")]
        public string ProductInsuranceDocument { get; set; }

        // "productInsuranceTollFreePhone": "1.844.359.0417",
        [JsonProperty("productInsuranceTollFreePhone")]
        public string ProductInsuranceTollFreePhone { get; set; }

        // "productInsurancePhone": "00 1.443.275.6001",
        [JsonProperty("productInsurancePhone")]
        public string ProductInsurancePhone { get; set; }

        // "productLocalPhone": null,
        [JsonProperty("productLocalPhone")]
        public string ProductLocalPhone { get; set; }

        // "productImageUri": "/wp-content/uploads/2019/07/thumbnail-plus.png",
        [JsonProperty("productImageUri")]
        public string ProductImageUri { get; set; }

        // "productPublicNotes": null,
        [JsonProperty("productPublicNotes")]
        public string ProductPublicNotes { get; set; }

        // "number": "F 2071 0928 0345",
        [JsonProperty("number")]
        public string Number { get; set; }

        // "tripCost": "0.00",
        [JsonProperty("tripCost")]
        public string TripCost { get; set; }

        // "eCardOnly": 1,
        [JsonProperty("eCardOnly")]
        public int ECardOnly { get; set; }

        // "productImageSurcharge": null,
        [JsonProperty("productImageSurcharge")]
        public string ProductImageSurcharge { get; set; }

        // "travelerDateOfBirth": null,
        [JsonProperty("travelerDateOfBirth")]
        public FaithVenturesDate TravelerDateOfBirth { get; set; }

        [JsonProperty("dateEffectiveStart")]
        public FaithVenturesDate DateEffectiveStart { get; set; }

        [JsonProperty("dateEffectiveEnd")]
        public FaithVenturesDate DateEffectiveEnd { get; set; }

        [JsonProperty("productCoverages")]
        public List<ProductCoverage> ProductCoverages { get; set; }

        public bool IsBasic() {
            return ProductType.ToUpper() == "BASIC";
        }

    }
}
