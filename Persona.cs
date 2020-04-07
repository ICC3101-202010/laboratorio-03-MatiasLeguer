using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_MatiasLeguer
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected string rut;
        protected string nacimiento;
        protected string nacionalidad;
       
        protected Persona(string nombre, string apellido, string rut, string nacimiento, string nacionalidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.rut = rut;
            this.nacimiento = nacimiento;
            this.nacionalidad = nacionalidad;
        }
        public Persona()
        {
        }

        public abstract bool NuevaPersona(string name, string apellido, string rut, string nacimiento, string nacionalidad);
        public abstract string ListaClientes();


    }
}
