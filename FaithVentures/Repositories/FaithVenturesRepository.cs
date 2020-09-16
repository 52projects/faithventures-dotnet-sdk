using FiftytwoProjects.Core;
using FiftytwoProjects.Core.Util;
using System.Threading.Tasks;

namespace FaithVentures.Repositories {
    public class FaithVenturesRepository : BaseRepository<FaithVentures.DBContext>, IFaithVenturesRepository, IBaseRepository {
        public async Task<Models.IFaithVenturesSearchResponse<Models.Expedition>> GetFaithVenturesExpeditionAsync(string expeditionID) {
            var faithVenturesClient = GetClient();
            return await faithVenturesClient.Expeditions.GetExpeditionAsync(expeditionID);
        }

        public async Task<Models.IFaithVenturesSearchResponse<Models.Expedition>> GetFaithVenturesExpeditionsAsync(string personID) {
            var faithVenturesClient = GetClient();
            return await faithVenturesClient.Expeditions.GetExpeditionsAsync(personID);
        }

        public async Task<Models.IFaithVenturesSearchResponse<Models.Policy>> GetFaithVenturesPolicyAsync(string policyID) {
            var faithVenturesClient = GetClient();
            return await faithVenturesClient.Policies.GetPolicyAsync(policyID);
        }

        private FaithVenturesClient GetClient() {
            return new FaithVenturesClient(new FaithVenturesOptions {
                ApiUrl = ConfigUtil.GetAppSetting("FaithVentures.ApiUrl"),
                ApiTokenPrivateKey = ConfigUtil.GetAppSetting("FaithVentures.ApiTokenPrivateKey"),
                ApiTokenPublicKey = ConfigUtil.GetAppSetting("FaithVentures.ApiTokenPublicKey"),
                ApiAuthUsername = ConfigUtil.GetAppSetting("FaithVentures.ApiAuthUsername"),
                ApiAuthPassword = ConfigUtil.GetAppSetting("FaithVentures.ApiAuthPassword")
            });
        }
    }
}