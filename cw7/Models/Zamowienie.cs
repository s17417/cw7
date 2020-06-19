using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace cw7.Models
{
    public class Zamowienie
    {
        [Key]
        public int IdZamowienia { get; set; }

        [Required]
        public DateTime DataPrzyjecia { get; set; }

        public DateTime DataRealizacji { get; set; }

        [MaxLength(300)]
        public string Uwagi { get; set; }

        [ForeignKey("Klient")]
        public int IdKlient { get; set; }

        public Klient Klient { get; set; }

     
        [ForeignKey("Pracownik")]
        public int? IdPracownik { get; set; }
        public virtual Pracownik Pracownik { get; set; }

        public List<Zamowienie_WyrobCukierniczy> Zamowienie_WyrobyCukiernicze { get; set; }
    }
}
