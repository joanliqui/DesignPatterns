using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class Car
    {
        private int asientos;
        private int ruedas;
        private string motor;

        public int Asientos { get => asientos; set => asientos = value; }
        public int Ruedas { get => ruedas; set => ruedas = value; }
        public string Motor { get => motor; set => motor = value; }
    }
}
