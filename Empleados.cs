using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_MatiasLeguer
{
    public abstract class Empleados : Persona
    {
        protected int sueldo;
        protected string horarioTrabajo;
        protected List<string> horarios = new List<string>() {"7:00 - 15:00", "8:00 - 16:00", "9:00 - 17:00","10:00 - 18:00","11:00 - 19:00","12:00 - 20:00","13:00 - 21:00","14:00 - 22:00","14:00 - 23:00"};

        public Empleados(string nombre, string apellido, string rut, string nacimiento, string nacionalidad, int sueldo) : base(nombre, apellido, rut, nacimiento, nacionalidad)
        {
            this.sueldo = sueldo;
            
        }

        public Empleados() : base()
        {
        }

        public string GetName()
        {
            return nombre;
        }
        public string GetAp()
        {
            return apellido;
        }
        public string GetRut()
        {
            return rut;
        }
        public string GetFNac()
        {
            return nacimiento;
        }
        public string GetNacion()
        {
            return nacionalidad;
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

        public virtual string ListaNombres()
        {
            string nombres = "Lista de nombres: \n";
            return nombres;
        }

        public void Cambiarsueldo()
        {
            Console.WriteLine("Coloque el sueldo del empleado. Como referencia, el de Cajero = $333,391 CLP. El del reponedor = $300,000CLP y el del gerente = $1,000,000CLP ");
            sueldo = Int32.Parse(Console.ReadLine());
        }

        public abstract List<string> CambiarPuestoTrabajo(string name, string apellido, string rut, string nacimiento, string nacionalidad, int caseTrabajo);

        public void CambiarHorarioTrabajo()
        {
            Console.WriteLine("Desea Cambiar a una de las horas predeterminadas? Escriba 'escoger'. Desea colocar la hora de trabajo? Escriba 'personal'");
            string respuesta = Console.ReadLine();

            if(respuesta == "escoger")
            {
                string hora = "HORARIOS \n";
                for(int i = 1; i <= horarios.Count; i++)
                {
                    hora +="Numero " + i + ": " + horarios[i] + " // "; 
                }
                Console.WriteLine(hora);
                Console.Write("escoga el horario que desea seleccionando el numero en el que está categorizado: ");
                int indexHorario = Int32.Parse(Console.ReadLine()) - 1 ;
                horarioTrabajo = horarios[indexHorario];
                Console.WriteLine("El horario ha sido cambiado!");
            }
            else if (respuesta == "personal")
            {
                Console.Write("Escriba el horario que desea colocar. (El formato recomendado es el siguiente 00:00 - 00:00): ");
                horarioTrabajo = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No escribió ninguna de las dos opciones");
            }


        }







    }
}
