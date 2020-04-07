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
                Console.WriteLine("Bienvenido al menú principal. Porfavor escriba una de estas opciones: agregar producto, listado de productos, agregar persona, lista personas, cambiar trabajo, realizar compra, registro compras, reponer stock, simulador, close.");
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

                        int largo = listaEmpleados[1].GetCount() - 1;
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

                    case "reponer stock":
                        p.ChangeStock();
                        break;

                    case "simulador":
                        int stockSim = 60;
                        Random rnd = new Random();
                        List<int> numRandom = new List<int>();
                        List<Producto> lProductosSim = new List<Producto>() { new Producto("huevos","Jumbo",3199,stockSim),                new Producto("manjar","colun",1649,stockSim),                            new Producto("snack para perros","master dog",1000,stockSim),            new Producto("bebida coca cola zero 3L","coca cola",2290,stockSim), new Producto("harina con polvo de hornear","mont blanc",839,stockSim), new Producto("spaghetti","ralliani",729,stockSim),          new Producto("limon 1kg","frutas y verduras jumbo",1990,stockSim),          new Producto("pisco","alto del carmen",5990,stockSim),         new Producto("rolls nuts","costa",1399,stockSim),                new Producto("papas prefritas 1kg","minuto verde",3499,stockSim),
                                                                              new Producto("atún","jumbo",1099,stockSim),                  new Producto("jamon pierna","la preferida",2000,stockSim),               new Producto("alimentos para perros grande","pedigree",20990,stockSim),  new Producto("bebida fanta zero 1,5L","fanta zero",1550,stockSim),  new Producto("harina sin polvo","jumbo",839,stockSim),                 new Producto("espirales","carozzi",739,stockSim),           new Producto("manzana verde 900g","frutas y verduras jumbo",1590,stockSim), new Producto("pisco sour","secreto peruano",3890,stockSim),    new Producto("chocolate sahne nuss","sahne nuss",3289,stockSim), new Producto("sofrito 150g","frutos del maipo",549,stockSim),
                                                                              new Producto("papel higienico","elite",8599,stockSim),       new Producto("chorizo","la crianza",3000,stockSim),                      new Producto("alimentos para gato adulto","champion cat",2490,stockSim), new Producto("bebida pepsi 1,5L","pepsi",1450,stockSim),            new Producto("polvo de hornear 200g","imperial",1460,stockSim),        new Producto("lasagna","talliani",1259,stockSim),           new Producto("tomate 250g","frutas y verduras jumbo",1389,stockSim),        new Producto("sauvignon blanc","concha y toro",4690,stockSim), new Producto("chocolate relleno menta","orly",899,stockSim),     new Producto("nuggets de pollo 400g","super pollo",1899,stockSim),
                                                                              new Producto("lavalozas quix","quix",2999,stockSim),         new Producto("pechuga de pavo","la preferida",1999,stockSim),            new Producto("toallitas humedas","huggies",2499,stockSim),               new Producto("bebida bilz 1,5L","bilz",1450,stockSim),              new Producto("almidon de maiz","dropa",2990,stockSim),                 new Producto("ravioli","carozzi",1399,stockSim),            new Producto("zanahoria 1kg","frutas y verduras jumbo",1690,stockSim),      new Producto("vino","oveja negra",4459,stockSim),              new Producto("kit kat","nestle",890,stockSim),                   new Producto("hamburgesa de soya","la crianza",749,stockSim),
                                                                              new Producto("mantequilla con sal","soprole",1699,stockSim), new Producto("alimentos de gatos","Cat chow",590,stockSim),              new Producto("almendras tostadas","cuisine & Co",5699,stockSim),         new Producto("bebida pap 1,5L","pap",1450,stockSim),                new Producto("arroz","jumbo",929,stockSim),                            new Producto("corbatas","carozzi",739,stockSim),            new Producto("zapallo italiano","frutas y verduras jumbo",690,stockSim),    new Producto("piña colada","campanario",4290,stockSim),        new Producto("chocolate de leche","trencito",1590,stockSim),     new Producto("pizza vegetariana congelada","PF",3799,stockSim),
                                                                              new Producto("leche descremada","soprole",749,stockSim),     new Producto("alimento para perros grande","master dog",17490,stockSim), new Producto("mix frutos secos","emporia nuts",3990,stockSim),           new Producto("bebida limon soda 1,75L","limon soda",1490,stockSim), new Producto("arroz integral","aruba",1170,stockSim),                  new Producto("fideos de arroz","cock brand",1599,stockSim), new Producto("rucula","frutas y verduras jumbo",1890,stockSim),             new Producto("ponche piña","undurraga",3890,stockSim),         new Producto("papas duquesas","minuto verde",3599,stockSim),     new Producto("hamburguesa de vacuno","la crianza",1199,stockSim)};
                        List<string> nombresSim = new List<string> {"Antonio","Carmen", "Manuel", "Josefa", "David", "Bernardita", "Francisco", "Matias", "Diego", "Natalia", "Isidora", "Constanza", "Santiago", "Javiera", "Pedro", "Antonia", "Rafael", "Elizabeth", "Alberto", "Camila", "Rodrigo", "Daniel", "Daniela", "Trinidad", "Elena", "Patricio", "Sandra", "Corina", "Javier", "Alvaro" };
                        List<string> apellidosSim = new List<string> { "Leguer", "Fuentes", "Ruiz", "Ruiz-Tagle", "Hernandez", "Galindo", "Araya", "Quijada", "Carvajal", "Escaff", "Alvarez", "De la masa", "Pinochet", "Giraldo", "Machado", "Sanchez", "Apara", "Howard", "Diaz", "Demierre", "Quiros", "Ordenes", "Miranda", "Namur", "Fernandez", "Rodriguez", "Oyarce", "Prieto", "Torres" };
                        List<string> rutSim = new List<string> { "11120302-4", "13164218-0", "5879775-8", "8461099-2", "11905538-5", "10849176-0", "24877407-k", "19907398-2", "20788220-8", "6815351-4", "5126090-2", "20737967-0", "15252734-9", "16088149-6", "18631636-3", "6334899-6", "11893205-6", "20531925-5", "15144940-9", "18254096-k", "5244277-k", "20074439-k" };
                        List<string> fechasNacSim = new List<string> {"02/26/1999", "23/05/1995", "12/06/1970", "14/12/1999", "04/11/1999", "05/09/1950", "30/06/1991", "17/05/1988", "22/11/1995", "11/04/1954", "11/11/1991", "12/12/1992", "08/07/1945", "06/08/1999", "03/08/1999", "29/02/1942", "21/06/1957", "26/10/1960", "17/01/1967", "27/11/1993" };
                        List<string> nacionalidadSim = new List<string> { "chilnea", "colombiana", "rusa", "venezolana", "americana" };
                        List<Cliente> listaCltSim = new List<Cliente>();
                        List<Cajero> listaCajeroSim = new List<Cajero>();

                        int i = 0;
                        int k = 0;
                        int rutClinete = 0;
                        int rutCajero = 15;
                        while (i < 15)
                        {
                            Cliente cliente = new Cliente(nombresSim[rnd.Next(0, nombresSim.Count)], apellidosSim[rnd.Next(0, apellidosSim.Count)], rutSim[rutClinete], fechasNacSim[rnd.Next(0, fechasNacSim.Count)], nacionalidadSim[rnd.Next(0, nacionalidadSim.Count)]);
                            listaCltSim.Add(cliente);
                            rutClinete++;
                            i++;
                        }
                        while(k < 5)
                        {
                            Cajero cajero = new Cajero(nombresSim[rnd.Next(0, nombresSim.Count)], apellidosSim[rnd.Next(0, apellidosSim.Count)], rutSim[rutCajero], fechasNacSim[rnd.Next(0, fechasNacSim.Count)], nacionalidadSim[rnd.Next(0, nacionalidadSim.Count)], 333391);
                            listaCajeroSim.Add(cajero);
                            rutCajero++;
                            k++;
                        }

                        Gerente gerente = new Gerente(nombresSim[rnd.Next(0, nombresSim.Count)],apellidosSim[rnd.Next(0, apellidosSim.Count)],rutSim[21],fechasNacSim[rnd.Next(0, fechasNacSim.Count)],nacionalidadSim[rnd.Next(0, nacionalidadSim.Count)],1000000);
                        Reponedor reponedor = new Reponedor(nombresSim[rnd.Next(0, nombresSim.Count)], apellidosSim[rnd.Next(0, apellidosSim.Count)], rutSim[20], fechasNacSim[rnd.Next(0, fechasNacSim.Count)], nacionalidadSim[rnd.Next(0, nacionalidadSim.Count)], 300000);

                        string informacionClt = "Información clientes: \n--------------------------------------------------------\n";
                        string informacionCajeros = "Información cajeros: \n--------------------------------------------------------\n";
                        string informacionGer = "Información Gerente: \n--------------------------------------------------------\n" + gerente.InformacionGerente();
                        string informacionRep = "Información Reponedor: \n--------------------------------------------------------\n" + reponedor.InformacionRep();
                        string informacionProductos = "Información Productos: \n--------------------------------------------------------\n";

                        foreach (Cliente c in listaCltSim)
                        {
                            informacionClt += c.InformacionClientes() + "\n";
                        }
                        foreach (Cajero caj in listaCajeroSim)
                        {
                            informacionCajeros += caj.InformacionCajero() + "\n";
                        }

                        string no = "si";
                        int randomNumber;
                        for (int val = 0; val < 30; val++)
                        {
                            randomNumber = rnd.Next(0, lProductosSim.Count);
                            if(numRandom.Count == 0)
                            {
                                informacionProductos += lProductosSim[randomNumber].Informacion() + "\n";
                                numRandom.Add(randomNumber);
                            }
                            else
                            {
                                foreach(int num in numRandom)
                                {
                                    if(num == randomNumber)
                                    {
                                        val--;
                                        no = "no";
                                        break;
                                    }
                                }
                                if (no == "si")
                                {
                                    informacionProductos += lProductosSim[rnd.Next(0, lProductosSim.Count)].Informacion() + "\n";
                                    numRandom.Add(randomNumber);
                                }
                                no = "si";
                            }
                            
                        }

                        Console.WriteLine(informacionClt);
                        Console.WriteLine("\n");
                        Console.WriteLine(informacionCajeros);
                        Console.WriteLine("\n");
                        Console.WriteLine(informacionGer);
                        Console.WriteLine("\n");
                        Console.WriteLine(informacionRep);
                        Console.WriteLine("\n");
                        Console.WriteLine(informacionProductos);
                        Console.WriteLine("\n");

                        string registroComprasSim = "Registro de compras del simulador: \n---------------------------------------------------------------\n";

                        for(int compras = 0; compras < 5; compras++)
                        {
                            string nCliente = listaCltSim[rnd.Next(0, 15)].GetName();
                            string nCajero = listaCajeroSim[rnd.Next(0, 5)].GetName();
                            registroComprasSim += "BOLETA " + (compras + 1).ToString() + "  Cliente:  " + nCliente + "  Cajero: " + nCajero + "\n---------------------------------------------------------------\n";

                            int cantProductos = rnd.Next(1,31);
                            int costoSim = 0;
                            while (cantProductos > 0)
                            {
                                int r = rnd.Next(0, lProductosSim.Count);
                                registroComprasSim += lProductosSim[r].GetName() + ".............................";
                                registroComprasSim += lProductosSim[r].GetPrice().ToString() + "\n";
                                costoSim += lProductosSim[r].GetPrice();
                                lProductosSim[r].ReducirProducto();
                                cantProductos--;
                            }

                            registroComprasSim += "COSTO TOTAL: " + costoSim.ToString() + "\n\n";

                        }

                        string infoActualizada = "Informacion Actualizada Productos: \n-----------------------------------------------\n";
                        foreach(int numero in numRandom)
                        {
                            infoActualizada += lProductosSim[numero].Informacion() + "\n";
                        }








                        Console.WriteLine(registroComprasSim);
                        Console.WriteLine("\n\n");
                        Console.WriteLine(infoActualizada);
                        break;



























                    case "close":
                        loop = false;
                        break;

                }
            }
            

        }



    }

}
