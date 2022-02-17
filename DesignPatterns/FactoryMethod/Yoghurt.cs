using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FabricMethod
{
    public class Yoghurt : Product
    {
        public Yoghurt(string nombre, float precio) : base(nombre, precio)
        {
        }
    }
}
