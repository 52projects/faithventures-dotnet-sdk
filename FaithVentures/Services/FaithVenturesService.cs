using System.Collections.Generic;
using System.Threading.Tasks;

namespace FaithVentures.Services {
    public interface IFaithVenturesService {
        Task<Models.IFaithVenturesSearchResponse<Models.Expedition>> GetFaithVenturesExpeditionAsync(string expeditionID);

        Task<Models.IFaithVenturesSearchResponse<Models.Expedition>> GetFaithVenturesExpeditionsAsync(string personID);

        Task<Models.IFaithVenturesSearchResponse<Models.Expedition>> LinkOrderAsync(string personID, string orderNumber, string lastName, string role);

        Task<Models.IFaithVenturesSearchResponse<Models.Policy>> GetFaithVenturesPolicyAsync(string policyID);

        Task<Models.IFaithVenturesSearchResponse<Models.Policy>> GetFaithVenturesPoliciesAsync(List<string> policyIDs);
    }

    public class FaithVenturesService : IFaithVenturesService {
        private FaithVenturesClient _client;

        public FaithVenturesService(FaithVenturesOptions options) {
            _client = new FaithVenturesClient(options);
        }

        public async Task<Models.IFaithVenturesSearchResponse<Models.Expedition>> GetFaithVenturesExpeditionAsync(string expeditionID) {
            return await _client.Expeditions.GetExpeditionAsync(expeditionID);
        }

        public async Task<Models.IFaithVenturesSearchResponse<Models.Expedition>> GetFaithVenturesExpeditionsAsync(string personID) {
            return await _client.Expeditions.GetExpeditionsAsync(personID);
        }

        public async Task<Models.IFaithVenturesSearchResponse<Models.Expedition>> LinkOrderAsync(string personID, string orderNumber, string lastName, string role) {
            return await _client.Expeditions.LinkOrderAsync(personID, orderNumber, lastName, role);
        }

        public async Task<Models.IFaithVenturesSearchResponse<Models.Policy>> GetFaithVenturesPolicyAsync(string policyID) {
            return await _client.Policies.GetPolicyAsync(policyID);
        }

        public async Task<Models.IFaithVenturesSearchResponse<Models.Policy>> GetFaithVenturesPoliciesAsync(List<string> policyIDs) {
            return await _client.Policies.GetPoliciesAsync(policyIDs);
        }
    }
}
