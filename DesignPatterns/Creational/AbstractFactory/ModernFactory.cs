using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class ModernFactory : MueblesFactory
    {
        public override IMesa CreateMesa()
        {
            return new MesaModerna();
        }

        public override ISilla CreateSilla()
        {
            return new SillaModerna();
        }

        public override ISofa CreateSofa()
        {
            return new SofaModerno();
        }
    }
}
