using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class SofaModerno : ISofa
    {
        public void Tumbar()
        {
            Console.WriteLine("Te has tumbado en el sofa moderno");
        }
    }
}