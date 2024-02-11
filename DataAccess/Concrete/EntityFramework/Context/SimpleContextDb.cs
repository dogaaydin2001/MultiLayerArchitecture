using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class SimpleContextDb : DbContext
    {
     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
              {
                  optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MultiLayerArchitecture;Integrated Security=True;");
              }
        public DbSet<User>? Users { get; set; }
        public DbSet<OperationClaim>? OperationClaims { get; set; }
        public DbSet<UserOperationClaim>? UserOperationClaims { get; set; }
    }
}
