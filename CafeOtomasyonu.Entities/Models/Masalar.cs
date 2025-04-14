using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Models
{
    [Table("Masalar")]
    public class Masalar
    {
        public int Id { get; set; }
        public string MasaAdi { get; set; }
        public string Aciklama { get; set; } // masa açıklaması

        public bool Durum { get; set; } // true = dolu, false = boş

        public bool RezerveMi { get; set; } // true = rezerve, false = rezerve değil
        public DateTime EklenmeTarihi { get; set; } // rezervasyon tarihi
        public DateTime SonIslemTarihi { get; set; } // son işlem tarihi


    }
}
