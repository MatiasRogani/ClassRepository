using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaParcial1_Ejercicio2
{
    class PedidoComposite : PedidoComponent
    {
        public PedidoComposite(string nombre, decimal precio=0, int cantidad=0) : base(nombre, precio, cantidad) { } 

        private List<PedidoComponent> productos = new List<PedidoComponent>();

        decimal total = 0;
        public decimal Importe 
        {

            get 
            {
                //int contador = 0;
                foreach (var item in productos)
                {
                    if (item.GetType().Name == "PedidoComposite")
                    {
                        //total += ((PedidoComposite)item).productos[contador].Precio * ((PedidoComposite)item).productos[contador].Precio;
                        total += ((PedidoComposite)item).Importe;
                        //contador++;
                    }
                    else
                    {
                        total += item.Precio * item.Cantidad;
                    }
                }
                return total;
            }
        }

        public void Add(PedidoComponent elemento) 
        {
            productos.Add(elemento);
        }

        public void Remove(PedidoComponent elemento) 
        {
            productos.Remove(elemento);
        }
    }
}
