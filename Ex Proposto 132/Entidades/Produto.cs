using System;
using System.Collections.Generic;
using System.Text;
using Ex_Proposto_132.Entidades.Enums;
    
namespace Ex_Proposto_132.Entidades
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preço { get; set; }
        public Produto()
        {

        }
        public Produto(string nome, double preço)
        {
            Nome = nome;
            Preço = preço;
        }
    }
}
