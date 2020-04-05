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
        protected double precio;
        protected bool stockDisp;
        protected int stock;
        protected List<Producto> productos = new List<Producto>(0);

        public Producto(string nombre, string marca, double precio, int stock)  //Constructor
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
        public string GetMarca()
        {
            return marca;
        }
        public double GetPrecio()
        {
            return precio;
        }
        public int GetStock()
        {
            return stock;
        }

        public bool NuevoProducto(Producto n)                         //Crea un nuevo producto
        {

            if (productos.Count == 0)
            {
                productos.Add(n);
                Console.WriteLine(productos.Count);
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
