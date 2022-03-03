using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class SillaModerna : ISilla
    {
        public void Sentarse()
        {
            Console.WriteLine("Te has sentado en la silla moderna");
        }
    }
}