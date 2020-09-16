using System.Collections.Generic;
using System.Threading.Tasks;
using FaithVentures.Models;

namespace FaithVentures.Sets {
    public class PolicySet : BaseSet<Policy> {
        public PolicySet(FaithVenturesOptions options) : base(options) {
        }

        public async Task<IFaithVenturesSearchResponse<Policy>> GetPolicyAsync(string policyID) {
            var searchObject = new Dictionary<string, string>();
            if (policyID != null) {
                searchObject.Add("policyId", policyID);
            }
            return await base.PostAsync($"/wpcc/api/1.0/search/policies", searchObject);
        }
    }
}