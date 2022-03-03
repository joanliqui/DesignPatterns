using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public class Persona
    {
        private string nombre; //Los strings son de tipo referencia
        private DateTime fechaNacimiento; //Es un struct lo que significa que es de tipo valor
        private int edad; //Int es tipo valor

        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }

        public Persona(string nombre, int edad, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.fechaNacimiento = fechaNacimiento;
        }

        public Persona ShallowCopy()
        {
            return (Persona) this.MemberwiseClone();
        }

        public Persona DeepCopy()
        {
            Persona clon = (Persona)this.MemberwiseClone();
            clon.nombre = String.Copy(nombre);
            return clon;

        }

        public override string ToString()
        {
            return "Nombre:" + nombre + ", Edad: " + edad + ", Nacimiento: " + fechaNacimiento;
        }
    }
}
