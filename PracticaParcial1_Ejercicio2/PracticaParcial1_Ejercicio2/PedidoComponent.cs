using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaParcial1_Ejercicio2
{
    abstract class PedidoComponent
    {
        public int Cantidad { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public PedidoComponent(string nombre, decimal precio, int cantidad) 
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.Cantidad = cantidad;
        }
    }
}
