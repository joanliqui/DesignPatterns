using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Creational.FabricMethod;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.Prototype;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Creational
            //FactoryMethod(); //Este es más bien lo que se conoce como Simple Factory
            //Builder();
            //AbstractFactory();
            //Prototype();
            #endregion

            Console.ReadKey();
        }

        #region Creationals
        private static void FactoryMethod()
        {
            Factory factory = new Factory();
            Producto primerProducto = factory.CreateProduct(1);
            Producto segundoProducto = factory.CreateProduct(2);
        }
        private static void AbstractFactory()
        {
            Cliente cliente;
            MueblesFactory factory;

            factory = new AncientFactory();
            cliente = new Cliente(factory);

            cliente.CrearMesa();
            cliente.CrearSilla();
            cliente.CrearSofa();
        }
        private static void Builder()
        {
            CarBuilder builder = new CarBuilder();
            Director director = new Director(builder);
            director.constructJunkCar();
            Car car = builder.GetCar();
            builder.Reset();

            Console.WriteLine("Motor: " + car.Motor + " | Asientos: " + car.Asientos + " | Ruedas: " + car.Ruedas);
        }
        private static void Prototype()
        {
            Persona p1 = new Persona("Sara", 23, new DateTime(1999, 5, 12));

            Persona p2 = p1.DeepCopy();

            Console.WriteLine("Persona 1: " + p1.ToString());
            Console.WriteLine("Persona 2: " + p2.ToString());
            Console.WriteLine();

            p1.Nombre = "Carlos";
            p1.Edad = 42;
            p1.FechaNacimiento = Convert.ToDateTime("1980-01-01");

            Console.WriteLine("Cambios producidos en persona 1. Vemos como la Persona 2 no cambia ningun dato");
            Console.WriteLine();
            Console.WriteLine("Persona 1: " + p1.ToString());
            Console.WriteLine("Persona 2: " + p2.ToString());
        }
        #endregion


    }

}
