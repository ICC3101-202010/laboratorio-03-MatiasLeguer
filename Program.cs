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
            Cliente clt = new Cliente();
            Empleados[] listaEmpleados = {new Gerente(), new Cajero(), new Reponedor()};
            List<string> registroCompras = new List<string>();


            bool goodOrBad;
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Bienvenido al menú principal. Porfavor escriba una de estas opciones: agregar producto, listado de productos, agregar persona, lista personas, cambiar trabajo, realizar compra, registro compras, close.");
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

                    case "cambiar trabajo":
                        Console.Write("Si desea cambiar el trabajo a un gerente, escriba '0'. Si desea cambiar el trabajo a un cajero, escriba '1'. Si desea cambiar el trabajo a un reponedor, escriba '2': ");
                        string status = Console.ReadLine();
                        int indice = Int32.Parse(status);
                        string cambio;
                        string nombreCT;
                        bool realizarCambio;

                        if (status == "0")
                        {
                            Console.WriteLine(listaEmpleados[indice].ListaNombres());
                            Console.Write("Escriba el nombre de la persona a la que quiere cambiar de puesto: ");
                            nombreCT = Console.ReadLine();
                            List<string> infoCT = listaEmpleados[indice].CambiarPuestoTrabajo(nombreCT);

                            Console.Write("A que puesto desea cambiar al empleado? Escriba 'cajero' o 'reponedor': ");
                            cambio = Console.ReadLine();
                            
                            if (cambio == "cajero")
                            {
                                int s = 333391;
                                realizarCambio = listaEmpleados[1].NuevaPersona(infoCT[0], infoCT[1], infoCT[2], infoCT[3], infoCT[4], s);
                                Console.WriteLine("Se ha ingresado el nuevo Cajero!");
                                
                            }
                            else if(cambio == "reponedor")
                            {
                                int s = 300000;
                                realizarCambio = listaEmpleados[2].NuevaPersona(infoCT[0], infoCT[1], infoCT[2], infoCT[3], infoCT[4], s);
                                Console.WriteLine("Se ha ingresado el nuevo reponedor!");
                            }
                            else
                            {
                                Console.WriteLine("No escribió ninguna de las opciones.");
                            }
                            
                        }
                        else if(status == "1")
                        {
                            Console.WriteLine(listaEmpleados[indice].ListaNombres());
                            Console.Write("Escriba el nombre de la persona a la que quiere cambiar de puesto: ");
                            nombreCT = Console.ReadLine();
                            List<string> infoCT = listaEmpleados[indice].CambiarPuestoTrabajo(nombreCT);

                            Console.Write("A que puesto desea cambiar al empleado? Escriba 'gerente' o 'reponedor': ");
                            cambio = Console.ReadLine();

                            if (cambio == "gerente")
                            {
                                int s = 1000000;
                                realizarCambio = listaEmpleados[1].NuevaPersona(infoCT[0], infoCT[1], infoCT[2], infoCT[3], infoCT[4], s);
                                Console.WriteLine("Se ha ingresado el nuevo Gerente!");

                            }
                            else if (cambio == "reponedor")
                            {
                                int s = 300000;
                                realizarCambio = listaEmpleados[2].NuevaPersona(infoCT[0], infoCT[1], infoCT[2], infoCT[3], infoCT[4], s);
                                Console.WriteLine("Se ha ingresado el nuevo reponedor!");
                            }
                            else
                            {
                                Console.WriteLine("No escribió ninguna de las opciones.");
                            }
                            
                        }
                        else if(status == "2")
                        {
                            Console.WriteLine(listaEmpleados[indice].ListaNombres());
                            Console.Write("Escriba el nombre de la persona a la que quiere cambiar de puesto: ");
                            nombreCT = Console.ReadLine();
                            List<string> infoCT = listaEmpleados[indice].CambiarPuestoTrabajo(nombreCT);

                            Console.Write("A que puesto desea cambiar al empleado? Escriba 'cajero' o 'gerente': ");
                            cambio = Console.ReadLine();

                            if (cambio == "cajero")
                            {
                                int s = 333391;
                                realizarCambio = listaEmpleados[1].NuevaPersona(infoCT[0], infoCT[1], infoCT[2], infoCT[3], infoCT[4], s);
                                Console.WriteLine("Se ha ingresado el nuevo Cajero!");

                            }
                            else if (cambio == "gerente")
                            {
                                int s = 1000000;
                                realizarCambio = listaEmpleados[2].NuevaPersona(infoCT[0], infoCT[1], infoCT[2], infoCT[3], infoCT[4],s);
                                Console.WriteLine("Se ha ingresado el nuevo Gerente!");
                            }
                            else
                            {
                                Console.WriteLine("No escribió ninguna de las opciones.");
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("No escribió ninguna de las opciones.");
                        }

                        break;

                    case "realizar compra":
                        Console.WriteLine(clt.ListaNombres());
                        Console.Write("Escriba el nombre del cliente que quiere que realice la compra: ");
                        string nCL = Console.ReadLine();

                        Console.WriteLine(p.ListaProductos());
                        Console.WriteLine("Escriba los productos que desea, separandolos por un ENTER. Si es que desea parar de comprar productos, escriba 'LISTO'.");
                        bool listo = true;
                        int costo = 0;
                        List<string> carro = new List<string>();
                        string objeto;
                        string agregarProd;


                        while (listo)
                        {
                            objeto = Console.ReadLine();
                            agregarProd = p.AgregarAlCarro(objeto);
                            if(objeto == "LISTO")
                            {
                                listo = false;
                                continue;
                            }
                            else if (agregarProd == "npnp")
                            {
                                continue;
                            }
                            else
                            {
                                carro.Add(objeto);
                                costo += int.Parse(agregarProd);
                            }
                        }

                        int costoTotal = costo;

                        int largo = listaEmpleados[1].GetCount();
                        Console.WriteLine("Escoga una caja entre el 0 y el " + largo.ToString());
                        int caja = Int32.Parse(Console.ReadLine());

                        string nombreCa = listaEmpleados[1].NombreCajero(caja);

                        string boleta = p.DesarrollarBoleta(nCL, nombreCa, costoTotal, carro);
                        registroCompras.Add(boleta);
                        Console.WriteLine("La compra se ha realizado con exito!");
                        Console.WriteLine(boleta);
                        break;

                    case "registro compras":
                        if(registroCompras.Count == 0)
                        {
                            Console.WriteLine("No se ha realizado ninguna compra.");
                        }
                        else
                        {
                            string registro = "REGISTRO DE COMPRAS: \n---------------------------------------------------\n";
                            foreach(string reg in registroCompras)
                            {
                                registro += reg + "\n";
                            }

                            Console.WriteLine(registro);
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
