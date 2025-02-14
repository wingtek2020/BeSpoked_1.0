using API.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;

namespace API.Data
{
    public class DataContext(DbContextOptions options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
                throw new ArgumentNullException("modelBuilder");

            // for the other conventions, we do a metadata model loop
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                // equivalent of modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
                entityType.SetTableName(entityType.DisplayName());

                // equivalent of modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
                entityType.GetForeignKeys()
                    .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade)
                    .ToList()
                    .ForEach(fk => fk.DeleteBehavior = DeleteBehavior.Restrict);
            }

            base.OnModelCreating(modelBuilder);

            //fluent to confirm primary keys in sales

        }
        public required DbSet<AppUser> Users { get; set; }
        public required DbSet<Role> Roles { get; set; }
        public required DbSet<Product> Products { get; set; }
        public required DbSet<UserCommission> UserCommissions { get; set; }
        public required DbSet<Sale> Sales { get; set; }
        public required DbSet<Discount> Discounts { get; set; }
    }

}
