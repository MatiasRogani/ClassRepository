using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaParcial1_Ejercicio2
{
    class Producto : PedidoComponent
    {
        public Producto(string nombre, decimal precio, int cantidad) : base(nombre, precio, cantidad)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.Cantidad = cantidad;
        }
    }
}
