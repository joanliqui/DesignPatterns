using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public abstract class Builder
    {
        public abstract void Reset();
        public abstract Builder SetSeats(int numeroAsientos);
        public abstract Builder SetEngine(string tipoMotor);
        public abstract Builder SetWheels(int numeroRuedas);

    }
}
