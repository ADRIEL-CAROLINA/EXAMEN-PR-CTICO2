using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVehiculos
{
    public interface IVehiculo
    {
        void Arrancar();
        void Detener();
    }

    // Definición de la interfaz IMotorizado que hereda de IVehiculo
    public interface IMotorizado : IVehiculo
    {
        void Acelerar();
        void Frenar();
    }
}
