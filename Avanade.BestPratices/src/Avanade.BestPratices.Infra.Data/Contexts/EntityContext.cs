using Avanade.BestPratices.Domain.Entities;
using Avanade.BestPratices.Infra.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Avanade.BestPratices.Infra.Data.Contexts
{
    public class EntityContext : DbContext
    {
        private readonly string _userId;

        public EntityContext(DbContextOptions<EntityContext> optionsBuilder) : base(optionsBuilder) { }
        public EntityContext(DbContextOptions<EntityContext> optionsBuilder, string userId) :
            base(optionsBuilder)
        {
            _userId = userId;
        }

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
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EntityContext).Assembly);
        }

        public override int SaveChanges()
        {
            SetEntityBaseData();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            SetEntityBaseData();
            return base.SaveChangesAsync(true, cancellationToken);
        }

        private void SetEntityBaseData()
        {
            var entities = ChangeTracker
                .Entries()
                .Where(x=> x.Entity is EntityBase && 
                           x.State is EntityState.Added or EntityState.Modified);

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((EntityBase)entity.Entity).CreatedAt = DateTime.UtcNow;
                    ((EntityBase)entity.Entity).CreatedBy = _userId;
                }
                else
                {
                    ((EntityBase)entity.Entity).ModifiedAt = DateTime.UtcNow;
                    ((EntityBase)entity.Entity).ModifiedBy = _userId;
                }
            }
        }
    }
}
