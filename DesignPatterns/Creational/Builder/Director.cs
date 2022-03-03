using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class Director
    {
        private Builder builder;
        public Builder Builder { get => builder; set => builder = value; }

        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public void constructJunkCar()
        {
            builder.SetSeats(2);
            builder.SetWheels(4);
            builder.SetEngine("basic");
        }

    }
}
