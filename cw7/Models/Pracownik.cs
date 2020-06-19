using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cw7.Models
{
    public class Pracownik
    {
        [Key]
        public int IdPracownik { get; set; }

        [Required]
        [MaxLength(50)]
        
        public string Imie { get; set; }

        [Required]
        [MaxLength(60)]
        public string Nazwisko { get; set; }

        public List<Zamowienie> Zamowienia { get; set; }
    }
}
