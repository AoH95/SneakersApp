using System;
using Microsoft;
using SneakersApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace SneakersApp.Data
{
    public class SneakersAppDbContext : DbContext 
    {
       public SneakersAppDbContext(DbContextOptions options) : base(options)
       {
           
       }

       public DbSet<Shoes> Shoes { get; set; }
    }
}
