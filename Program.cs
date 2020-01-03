using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeComprass
{
    class Program
    {
        static void Main(string[] args)
        {

            //Crea productos aleatorios y los agrega a la lista de productos
            //productos en stock, con el metodo imprimir los muestra por pantalla(consola)
            StockProductos stock = new StockProductos();
            stock.CrearProductos();
            stock.ImprimirStockProductos();





            Cliente cliente = new Cliente();
            cliente.Apellidos = "Zambrano Zambrano";
            cliente.Nombres = "Michal Jackson";
            cliente.Direccion = "Manta";
            cliente.Cedula = "12121212";
            cliente.NombreUsario = "mzambrano";

            Empresa empresa = new Empresa();
            empresa.RazonSocial = "Amazon";
            empresa.Direccion = "California";


            CabeceraCarrito cabeceraCarrito = new CabeceraCarrito();
            cabeceraCarrito.ClienteCabecera = cliente;
            cabeceraCarrito.EmpresaCabecera = empresa;


            //Pedirle al usuario que ingrese el codigo del producto

            DetalleCarrito detallecarrito = new DetalleCarrito();
            int cantidad;
            cantidad = detallecarrito.CantidadProducto;

            Int32 n = 0;
            

            decimal total;
            do {
                Console.WriteLine("Ingrese el codigo del producto");
                int code = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad del producto");
                cantidad = Int32.Parse(Console.ReadLine());

                total = stock.ListaStockProductos[code - 1].Precio * cantidad;





                // stock.ImprimirStockProductos();

                Console.WriteLine("total" + total);
                Console.WriteLine(" Quieres salir , ingrese el 0");

                //Ciclo 
                n = -Int32.Parse(Console.ReadLine());

                
            } while (n != 0);

           


        }
    }
}
