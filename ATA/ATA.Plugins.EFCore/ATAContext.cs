using ATA.CoreBusiness;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATA.Plugins.EFCore
{
    public class ATAContext : DbContext
    {
        public ATAContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Asset> Assets { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Seeding data
            modelBuilder.Entity<Asset>().HasData(
                    new Asset {AssetId=1, AssetName="MacBook", UnitPrice=1000,Quantity=3},
                    new Asset { AssetId = 2, AssetName = "Printer", UnitPrice = 1400, Quantity = 13 },
                    new Asset { AssetId = 3, AssetName = "PC", UnitPrice = 1020, Quantity = 30 },
                    new Asset { AssetId = 4, AssetName = "CPU", UnitPrice = 100, Quantity = 10 }
                );
        }


    }
}
