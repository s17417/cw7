using cw7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw7.DTO
{
    public class ZamowienieDTO
    {
        public int IdZamowienie { get; set; }

        public int IdKlient { get; set; }
        public DateTime DataRealizacji { get; set; }

        public DateTime DataPrzyjecia { get; set; }
        public string Uwagi { get; set; }
        public List<WyrobDTO> WyrobCukierniczy { get; set; }
    }
}
