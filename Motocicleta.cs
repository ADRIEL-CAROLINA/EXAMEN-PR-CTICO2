using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVehiculos
{
    public class Motocicleta : IMotorizado
    {
        public void Arrancar()
        {
            Console.WriteLine("La motocicleta ha arrancado.");
        }

        public void Detener()
        {
            Console.WriteLine("La motocicleta se ha detenido.");
        }

        public void Acelerar()
        {
            Console.WriteLine("La motocicleta está acelerando.");
        }

        public void Frenar()
        {
            Console.WriteLine("La motocicleta está frenando.");
        }
    }
}
