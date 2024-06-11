
using Microsoft.EntityFrameworkCore;
using AzureDotNetMVCapp.Models;
using System.Security.Cryptography.X509Certificates;
namespace AzureDotNetMVCapp.Data{
    public class azureappdbcontext : DbContext
    {
        public DbSet<Sunscreen> Sunscreens { get; set; }
        public azureappdbcontext(DbContextOptions<azureappdbcontext> options) : base(options){}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            // Seed initial data
            modelBuilder.Entity<Sunscreen>().HasData(
                new Sunscreen { SunscreenId = 1, SunscreenName = "Minimalist", PARating = "PA ++++", SPF = "50", OxyBenzenoneFree = "NO" },
                new Sunscreen { SunscreenId = 2, SunscreenName = "Derama Co", PARating = "PA ++++", SPF = "60", OxyBenzenoneFree = "YES" }
                );
        }

    }
}
