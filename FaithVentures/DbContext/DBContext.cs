using FaithVentures.Entity;
using FiftytwoProjects.Core.Util;
using System.Data.Entity;

namespace FaithVentures {
    public class DBContext : DbContext {
        // Methods
        static DBContext() {
            Database.SetInitializer<DBContext>(null);
        }

        public DBContext()
            : this(ConfigUtil.GetAppSetting("RootConnectionString")) {
        }

        public DBContext(string connectionString)
            : base(connectionString) {
        }

        protected override void Dispose(bool disposing) {
            this.Database.Connection.Close();
            base.Dispose(disposing);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Configurations.Add<PersonPolicy>(new PersonPolicyMap());
        }

        // Properties
        public DbSet<PersonPolicy> PersonPolicies { get; set; }
    }
}
