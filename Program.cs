using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_MatiasLeguer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Producto> listaProductos = new List<Producto>(0);
            Producto p =  new Producto("default", "default", 0, 0);
            Persona clt = new Cliente();
            Empleados[] listaEmpleados = {new Gerente(), new Cajero(), new Reponedor()};


            bool goodOrBad;
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Bienvenido al menú principal. Porfavor escriba una de estas opciones: agregar producto, listado de productos, agregar persona, lista personas, close.");
                string caseSwitch = Console.ReadLine();

                switch (caseSwitch)
                {
                    case "agregar producto":

                        Console.Write("Escriba el nombre del producto: "); string name = Console.ReadLine();
                        Console.Write("Escriba la marca del producto: ");  string brand = Console.ReadLine();
                        Console.Write("Escriba el precio del producto: "); int price = Int32.Parse(Console.ReadLine());
                        Console.Write("Escriba la cantidad: ");            int quantity = Int32.Parse(Console.ReadLine());

                        Producto newProduct = new Producto(name, brand, price, quantity);
                        goodOrBad = p.NuevoProducto(newProduct);
                        if (goodOrBad == true)
                        {
                            listaProductos.Add(newProduct);
                            Console.WriteLine("Se ha ingresado el nuevo producto al supermercado, Muchas Gracias!!");
                        }
                        break;

                    case "listado de productos":
                        Console.WriteLine(p.ListaProductos());
                        break;

                    case "agregar persona":
                        string n;
                        string ap;
                        string rut;
                        string fNac;
                        string nac;
                        int sueldo;

                        Console.Write("Si es que quiere agregar un GERENTE, escriba '0'. Si quiere agregar a un CAJERO, escriba '1'. Si quiere agregar a un REPONEDOR, escriba '2'. Si quiere agregar a un CLIENTE, escriba '3': ");
                        string opcion = Console.ReadLine();
                        int index = Int32.Parse(opcion);
                        switch (opcion)
                        {
                            case "0":
                                Console.Write("Escriba el nombre del gerente: ");                        n = Console.ReadLine();
                                Console.Write("Escriba el appellido: ");                                 ap = Console.ReadLine();
                                Console.Write("Escriba el RUT: ");                                       rut = Console.ReadLine();
                                Console.Write("Escriba la fecha de nacimiento (Ejemplo: 02/26/1999): "); fNac = Console.ReadLine();
                                Console.Write("Escriba la nacionalidad: ");                              nac = Console.ReadLine();

                                sueldo = 1000000;

                                goodOrBad = listaEmpleados[index].NuevaPersona(n, ap, rut, fNac, nac, sueldo);
                                break;

                            case "1":
                                Console.Write("Escriba el nombre del cajero: ");                         n = Console.ReadLine();
                                Console.Write("Escriba el appellido: ");                                 ap = Console.ReadLine();
                                Console.Write("Escriba el RUT: ");                                       rut = Console.ReadLine();
                                Console.Write("Escriba la fecha de nacimiento (Ejemplo: 02/26/1999): "); fNac = Console.ReadLine();
                                Console.Write("Escriba la nacionalidad: ");                              nac = Console.ReadLine();

                                sueldo = 333991;

                                goodOrBad = listaEmpleados[index].NuevaPersona(n, ap, rut, fNac, nac, sueldo);
                                break;

                            case "2":
                                Console.Write("Escriba el nombre del reponedor: ");                      n = Console.ReadLine();
                                Console.Write("Escriba el appellido: ");                                 ap = Console.ReadLine();
                                Console.Write("Escriba el RUT: ");                                       rut = Console.ReadLine();
                                Console.Write("Escriba la fecha de nacimiento (Ejemplo: 02/26/1999): "); fNac = Console.ReadLine();
                                Console.Write("Escriba la nacionalidad: ");                              nac = Console.ReadLine();

                                sueldo = 300000;

                                goodOrBad = listaEmpleados[index].NuevaPersona(n, ap, rut, fNac, nac, sueldo);
                                break;

                            case "3":
                                Console.Write("Escriba el nombre del cliente: ");                        n = Console.ReadLine();
                                Console.Write("Escriba el appellido: ");                                 ap = Console.ReadLine();
                                Console.Write("Escriba el RUT: ");                                       rut = Console.ReadLine();
                                Console.Write("Escriba la fecha de nacimiento (Ejemplo: 02/26/1999): "); fNac = Console.ReadLine();
                                Console.Write("Escriba la nacionalidad: ");                              nac = Console.ReadLine();

                                goodOrBad = clt.NuevaPersona(n, ap, rut, fNac, nac);
                                break;
                        }
                        break;

                    case "lista personas":
                        Console.Write("Si quieres la lista de GERENTES, escriba 'gerentes'. Si quieres la lista de CAJEROS, escriba 'cajeros'. Si quieres la lista de REPONEDORES, escriba 'reponedores'. Si quieres la lista de CLIENTES, escriba 'clientes': ");
                        string user = Console.ReadLine();

                        if (user == "gerentes")
                        {
                            Console.WriteLine(listaEmpleados[0].ListaGerentes());
                        }
                        else if (user == "cajeros")
                        {
                            Console.WriteLine(listaEmpleados[1].ListaCajeros());
                        }
                        else if (user == "reponedores")
                        {
                            Console.WriteLine(listaEmpleados[2].ListaReps());
                        }
                        else if (user == "clientes")
                        {
                            Console.WriteLine(clt.ListaClientes());
                        }
                        else
                        {
                            Console.WriteLine("No ingreso ninguna de las opciones");
                            break;
                        }
                        break;










































                    case "close":
                        loop = false;
                        break;

                }
            }
            

        }
    }
}
