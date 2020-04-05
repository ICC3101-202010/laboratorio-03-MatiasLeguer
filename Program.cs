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
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Bienvenido al menú principal. Porfavor escriba una de estas opciones: agregar producto, listado de productos, close.");
                string caseSwitch = Console.ReadLine();

                switch (caseSwitch)
                {
                    case "agregar producto":

                        Console.Write("Escriba el nombre del producto: "); string name = Console.ReadLine();
                        Console.Write("Escriba la marca del producto: ");  string brand = Console.ReadLine();
                        Console.Write("Escriba el precio del producto: "); double price = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Escriba la cantidad: ");            int quantity = Int32.Parse(Console.ReadLine());

                        Producto newProduct = new Producto(name, brand, price, quantity);
                        bool goodOrBad = p.NuevoProducto(newProduct);
                        if (goodOrBad == true)
                        {
                            listaProductos.Add(newProduct);
                            Console.WriteLine("Se ha ingresado el nuevo producto al supermercado, Muchas Gracias!!");
                        }
                        break;

                    case "listado de productos":
                        Console.WriteLine(p.ListaProductos());
                        break;

                    case "close":
                        loop = false;
                        break;

                }
            }
            

        }
    }
}
