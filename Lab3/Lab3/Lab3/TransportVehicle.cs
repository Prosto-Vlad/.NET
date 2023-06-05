using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class TransportVehicle
    {
        enum Vtype
        {
            Bus,
            Taxi
        }
        private ITransportState state;
        private Vtype type;
        private bool childeChair = false;
        private Driver driver;
        private List<Passenger> passengers;
        
        public TransportVehicle()
        {
            state = new LoadedState(); // Початковий стан - "Завантажено"
            passengers = new List<Passenger>();
        }
        public void SetType(string type)
        {
            this.type = (Vtype)Enum.Parse(typeof(Vtype), type);
        }
        public string GetType()
        {
            return type.ToString();
        }
        public void SetState(ITransportState state)
        {
            this.state = state;
        }
        public void AddChair()
        {
            this.childeChair = true;
        }
        public void SubChair()
        {
            this.childeChair = false;
        }

        public void ReadyToDepart()
        {
            state.ReadyToDepart(this);
        }

        public void SetDriver(Driver driver)
        {
            this.driver = driver;
        }

        public bool GetChilde()
        {
            return childeChair;
        }

        public bool CheckChilde()
        {
            if(childeChair == false && passengers.Any(p => p.type.ToString() == "Childe") && type == Vtype.Taxi)
                return false;
            else
                return true;
        }

        public bool CheckDriver()
        {
            if ((driver.category == Driver.Category.Category_A && type == Vtype.Taxi) || (driver.category == Driver.Category.Category_B && type == Vtype.Bus))
                return false;
            else
                return true;
        }

        public bool CheckCoutPass()
        {
            if ((type == Vtype.Bus && passengers.Count > 30) || (type == Vtype.Taxi && passengers.Count > 4))
                return false;
            else
                return true;
        }

        public bool HasDriver()
        {
            return driver != null;
        }

        public void AddPassenger(Passenger passenger)
        {
            passengers.Add(passenger);
        }

        public bool HasPassengers()
        {
            return passengers.Count > 0;
        }
    }
}
