using cw7.DTO;
using cw7.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw7.Services
{
    interface IClientOrderService
    {
        public IEnumerable<ZamowienieDTO> GetClientOrders(string nazwisko);
        public IEnumerable<ZamowienieDTO> GetOrders();
    }
}
