using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FabricMethod
{
    public abstract class Producto
    {
        protected string nombre;
        protected float precio;

        protected Producto(string nombre, float precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public virtual void Funcion()
        {
            
        }
    }
}
