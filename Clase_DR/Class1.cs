using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clase_DR
{
    public class Class1
    {
        string[] dic_articulos = new string[]
        {
            "Detergente", "Pan", "Arroz", "Fideos", "Salchichas",
            "Carne", "Pollo", "Pescado", "Verduras", "Frutas",
            "Lapiz", "Cuaderno", "Libro", "Borrador", "Tijeras",
            "Juguete", "Ropa", "Zapatos", "Perfume", "Jabon",
            "Champu", "Acondicionador", "Colinos", "Desodorante", "Maquillaje",
            "Pegamento", "Floder", "Calculadora", "Regla", "Marcador",
            "Cinta adhesiva", "Grapadora", "Tijeras", "Papel higienico", "Toallas de papel",
            "Escuadra", "Transportador", "Pincel", "Paletas", "Lienzo",
            "Cartuchera", "Agenda", "Calendario", "Organizador", "Bolsa de Tela",
            "Caja de herramientas", "Taladro", "Destornillador", "Martillo", "Sierra",
            "Batidora", "Tostadora", "Microondas", "Horno", "Refrigerador",
            "Tomatodo", "Termo", "Bidon", "Exprimidor", "Licuadora",
            "Cuchillo de cocina", "Tabla de cortar", "Colador", "Rallador", "Abrelatas",
            "Cuchara de palo", "Mortero", "Pimentero", "Salero", "Azucarera",
            "Candelabro", "Portavelas", "Vela aromática", "Incienso", "Ambientador",
            "Maceta", "Planta", "Flor", "Jarrón", "Adorno",
            "Cuadro", "Espejo", "Reloj de pared", "Lámpara", "Cortina",
            "Biblia", "Libro de cocina", "Diccionario", "Enciclopedia", "Novela",
        };
        string[] articulos;
        int[,] Ventas;
        int[,] TotalArticulo;
        int[,] VentaMinima;
        int[,] VentaMaxima;
        double[] Promedio;
        int[] SumaPorDia;
        Random r = new Random();

        public void GenerarArticulos()
        {
            Console.Write("Ingrese la cantidad de artículos: ");
            int cantidad = int.Parse(Console.ReadLine());
            articulos = new string[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                int numero = r.Next(dic_articulos.Length);
                articulos[i] = dic_articulos[numero];
                Thread.Sleep(20);
            }
        }
        public void GenerarVentasSemana()
        {
            Ventas = new int[articulos.Length, 7];
            TotalArticulo = new int[articulos.Length];
            VentaMinima = new int[articulos.Length];
            VentaMaxima = new int[articulos.Length];
            Promedio = new double[articulos.Length];
            SumaPorDia = new int[7];

            for (int i = 0; i < articulos.Length; i++)
            {
                VentaMinima[i] = int.MaxValue;
                VentaMaxima[i] = int.MinValue;
                int suma = 0;

                for (int j = 0; j < 7; j++)
                {
                    int cantidadVendida = r.Next(0, 21); // aleatorio entre 0 y 20
                    Ventas[i, j] = cantidadVendida;
                    suma += cantidadVendida;
                    SumaPorDia[j] += cantidadVendida;

                    if (cantidadVendida < VentaMinima[i])
                        VentaMinima[i] = cantidadVendida;
                    if (cantidadVendida > VentaMaxima[i])
                        VentaMaxima[i] = cantidadVendida;
                }

                TotalArticulo[i] = suma;
                Promedio[i] = Math.Round(suma / 7.0, 1);
            }
        }

        public void MostrarRegistro()
        {
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Articulo\t");
            for (int d = 0; d < dias.Length; d++)
            {
                Console.Write(dias[d] + "\t");
            }
            Console.Write("Total\tMin\tMax\tPromedio");
            Console.ResetColor();
            Console.WriteLine();

            for (int i = 0; i < dias.Length; i++)
            {
                Console.WriteLine(articulos[i] + "\t\t");
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(Ventas[i, j] + "\t");
                }
                Console.Write(TotalArticulo[i] + "\t");
                Console.Write(VentaMinima[i] + "\t");
                Console.Write(VentaMaxima[i] + "\t");
                Console.Write(Promedio[i] + "\t");
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Total por día\t");
            for (int j = 0; j < 7; j++)
            {
                Console.Write(SumaPorDia[j] + "\t");
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}

