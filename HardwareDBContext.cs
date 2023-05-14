using Hardware_Order_Management.Types;
using System;
using System.Data.Entity;

namespace Hardware_Order_Management
{
    public class HardwareDBContext : DbContext
    {
        public HardwareDBContext() : base("name=HardwareDBConnectionString")
        {
            Database.SetInitializer<HardwareDBContext>(null);
            Database.Log = Console.Write;
        }

        public DbSet<Component> Components { get; set; }
        public DbSet<Compatibility> Compatibilities { get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<ComputerComponent> ComputerComponents { get; set; }

        
    }
}