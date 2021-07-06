using FaithVentures.Models;
using System;

namespace FaithVentures.Entity {
    [Serializable]
    public class PersonPolicy {
        public int TenantID { get; set; }
        public int PersonID { get; set; }
        public int PolicyID { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int MissionId { get; set; }
        public bool IsBasic { get; set; }
        public bool IsActive { get; set; }

        public void UpdateFromPolicy(Policy policy) {
            StartDateTime = policy.DateEffectiveStart.ToDateTime().Value;
            EndDateTime = policy.DateEffectiveEnd.ToDateTime().Value;
            IsBasic = policy.IsBasic();
        }
    }
}