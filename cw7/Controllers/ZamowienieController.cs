using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw7.DTO;
using cw7.Models;
using cw7.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace cw7.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class ZamowienieController : ControllerBase
    {
        CukierniaContext context;

        public ZamowienieController(CukierniaContext context)
        {
            this.context = context;
        }
        [HttpGet("{nazwisko}")]
        public IActionResult getOrdersNazwisko(string nazwisko)
        {
            var zamowienia = context.GetService<IClientOrderService>().GetClientOrders(nazwisko);
            if (zamowienia.Count() == 0)
                return NotFound("Lista jest pusta brak zamowien lub brak takiego klienta");
            else
                return Ok(context.GetService<IClientOrderService>().GetClientOrders(nazwisko));
        }

        [HttpGet]
        public IActionResult getOrders()
        {
            var zamowienia = context.GetService<IClientOrderService>().GetOrders();
            if (zamowienia.Count() == 0)
                return NotFound("Lista jest pusta brak zamowien lub brak takiego klienta");
            else
                return Ok(context.GetService<IClientOrderService>().GetOrders());
        }

        [HttpPost("{IdKlient}/orders")]
        public IActionResult postZamowienie(int IdKlient, NewOrderDTO newOrder)
        {
            Zamowienie zamowienie = context.GetService<IServiceNewOrder>().PostOrder(IdKlient, newOrder);
            if (zamowienie == null) return this.NotFound("Brak elemntow w bazie");

            return this.CreatedAtAction("getOrdersNazwisko", new { nazwisko=zamowienie.Klient.Nazwisko}, context.GetService<IClientOrderService>().GetClientOrders(zamowienie.Klient.Nazwisko).Where(item => item.IdZamowienie==zamowienie.IdZamowienia));
        }
    }
}