using System.Data.Entity.ModelConfiguration;

namespace FaithVentures.Entity {
    public class PersonPolicyMap : EntityTypeConfiguration<PersonPolicy> {
        public PersonPolicyMap() {
            this.HasKey(t => new { t.TenantID, t.PersonID, t.PolicyID});
            this.ToTable("PersonPolicy", "Mission");
        }
    }
}
