using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    interface TransportBuilder
    {

        public void CreateType();
        public  void CreateDriver();
        public  void CreateMaxPeople();
        public void CreateTicketPrice(int price);
        public void CalculatePrice();
        public void CreatePeople(List<Passenger> pas);
    }

    class BussBuilder : TransportBuilder
    {
        Venich res = new Venich();

        internal Venich Venich
        {
            get => default;
            set
            {
            }
        }
         
        public void CreateType()
        {
            res.type = Venich.Type.Bus;
        }
        public  void CreateDriver()
        {
            Driver dr = new Driver("Category_A");
            res.Driver = dr;
        }
        public  void CreateMaxPeople()
        {
            res.Capacity = 30;
        }

        public void CreatePeople(List<Passenger> pas)
        {
            res.Passengers = pas;
        }
        public void CreateTicketPrice(int price)
        {
            res.TicketPrice = price;
        }
        public void CalculatePrice()
        {
            res.AllPrice = 0;
            for (int i = 0; i < res.Passengers.Count; i++)
            {
                if (res.Passengers[i].type == Passenger.Type.Childe)
                {
                    res.AllPrice += res.TicketPrice / 2;
                }
                if (res.Passengers[i].type == Passenger.Type.Middle)
                {
                    res.AllPrice += res.TicketPrice;
                }
            }
        }
        public Venich GetVenich()
        {
            return res;
        }
    }

    class TaxiBuilder : TransportBuilder
    {
        Venich res = new Venich();

        internal Venich Venich
        {
            get => default;
            set
            {
            }
        }

        public void CreateType()
        {
            res.type = Venich.Type.Taxi;
        }
        public  void CreateDriver()
        {
            Driver dr = new Driver("Category_A");
            res.Driver = dr;
        }
        public  void CreateMaxPeople()
        {
            res.Capacity = 4;
        }
        public void CreatePeople(List<Passenger> pas)
        {
            res.Passengers = pas;
        }
        public void CreateTicketPrice(int price)
        {
            res.TicketPrice = price;
        }
        public void CalculatePrice()
        {
            res.AllPrice = 0;
            for (int i = 0; i < res.Passengers.Count; i++)
            {
                res.AllPrice += res.TicketPrice;
            }
        }
        public void AddChair()
        {
            res.ChildeChair = true;
        }

        public Venich GetVenich()
        {
            return res;
        }
    }
}
