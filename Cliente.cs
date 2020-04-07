using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_MatiasLeguer
{
    public class Cliente : Persona
    {
        List<Cliente> listaClientes = new List<Cliente>();

        public Cliente(string nombre, string apellido, string rut, string nacimiento, string nacionalidad) : base(nombre, apellido, rut, nacimiento, nacionalidad)
        {
        }
        public Cliente() : base()
        {
        }

        public override bool NuevaPersona(string name, string apellido, string rut, string nacimiento, string nacionalidad)
        {
            Cliente client = new Cliente(name, apellido, rut, nacimiento, nacionalidad);
            if(listaClientes.Count == 0)
            {
                listaClientes.Add(client);
                return true;
            }

            foreach (Cliente c in listaClientes)
            {
                if (Equals(c, client))
                {
                    Console.WriteLine("Este cliente ya fue ingresado");
                    return false;
                }
            }
            listaClientes.Add(client);
            Console.WriteLine("El cliente fue ingresado al sistema");
            return true;
        }


        private string GetName()
        {
            return nombre;
        }


        public override string ListaClientes()
        {
            string info = "LISTA DE CLIENTES: \n--------------------------------------------------\n";
            for (int i = 0; i < listaClientes.Count; i++)
            {
                info += listaClientes[i].InformacionClientes();
            }
            info += "--------------------------------------------------\n";
            return info;
        }

        private string InformacionClientes()                //Te entrega la informacion de un cliente
        {
            string informacion = "Nombre: " + nombre + "   Apellido: " + apellido + "   RUT: " + rut + "   Fecha de nacimiento: " + nacimiento + "   Nacionalidad: " + nacionalidad + "\n";
            return informacion;
        }

        public string ListaNombres()
        {
            string nombresCl = "nombres: \n";

            foreach (Cliente clt in listaClientes)
            {
                nombresCl += clt.GetName() + "  ";
            }

            return nombresCl;

        }



    }
}
