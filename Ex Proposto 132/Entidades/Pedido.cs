using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using Ex_Proposto_132.Entidades;
using Ex_Proposto_132.Entidades.Enums;

namespace Ex_Proposto_132.Entidades
{
    class Pedido
    {
        public DateTime Momento { get; set; }
        public StatusPedido Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemPedido> Itens { get; set; } = new List<ItemPedido>();

        public Pedido()
        {

        }
        public Pedido(DateTime momento, StatusPedido status, Cliente cliente)
        {
            Momento = momento;
            Status = status;
            Cliente = cliente;
        }
        public void AddItem (ItemPedido item)
        {
            Itens.Add(item);
        }
        public void RemoverItem (ItemPedido item)
        {
            Itens.Remove(item);
        }
        public double Total()
        {
            double soma = 0.0;
            foreach (ItemPedido item in Itens)
            {
                soma += item.SubTotal();
            }
            return soma;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Momento do pedido: " + Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Status do pedido: " + Status);
            sb.AppendLine("Clienet: " + Cliente);
            sb.AppendLine("Itens do pedido:");

            foreach (ItemPedido item in Itens)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }   
}
