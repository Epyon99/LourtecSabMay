using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VentaBoletos.Models
{
    public class VentaBoletosContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public VentaBoletosContext() : base("name=VentaBoletosContext")
        {
        }
        public DbSet<Viaje> Viajes { get; set; }
        public System.Data.Entity.DbSet<VentaBoletos.Models.Destino> Destinoes { get; set; }

        public System.Data.Entity.DbSet<VentaBoletos.Models.Rol> Rols { get; set; }

        public System.Data.Entity.DbSet<VentaBoletos.Models.Trayecto> Trayectoes { get; set; }
    }
}
