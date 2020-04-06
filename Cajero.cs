using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_MatiasLeguer
{
    public class Cajero : Empleados
    {
        List<Cajero> listaCajeros = new List<Cajero>();

        public Cajero(string nombre, string apellido, string rut, string nacimiento, string nacionalidad, int sueldo) : base(nombre, apellido, rut, nacimiento, nacionalidad, sueldo)
        {
        }

        public Cajero() : base()
        {
        }

        public override bool NuevaPersona(string name, string apellido, string rut, string nacimiento, string nacionalidad, int sueldo)
        {

            Cajero caja = new Cajero(name, apellido, rut, nacimiento, nacionalidad, sueldo);
            if (listaCajeros.Count == 0)
            {
                listaCajeros.Add(caja);
                return true;
            }
            foreach (Cajero c in listaCajeros)
            {
                if (Equals(c, caja))
                {
                    Console.WriteLine("Este cajero ya fue ingresado");
                    return false;
                }
            }
            listaCajeros.Add(caja);
            Console.WriteLine("El cajero fue ingresado al sistema");
            return true;

        }

        public override string ListaCajeros()
        {
            string info = base.ListaCajeros();
            for (int i = 0; i < listaCajeros.Count; i++)
            {
                info += listaCajeros[i].InformacionCajero();
            }
            info += "--------------------------------------------------\n";
            return info;
        }

        private string InformacionCajero()                //Te entrega la informacion de un cajero
        {
            string informacion = "Nombre: " + nombre + "   Apellido: " + apellido + "   RUT: " + rut + "   Fecha de nacimiento: " + nacimiento + "   Nacionalidad: " + nacionalidad + "\n";
            return informacion;
        }


        public override string ListaNombres()
        {
            string nombresC = base.ListaNombres();

            foreach (Cajero cajeros in listaCajeros)
            {
                nombresC += cajeros.GetName() + "  ";
            }

            return nombresC;
        }

        public override List<string> CambiarPuestoTrabajo(string name, string apellido, string rut, string nacimiento, string nacionalidad, int caseTrabajo)
        {
            throw new NotImplementedException();
        }







    }
}
