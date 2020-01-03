using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeComprass
{
    class CarritoDeCompra
    {
       public CarritoDeCompra()
        {

        }
       // //2
       // //Cabecera de Carrito
       //propiedad cabercera de carrito
       public  CabeceraCarrito Cabecera { get; set; }


        //detalle de carrito
        //lista de detalle de carrito (producto y la cantidad)
        public List<DetalleCarrito> Detalle { get; set; }
       

           }
    }

