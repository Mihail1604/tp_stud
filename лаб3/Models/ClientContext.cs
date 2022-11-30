using System.Collections.Generic;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace lab3.Models
{
    public class ClientContext : DbContext
    {
        public ClientContext(DbContextOptions<ClientContext> options) : base(options)
        {
        }
        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<Rent> Rents { get; set; } = null!;
    }
}