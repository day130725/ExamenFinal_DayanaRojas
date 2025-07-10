using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Clase_DR;

namespace ExamenFinal_DayanaRojas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 Ventas = new Class1();
            Ventas.GenerarArticulos();
            Ventas.GenerarVentasSemana();
            Ventas.MostrarRegistro();

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}
