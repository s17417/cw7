using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw7.DTO
{
    public class NewOrderDTO
    {
        public DateTime dataPrzyjecia { get; set; }

        public string uwagi { get; set; }

        public List<NewOrderWyrob> wyroby{ get; set; }


        public class NewOrderWyrob
    {
        public int ilosc { get; set; }

        public string wyrob { get; set; }

        public string uwagi { get; set; }

    }
    }
}
