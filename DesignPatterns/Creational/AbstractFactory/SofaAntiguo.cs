using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class SofaAntiguo : ISofa
    {
        public void Tumbar()
        {
            Console.WriteLine("Te has tumbado en el sofa antiguo");
        }
    }
}