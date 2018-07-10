using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Garage2._0.DataAccessLayer
{
    public class StorageContext : DbContext
    {
        public StorageContext() : base("DefaultConnectionGarage")
        {
        }

        public DbSet<Models.ParkedVehicle> parkedVehicles { get; set; }
        
    }
}