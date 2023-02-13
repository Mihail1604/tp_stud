using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Praktica
{
 public class ApplicationContext : DbContext
 {

 
 public DbSet<Car>? Cars { get; set; }
 public DbSet<Sotrudnik>? Sotrudniks { get; set; }
 public DbSet<Tech>? Techs { get; set; }
 public DbSet<Client>? Clients { get; set; }
 public DbSet<Procat>? Procats { get; set; }
 public DbSet<Uslug>? Uslugs { get; set; }

 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
 {
 var builder = new ConfigurationBuilder();
 builder.SetBasePath(Directory.GetCurrentDirectory());
 builder.AddJsonFile("json1.json");
 var config = builder.Build();
 string connectionString = config.GetConnectionString("DefaultConnection");

 optionsBuilder.UseSqlServer(connectionString);
 }
 }
}
