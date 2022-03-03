using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class AncientFactory : MueblesFactory
    {
        public override IMesa CreateMesa()
        {
            return new MesaAntigua();
        }

        public override ISilla CreateSilla()
        {
            return new SillaAntigua();
        }

        public override ISofa CreateSofa()
        {
            return new SofaAntiguo();
        }
    }
}
