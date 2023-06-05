using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class LoadedState: ITransportState
    {
        public void ReadyToDepart(TransportVehicle vehicle)
        {
            if (vehicle.HasDriver() && vehicle.HasPassengers() && vehicle.CheckChilde() && vehicle.CheckCoutPass())
            {
                vehicle.SetState(new ReadyState());
                Console.WriteLine("Машина готова до відправлення.");
            }
            else
            {
                Console.WriteLine("Машина не готова до відправлення. Перевірте наявність водія, пасажирів та дитячого крісла якщо це таксі.");
            }
        }
    }
}
