using System;
using System.Collections.Generic;
using System.Text;
using Ex_Proposto_132.Entidades;
using Ex_Proposto_132.Entidades.Enums;
using System.Globalization;


namespace Ex_Proposto_132.Entidades
{
    class ItemPedido
    {
        public int Quantidade { get; set; }
        public double Preço { get; set; }
        public Produto Produto { get; set; }

        public ItemPedido()
        {

        }
        public ItemPedido(int quantidade, double preço, Produto produto)
        {
            Quantidade = quantidade;
            Preço = preço;
            Produto = produto;
        }

        public double SubTotal ()
        {
            return Preço * Quantidade;
        }
        public override string ToString()
        {
                return Produto.Nome
                + ", $"
                + Preço.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantitdade: "
                + Quantidade
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
    }   }
}
