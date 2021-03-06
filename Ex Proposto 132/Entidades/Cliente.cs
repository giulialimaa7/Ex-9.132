using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Proposto_132.Entidades
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public Cliente()
        {

        }
        public Cliente(string nome, string email, DateTime dataNascimento)
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
        }
        public override string ToString()
        {
            return Nome
                + ", ("
                + DataNascimento.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }              
    }    
}
