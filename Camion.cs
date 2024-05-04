using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVehiculos
{
    public class Camion : IMotorizado
    {
        public void Arrancar()
        {
            Console.WriteLine("El camión ha arrancado.");
        }

        public void Detener()
        {
            Console.WriteLine("El camión se ha detenido.");
        }

        public void Acelerar()
        {
            Console.WriteLine("El camión está acelerando.");
        }

        public void Frenar()
        {
            Console.WriteLine("El camión está frenando.");
        }
    }
}
