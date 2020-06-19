using cw7.DTO;
using cw7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw7.Services
{
    public class ServiceNewOrder : IServiceNewOrder
    {
        CukierniaContext context;
        public ServiceNewOrder(CukierniaContext context)
        {
            this.context = context;
        }


        public Zamowienie PostOrder(int IdKlient, NewOrderDTO NewOrder)
        {
            Klient klient = context.Find<Klient>(IdKlient);
            if (klient == null) return null;

            Zamowienie zamowienie = new Zamowienie
            {
                DataPrzyjecia = NewOrder.dataPrzyjecia,
                Klient = klient,
                Uwagi = NewOrder.uwagi
            };
            context.Zamowienies.Add(zamowienie);

            foreach(NewOrderDTO.NewOrderWyrob Wyrob in NewOrder.wyroby)
            {
                WyrobCukierniczy WyrobCukierniczy;
                try
                {
                    WyrobCukierniczy = context.WyrobCukierniczies
                         .Where<WyrobCukierniczy>(item => item.Nazwa.Equals(Wyrob.wyrob))
                         .First();
                } catch (InvalidOperationException e) { return null;};
               // if (WyrobCukierniczy == null) return null;
                context.Zamowienie_WyrobCukierniczies.Add(new Zamowienie_WyrobCukierniczy
                {
                    WyrobCukierniczy = WyrobCukierniczy,
                    Zamowienie = zamowienie,
                    Ilosc = Wyrob.ilosc,
                    Uwagi = Wyrob.uwagi
                });
            }
            context.SaveChanges();
            return zamowienie;
        }
    }
}
