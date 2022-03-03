using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public abstract class MueblesFactory
    {
        public abstract ISilla CreateSilla();
        public abstract IMesa CreateMesa();
        public abstract ISofa CreateSofa();
    }
}
