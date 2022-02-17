using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FabricMethod
{
    public class Yogur : Producto
    {
        public Yogur(string nombre, float precio) : base(nombre, precio)
        {
        }

        public override string ToString()
        {
            string s = "YOGHURT - Nombre: " + nombre + " Precio: " + precio;
            return s;
        }
    }
}
