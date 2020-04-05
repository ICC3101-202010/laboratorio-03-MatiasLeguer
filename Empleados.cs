using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_MatiasLeguer
{
    public class Empleados : Persona
    {
        protected int sueldo;

        public Empleados(string nombre, string apellido, string rut, string nacimiento, string nacionalidad, int sueldo) : base(nombre, apellido, rut, nacimiento, nacionalidad)
        {
            this.sueldo = sueldo;
        }

        public Empleados() : base()
        {
        }



        public override bool NuevaPersona(string name, string apellido, string rut, string nacimiento, string nacionalidad)
        {
            throw new NotImplementedException();
        }
        
        public virtual bool NuevaPersona(string name, string apellido, string rut, string nacimiento, string nacionalidad, int sueldo)
        {
            return true;
        }

        public virtual string ListaGerentes()
        {
            return "LISTA DE GERENTES: \n--------------------------------------------------\n";
        }
        public virtual string ListaCajeros()
        {
            return "LISTA DE CAJEROS: \n--------------------------------------------------\n";
        }
        public virtual string ListaReps()
        {
            return "LISTA DE REPONEDORES: \n--------------------------------------------------\n";
        }
        public override string ListaClientes()
        {
            throw new NotImplementedException();
        }
        








    }
}
