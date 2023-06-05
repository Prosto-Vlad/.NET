using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class ReadyState : ITransportState
    {
        public void ReadyToDepart(TransportVehicle vehicle)
        {
            Console.WriteLine("Машина вже готова до відправлення.");
        }
    }
}
