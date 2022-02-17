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
            FactoryMethod();

            Console.ReadKey();
        }

        private static void FactoryMethod()
        {
            Factory factory = new Factory();
            Producto primerProducto = factory.CreateProduct(1);
            Producto segundoProducto = factory.CreateProduct(2);
        }
    }
}
