using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_MatiasLeguer
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected string rut;
        protected string nacimiento;
        protected string nacionalidad;
        protected double sueldo;

        public Persona(string nombre, string apellido, string rut, string nacimiento, string nacionalidad, double sueldo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.rut = rut;
            this.nacimiento = nacimiento;
            this.nacionalidad = nacionalidad;
            this.sueldo = sueldo;
        }

       /*
        public int MostrarSueldo(object empleado) 
        {





        }
        */











    }
}
