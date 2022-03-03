using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class MesaModerna : IMesa
    {
        public void ComidaEncima()
        {
            Console.WriteLine("Has puesto la comida sobre la mesa moderna");
        }
    }
}