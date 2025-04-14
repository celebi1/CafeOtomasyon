using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Models
{
    [Table("Satislar")]
    public class Satislar
    {
        public int Id { get; set; }
        public string SatisKodu { get; set; } // satış kodu
        public decimal Tutar {  get; set; }
        public decimal Odenen { get; set; } // ödenen tutar
        public decimal Kalan { get; set; } // kalan tutar
        public string Aciklama { get; set; } // açıklama
        public DateTime SonIslemTarihi { get; set; } // eklenme tarihi
    }
}
