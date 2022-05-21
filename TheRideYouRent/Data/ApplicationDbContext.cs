using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TheRideYouRent.Models;

namespace TheRideYouRent.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TheRideYouRent.Models.Car> Car { get; set; }
        public DbSet<TheRideYouRent.Models.Inspector> Inspector { get; set; }
        public DbSet<TheRideYouRent.Models.Driver> Driver { get; set; }
        public DbSet<TheRideYouRent.Models.Rental> Rental { get; set; }
        public DbSet<TheRideYouRent.Models.Return> Return { get; set; }
    }
}
