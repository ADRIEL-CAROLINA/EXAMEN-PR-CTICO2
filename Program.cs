using GestionVehiculos;

class Program
{
    static void Main(string[] args)
    {
        // Crear instancias de vehículos
        IMotorizado automovil = new Automovil();
        IMotorizado motocicleta = new Motocicleta();
        IMotorizado camion = new Camion();

        // Operar los vehículos
        OperarVehiculo(automovil);
        OperarVehiculo(motocicleta);
        OperarVehiculo(camion);
    }

    // Método para operar cualquier vehículo
    static void OperarVehiculo(IMotorizado vehiculo)
    {
        vehiculo.Arrancar();
        vehiculo.Acelerar();
        vehiculo.Frenar();
        vehiculo.Detener();
    }
}