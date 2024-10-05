using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculo
{
    public class Vehiculo
    {
        public string Modelo { get; set; }
        public double PrecioPorDia { get; set; }

        public class Descuento
        {
            public static double AplicarDescuento(double precio, double porcentajeDescuento)
            {
                return precio - (precio * porcentajeDescuento / 100);
            }
        }
    }

    public static class CalcularReserva
    {
        public static double TotalReserva(Vehiculo vehiculo, int dias, double porcentajeDescuento)
        {
            double precioFinal = Vehiculo.Descuento.AplicarDescuento(vehiculo.PrecioPorDia, porcentajeDescuento);
            return precioFinal * dias;
        }
    }

    public static class VehiculoExtensions
    {
        public static string MostrarInformacion(this Vehiculo vehiculo)
        {
            return $"Modelo: {vehiculo.Modelo}, Precio por día: {vehiculo.PrecioPorDia:C}";
        }
    }


}
