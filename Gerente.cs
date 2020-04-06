using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_MatiasLeguer
{
    public class Gerente : Empleados
    {
        
        List<Gerente> listaGerentes = new List<Gerente>();


        public Gerente(string nombre, string apellido, string rut, string nacimiento, string nacionalidad, int sueldo) : base(nombre, apellido, rut, nacimiento, nacionalidad, sueldo)
        {
        }

        public Gerente() : base()
        {
        }


        public override bool NuevaPersona(string name, string apellido, string rut, string nacimiento, string nacionalidad, int sueldo) 
        {
            
            Gerente manager = new Gerente(name, apellido, rut, nacimiento, nacionalidad, sueldo);
            if(listaGerentes.Count == 0)
            {
                listaGerentes.Add(manager);
                return true;
            }
            foreach (Gerente g in listaGerentes)
            {
                if (Equals(g, manager))
                {
                    Console.WriteLine("Este gerente ya fue ingresado");
                    return false;
                }
            }
            listaGerentes.Add(manager);
            Console.WriteLine("El gerente fue ingresado al sistema");
            return true;

        }

        public override string ListaGerentes()
        {
            string info = base.ListaGerentes();
            for (int i = 0; i < listaGerentes.Count; i++)
            {
                info += listaGerentes[i].InformacionGerente();
            }
            info += "--------------------------------------------------\n";
            return info;
        }

        private string InformacionGerente()                //Te entrega la informacion de un gerente
        {
            string informacion = "Nombre: " + nombre + "   Apellido: " + apellido + "   RUT: " + rut + "   Fecha de nacimiento: " + nacimiento + "   Nacionalidad: " + nacionalidad + "\n";
            return informacion;
        }

        public override string ListaNombres()
        {
            string nombresG = base.ListaNombres();

            foreach(Gerente gerente in listaGerentes)
            {
                nombresG += gerente.GetName() + "  ";
            }

            return nombresG;
        }


        public override List<string> CambiarPuestoTrabajo(string nombreCT)
        {
            List<string> infoCT = new List<string>();

            for(int i = 0; i < listaGerentes.Count; i++)
            {
                if (Equals(listaGerentes[i].GetName(), nombreCT))
                {
                    infoCT.Add(nombreCT);
                    infoCT.Add(listaGerentes[i].GetAp());
                    infoCT.Add(listaGerentes[i].GetRut());
                    infoCT.Add(listaGerentes[i].GetFNac());
                    infoCT.Add(listaGerentes[i].GetNacion());
                    listaGerentes.RemoveAt(i);
                    break;
                }
            }
            return infoCT;
        }



    }
}
