using Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Warehouse w = Warehouse.Get_Warehouse();

            Console.WriteLine("Intento agregar una lista de 3 partes al warehouse.");
            w.AddParts(new List<CarPart>() { new Nut(10, 5), new Cog(10, 5), new BallBearing(20, 2) });
            Console.WriteLine("Total de partes en la lista: " + w.GetParts().Count.ToString());

            Console.WriteLine("\n\nCompruebo que el warehose guarde el archivo de manera correcta.");
            w.Save(Environment.CurrentDirectory + "\\Warehouse.xml");
            Console.WriteLine("Resultado: " + File.Exists(Environment.CurrentDirectory + "\\Warehouse.xml").ToString());

            Console.WriteLine("\n\nReduzco el Stock de una de las partes en 3");
            Console.WriteLine("Stock antes de realizar el pedido: " + w.GetParts()[0].Stock.ToString());
            w.ReceiveRequest(new List<CarPart>() { new Nut(10, 3) });
            Console.WriteLine("Stock despues de realizar el pedido: " + w.GetParts()[0].Stock.ToString());

            Console.WriteLine("\n\nCompruebo que el warehose se cargue correctamente desde un archivo.");
            w.GetParts().Clear();
            w.Load(Environment.CurrentDirectory + "\\Warehouse.xml");
            Console.WriteLine("Total de elementos en el warehouse: " + w.GetParts().Count.ToString());

            Console.WriteLine("\n\nComparo dos parte de con las mismas caracteristicas para ver si comparan bien.");
            CarPart a = new Nut(10, 5);
            CarPart b = new Nut(10, 20);
            Console.WriteLine("Resultado de la comparacion: " + (a == b).ToString());

            Console.WriteLine("\n\nComparo dos parte de con diferentes caracteristicas para ver si comparan bien.");
            CarPart c = new Nut(5, 5);
            CarPart d = new Nut(10, 20);
            Console.WriteLine("Resultado de la comparacion: " + (c == d).ToString());





            Console.ReadKey();
        }
    }
}
