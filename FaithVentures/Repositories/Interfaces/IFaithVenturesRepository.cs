using System.Threading.Tasks;
using FiftytwoProjects.Core;

namespace FaithVentures.Repositories {
    public interface IFaithVenturesRepository : IBaseRepository {
        Task<FaithVentures.Models.IFaithVenturesSearchResponse<FaithVentures.Models.Expedition>> GetFaithVenturesExpeditionAsync(string expeditionID);

        Task<FaithVentures.Models.IFaithVenturesSearchResponse<FaithVentures.Models.Expedition>> GetFaithVenturesExpeditionsAsync(string personID);

        Task<FaithVentures.Models.IFaithVenturesSearchResponse<FaithVentures.Models.Policy>> GetFaithVenturesPolicyAsync(string policyID);
    }
}
