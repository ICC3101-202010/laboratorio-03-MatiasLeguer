using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_MatiasLeguer
{
    public class Producto
    {
        protected string nombre;
        protected string marca;
        protected int precio;
        protected bool stockDisp;
        protected int stock;
        protected List<Producto> productos = new List<Producto>(0);

        public Producto(string nombre, string marca, int precio, int stock)  //Constructor
        {
            this.nombre = nombre;
            this.marca = marca;
            this.precio = precio;
            this.stock = stock;
            if(stock > 0)
            {
                this.stockDisp = true;
            }
            else
            {
                this.stockDisp = false;
            }
        }

        
        public string GetName()                                                 //devuelve el nombre del producto
        {
            return nombre;
        }
        
        public int GetStock()
        {
            return stock;
        }

        public int GetPrice()
        {
            return precio;
        }

        public bool NuevoProducto(Producto n)                         //Crea un nuevo producto
        {
            if (productos.Count == 0)
            {
                productos.Add(n);
                Console.WriteLine(productos[0].Informacion());
                return true;
            }
            else
            {
                for(int i = 0; i < productos.Count; i++)
                {
                    
                    if (Equals(n, productos[i]))
                    {
                        Console.WriteLine("Este producto ya fue ingresado al supermercado");
                        return false;
                    }
                }
            }

            productos.Add(n);
            return true;
        }

        public string ListaProductos()             //Te entrega una lista de todos los productos que han sido ingresados.
        {
            string info = "LISTA DE PRODUCTOS: \n--------------------------------------------------\n";
            for (int i = 0; i < productos.Count; i++)
            {
                info += productos[i].Informacion();
            }
            info += "--------------------------------------------------\n";
            return info;
        }


        public string AgregarAlCarro(string objeto)
        {
            string costo;
            for(int i = 0; i < productos.Count; i++)
            {
                if((productos[i].GetName() == objeto) && (productos[i].GetStock() > 0))
                {
                    costo = productos[i].GetPrice().ToString();
                    productos[i].ReducirProducto();
                    return costo;
                }
                else if((productos[i].GetName() == objeto) && (productos[i].GetStock() == 0))
                {
                    Console.WriteLine("El producto está agotado. Lo siento");
                    return "npnp";
                }
            }
            Console.WriteLine("Porfavor, escriba un producto que se encuentre en la lista de productos.");
            return "npnp";
        }


        public string DesarrollarBoleta(string nCliente, string nCajero, int costoTotal, List<string> carro)
        {
            string boleta = "BOLETA \n--------------------------------------\nCLIENTE: " + nCliente + "    CAJERO: " + nCajero + "   Fecha/Hora: " + DateTime.Now.ToString() + "\n";
            foreach(Producto p in productos)
            {
                foreach(string c in carro)
                {
                    if (Equals(p.GetName(), c))
                    {
                        boleta += c + "......................." + p.GetPrice().ToString() + "\n";
                    }
                }
            }
            boleta += "COSTO TOTAL: " + costoTotal.ToString();
            return boleta;
        }






        //METODOS PRIVADOS
        //--------------------------------------------------------------------------------------------------------------
        private void ReducirProducto()            //Reduce el stock del producto que quieras
        {   
            if (stockDisp == false)
            {
                Console.WriteLine("El producto " + nombre + " se ha agotado");
            }
            else
            {
                stock -= 1;
                if (stock == 0)
                {
                    stockDisp = false;
                }
            }
        }

        private string Informacion()                //Te entrega la informacion de un producto
        {
            string informacion = "Nombre: " + nombre + "   Marca: " + marca + "   Precio: " + precio.ToString() + "   Cantidad: " + stock.ToString() + "\n";
            return informacion;
        }

        //--------------------------------------------------------------------------------------------------------------


    }
}
