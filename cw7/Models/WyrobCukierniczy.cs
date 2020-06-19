using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace cw7.Models
{
    public class WyrobCukierniczy
    {
        [Key]
        public int IdWyrobuCukierniczego { get; set; }

        [Required]
        [MaxLength(200)]
        public string Nazwa { get; set; }

        [Required]
        public float CenaZaSzt { get; set; }

        [Required]
        [MaxLength(40)]
        public string Typ { get; set; }

        public List<Zamowienie_WyrobCukierniczy> Zamowienie_WyrobyCukiernicze { get; set; }
    }
}
