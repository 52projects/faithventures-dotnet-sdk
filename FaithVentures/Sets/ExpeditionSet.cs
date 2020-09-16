using System.Collections.Generic;
using System.Threading.Tasks;
using FaithVentures.Models;

namespace FaithVentures.Sets {
    public class ExpeditionSet : BaseSet<Expedition> {
        public ExpeditionSet(FaithVenturesOptions options) : base(options) {
        }

        public async Task<IFaithVenturesSearchResponse<Expedition>> GetExpeditionAsync(string expeditionID) {
            var searchObject = new Dictionary<string, string>();
            if (expeditionID != null) {
                searchObject.Add("expeditionId", expeditionID);
            }
            return await base.PostAsync($"/wpcc/api/1.0/search/expeditions", searchObject);
        }

        public async Task<IFaithVenturesSearchResponse<Expedition>> GetExpeditionsAsync(string externalPersonId) {
            var searchObject = new Dictionary<string, string>();
            if (externalPersonId != null) {
                searchObject.Add("externalPersonId", externalPersonId);
            }
            return await base.PostAsync($"/wpcc/api/1.0/search/expeditions", searchObject);
        }
    }
}