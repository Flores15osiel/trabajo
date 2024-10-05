using System;
using vehiculo;

public class Program
{
    public static void Main()
    {
        Vehiculo miVehiculo = new Vehiculo
        {
            Modelo = "Toyota Corolla",
            PrecioPorDia = 50.0 
        };

        double porcentajeDescuento = 10.0; 
        double precioConDescuento = Vehiculo.Descuento.AplicarDescuento(miVehiculo.PrecioPorDia, porcentajeDescuento);

        Console.WriteLine(miVehiculo.MostrarInformacion());

        int diasReserva = 5;
        double costoTotal = CalcularReserva.TotalReserva(miVehiculo, diasReserva, porcentajeDescuento);

        Console.WriteLine($"Costo total de la reserva por {diasReserva} días: {costoTotal:C}");
    }
}
