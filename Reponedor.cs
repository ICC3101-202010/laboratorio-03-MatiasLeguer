using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_MatiasLeguer
{
    public class Reponedor : Empleados
    {
        List<Reponedor> listaRep = new List<Reponedor>();

        public Reponedor(string nombre, string apellido, string rut, string nacimiento, string nacionalidad, int sueldo) : base(nombre, apellido, rut, nacimiento, nacionalidad, sueldo)
        {
        }

        public Reponedor() : base()
        {
        }

        public override int GetCount()
        {
            throw new NotImplementedException();
        }


        public override bool NuevaPersona(string name, string apellido, string rut, string nacimiento, string nacionalidad, int sueldo)
        {

            Reponedor rep = new Reponedor(name, apellido, rut, nacimiento, nacionalidad, sueldo);
            if (listaRep.Count == 0)
            {
                listaRep.Add(rep);
                return true;
            }
            foreach (Reponedor r in listaRep)
            {
                if (Equals(r, rep))
                {
                    Console.WriteLine("Este reponedor ya fue ingresado");
                    return false;
                }
            }
            listaRep.Add(rep);
            Console.WriteLine("El rep fue ingresado al sistema");
            return true;

        }

        public override string ListaReps()
        {
            string info = base.ListaReps();
            for (int i = 0; i < listaRep.Count; i++)
            {
                info += listaRep[i].InformacionRep();
            }
            info += "--------------------------------------------------\n";
            return info;
        }

        private string InformacionRep()                //Te entrega la informacion de un reponedor
        {
            string informacion = "Nombre: " + nombre + "   Apellido: " + apellido + "   RUT: " + rut + "   Fecha de nacimiento: " + nacimiento + "   Nacionalidad: " + nacionalidad + "\n";
            return informacion;
        }

        public override string ListaNombres()
        {
            string nombresR = base.ListaNombres();

            foreach (Reponedor reponedores in listaRep)
            {
                nombresR += reponedores.GetName() + "  ";
            }

            return nombresR;
        }



        public override List<string> CambiarPuestoTrabajo(string nombreCT)
        {

            List<string> infoCT = new List<string>();

            for (int i = 0; i < listaRep.Count; i++)
            {
                if (Equals(listaRep[i].GetName(), nombreCT))
                {
                    infoCT.Add(nombreCT);
                    infoCT.Add(listaRep[i].GetAp());
                    infoCT.Add(listaRep[i].GetRut());
                    infoCT.Add(listaRep[i].GetFNac());
                    infoCT.Add(listaRep[i].GetNacion());
                    listaRep.RemoveAt(i);
                    break;
                }
            }
            return infoCT;
        }







    }
}
