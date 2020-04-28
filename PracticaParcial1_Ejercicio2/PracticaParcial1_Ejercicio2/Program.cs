using System;

namespace PracticaParcial1_Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto empanada = new Producto("Empanadas", 45, 12);
            Producto pizza = new Producto("Pizzas", 300, 2);
            Producto gaseosa = new Producto("Gaseosas", 100, 3);

            PedidoComposite pedido = new PedidoComposite("Pedido1");
            PedidoComposite pedido2 = new PedidoComposite("Pedido2");
            pedido.Add(empanada);
            pedido.Add(pizza);
            pedido.Add(gaseosa);
            pedido2.Add(gaseosa);
            pedido2.Add(empanada);
            pedido.Add(pedido2);

            Console.WriteLine(pedido.Importe);

            Console.ReadKey();
        }
    }
}
