using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal_DayanaRojas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ventas = new VentasArticulos();
            Ventas.GenerarArticulos();
            Ventas.GenerarVentasSemana();
            Ventas.MostrarRegistro();

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}
