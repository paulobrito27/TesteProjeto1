using System;
using System.Collections.Generic;
using System.Text;

namespace TesteProjeto1.Models
{
    class Cliente
    {
        public string Nome  { get; set; }
        public string CPF{ get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Cliente(string nome, string cpf, string telefone, string email)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Email = email;
        }
    }
}
