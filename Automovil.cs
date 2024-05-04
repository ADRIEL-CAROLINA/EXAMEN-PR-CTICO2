using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVehiculos
{
    public class Automovil : IMotorizado
    {
        public void Arrancar()
        {
            Console.WriteLine("El automóvil ha arrancado.");
        }

        public void Detener()
        {
            Console.WriteLine("El automóvil se ha detenido.");
        }

        public void Acelerar()
        {
            Console.WriteLine("El automóvil está acelerando.");
        }

        public void Frenar()
        {
            Console.WriteLine("El automóvil está frenando.");
        }
    }
}
