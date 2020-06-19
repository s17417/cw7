using cw7.DTO;
using cw7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw7.Services
{
    public interface IServiceNewOrder
    {
        public Zamowienie PostOrder(int IdKlient, NewOrderDTO newOrder);

    }
}
