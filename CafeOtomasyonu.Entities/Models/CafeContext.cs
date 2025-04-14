using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Models
{
    public class CafeContext : DbContext
    {
        public CafeContext() : base("connection")
        {
            Database.SetInitializer<CafeContext>(null);
        }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Urun> Uruns { get; set; }
    }
}

