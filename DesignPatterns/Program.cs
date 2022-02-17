using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Creational.FabricMethod;

namespace DesignPatterns
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            Product primerProducto = factory.CreateProduct(1);
            Product segundoProducto = factory.CreateProduct(2);

            Console.ReadKey();
        }
    }
}
