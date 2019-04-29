using System;
using Microsoft;
using SneakersApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace SneakersApp.Data
{
    public class SneakersAppDbContext : IdentityDbContext<User>
    {
       public SneakersAppDbContext(DbContextOptions<SneakersAppDbContext> options) : base(options)
       {
           
       }

       public DbSet<Shoes> Shoes { get; set; }
       public DbSet<Tag> Tags { get; set; }
       public DbSet<Collection> Collections { get; set; }
    }
}
