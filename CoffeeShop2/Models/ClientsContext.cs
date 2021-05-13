using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop2.Models
{
    public class ClientsContext : DbContext
    {
        
            public DbSet<Client> Clients { get; set; }
            
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(
                     @"Server=.\SQLEXPRESS;Database=CoffeeShop2;Integrated Security=SSPI;");
            }
        
    }
}
