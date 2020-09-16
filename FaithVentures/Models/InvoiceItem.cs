using System;
using Newtonsoft.Json;

namespace FaithVentures.Models {
    public class InvoiceItem {
        // "productSku": "BAAR",
        [JsonProperty("productSku")]
        public string ProductSku { get; set; }

        // "productName": "Basic Plan",
        [JsonProperty("productName")]
        public string ProductName { get; set; }

        // "productType": "BASIC",
        [JsonProperty("productType")]
        public string ProductType { get; set; }

        // "policyNumber": "F 2071 0928 0341",
        [JsonProperty("policyNumber")]
        public string PolicyNumber { get; set; }

        // "policyFirstName": "Student",
        [JsonProperty("policyFirstName")]
        public string PolicyFirstName { get; set; }

        // "policyMiddleName": null,
        [JsonProperty("policyMiddleName")]
        public string PolicyMiddleName { get; set; }

        // "policyLastName": "Bear",
        [JsonProperty("policyLastName")]
        public string PolicyLastName { get; set; }

        // "description": "BASIC Policy for Student Bear 09/05/2020 - 09",
        [JsonProperty("description")]
        public string Description { get; set; }

        // "discounted": "0.00",
        [JsonProperty("discounted")]
        public string Discounted { get; set; }

        // "shippingCost": "0.00",
        [JsonProperty("shippingCost")]
        public string ShippingCost { get; set; }

        // "productRetailPrice": 30,
        [JsonProperty("productRetailPrice")]
        public string ProductRetailPrice { get; set; }

        // "productSellingPrice": 30,
        [JsonProperty("productSellingPrice")]
        public string ProductSellingPrice { get; set; }

        // "productSellingPriceNoShipping": 30
        [JsonProperty("productSellingPriceNoShipping")]
        public string ProductSellingPriceNoShipping { get; set; }

    }
}
