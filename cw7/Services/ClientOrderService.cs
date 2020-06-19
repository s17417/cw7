using cw7.DTO;
using cw7.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace cw7.Services
{
    public class ClientOrderService : IClientOrderService
    {
        readonly CukierniaContext  context;
        public ClientOrderService(CukierniaContext context)
        {
            this.context = context;
        }

        public IEnumerable<ZamowienieDTO> GetClientOrders(string nazwisko)
        {


            var zamowienia = (from zam in context.Zamowienies
                              join klient in context.Klients on zam.IdKlient equals klient.IdKlient
                              where klient.Nazwisko == nazwisko
                              select new ZamowienieDTO
                              {
                                  DataPrzyjecia = zam.DataPrzyjecia,
                                  DataRealizacji = zam.DataRealizacji,
                                  IdKlient = zam.IdKlient,
                                  IdZamowienie = zam.IdZamowienia,
                                  Uwagi = zam.Uwagi,
                                  WyrobCukierniczy = (from zam_wyr in context.Zamowienie_WyrobCukierniczies
                                                      join wyr in context.WyrobCukierniczies
                                                      on zam_wyr.IdWyrobuCukierniczego equals wyr.IdWyrobuCukierniczego
                                                      where zam_wyr.IdZamowienia == zam.IdZamowienia
                                                      select new WyrobDTO
                                                      {
                                                          Ilosc = zam_wyr.Ilosc,
                                                          Nazwa = wyr.Nazwa,
                                                          CenaZaSzt = wyr.CenaZaSzt,
                                                          Typ=wyr.Typ
                                                          
                                                      }).ToList()
                              }).ToList();
            return zamowienia;
        }

        public IEnumerable<ZamowienieDTO> GetOrders()
        {
            var zamowienia = (from zam in context.Zamowienies
                              join klient in context.Klients on zam.IdKlient equals klient.IdKlient
                              select new ZamowienieDTO
                              {
                                  DataPrzyjecia = zam.DataPrzyjecia,
                                  DataRealizacji = zam.DataRealizacji,
                                  IdKlient = zam.IdKlient,
                                  IdZamowienie = zam.IdZamowienia,
                                  Uwagi = zam.Uwagi,
                                  WyrobCukierniczy = (from zam_wyr in context.Zamowienie_WyrobCukierniczies
                                                      join wyr in context.WyrobCukierniczies
                                                      on zam_wyr.IdWyrobuCukierniczego equals wyr.IdWyrobuCukierniczego
                                                      where zam_wyr.IdZamowienia == zam.IdZamowienia
                                                      select new WyrobDTO
                                                      {
                                                          Ilosc = zam_wyr.Ilosc,
                                                          Nazwa = wyr.Nazwa,
                                                          CenaZaSzt = wyr.CenaZaSzt,
                                                          Typ = wyr.Typ
                                                         
                                                      }).ToList()
                              }).ToList();

            return zamowienia;
        }
    }
}
