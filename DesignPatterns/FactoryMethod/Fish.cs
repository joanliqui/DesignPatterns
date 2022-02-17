using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FabricMethod
{
    public class Fish : Product
    {
        public Fish(string nombre, float precio) : base(nombre, precio)
        {
            
        }

        public override string ToString()
        {
            string s = "PESCADO - Nombre: " + nombre + " Precio: " + precio;
            return s;
        }
    }
}
