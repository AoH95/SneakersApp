using System;
using Microsoft.EntityFrameworkCore;

namespace SneakersApp.Data
{
    public class SneakersAppDbContext : DbContext 
    {
       public SneakersAppDbContext(DbContextOptions options) : base(options)
       {
           
       }

       public DbSet<Collection> Collections { get; set; }
    }
}
