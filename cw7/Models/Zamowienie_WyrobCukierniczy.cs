using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace cw7.Models
{
    public class Zamowienie_WyrobCukierniczy
    {

      /*  public Zamowienie_WyrobCukierniczy( int IdWyrobuCukierniczego, int IdZamowienia)
        {
            this.IdWyrobuCukierniczego = IdWyrobuCukierniczego;
            this.IdZamowienia = IdZamowienia;
        }*/

        [ForeignKey("WyrobCukierniczy")]
        public int IdWyrobuCukierniczego { get; set; }

        public WyrobCukierniczy WyrobCukierniczy { get; set; }

        [ForeignKey("Zamowienie")]
        public int IdZamowienia { get; set; }

        public Zamowienie Zamowienie { get; set; }

        [Required]
        public int Ilosc { get; set; }

        [MaxLength(300)]
        public string Uwagi { get; set; }

    }
}
