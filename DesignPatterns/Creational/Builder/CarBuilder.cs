using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class CarBuilder : Builder
    {
        private Car car;

        public CarBuilder()
        {
            this.Reset();
        }

        public override void Reset()
        {
            this.car = new Car();
        }

        public override Builder SetEngine(string tipoMotor)
        {
            car.Motor = tipoMotor;
            return this;
        }

        public override Builder SetSeats(int numeroAsientos)
        {
            car.Asientos = numeroAsientos;
            return this;
        }

        public override Builder SetWheels(int numeroRuedas)
        {
            car.Ruedas = numeroRuedas;
            return this;
        }

        public Car GetCar()
        {
            Car product = this.car;
            return product;
        }
    }
}
