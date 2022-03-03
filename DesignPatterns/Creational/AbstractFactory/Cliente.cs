using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class Cliente
    {
        private MueblesFactory factory;
        private ISilla silla;
        private IMesa mesa;
        private ISofa sofa;

        public Cliente(MueblesFactory factory)
        {
            this.factory = factory;
        }

        public void CrearSilla()
        {
            factory.CreateSilla();
            Console.WriteLine("Silla creada");
        }

        public void CrearMesa()
        {
            factory.CreateMesa();
            Console.WriteLine("Mesa creada");
        }

        public void CrearSofa()
        {
            factory.CreateSofa();
            Console.WriteLine("Sofa creado");
        }
    }
}
