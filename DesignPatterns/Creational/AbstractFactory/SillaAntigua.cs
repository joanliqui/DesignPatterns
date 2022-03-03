using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class SillaAntigua : ISilla
    {
        public void Sentarse()
        {
            Console.WriteLine("Te has sentado en la silla antigua");
        }
    }
}