using Avanade.BestPratices.Domain.Entities;
using Avanade.BestPratices.Infra.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Avanade.BestPratices.Infra.Data.Contexts
{
    public class EntityContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Charge> Charges { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentParameter> DocumentParameters { get; set; }
        public DbSet<Manufacture> Manufactures { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<ModelVersion> ModelsVersion { get; set; }
        public DbSet<Ride> Rides { get; set; } 
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(new AccountConfiguration().Configure);
        }
    }
}
