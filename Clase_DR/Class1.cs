using System;
using System.Collections.Generic;
using System.Linq;
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
        string[] Articulos;
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
            Articulos = new string[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                int numero = r.Next(dic_articulos.Length);
                Articulos[i] = dic_articulos[numero];
                Thread.Sleep(20);
            }
        }
    }
}

