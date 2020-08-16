using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteProjeto1.Models;

namespace TesteProjeto1.Banco
{
    class BancoFake
    {
        public List<Cliente> listaClientes = new List<Cliente>();

        public void PopulaCliente()
        {
            listaClientes.Add( new Cliente("Paulo José", "007.348.499-74", "(43)99638-9841", "Paulo@email.com"));
            listaClientes.Add(new Cliente("Davi Pereira", "111.348.499-74", "(43)99638-9841", "Davi@email.com"));
            listaClientes.Add(new Cliente("José Antunes", "222.348.499-74", "(43)99638-9841", "Jose@email.com"));
            listaClientes.Add(new Cliente("André Camargo", "333.348.499-74", "(43)99638-9841", "Andre@email.com"));
            listaClientes.Add(new Cliente("Pedro Estaquio", "444.348.499-74", "(43)99638-9841", "Pedro@email.com"));
            listaClientes.Add(new Cliente("Ana Paula ", "555.348.499-74", "(43)99638-9841", "Ana@email.com"));
            listaClientes.Add(new Cliente("Michael Jackson", "666.348.499-74", "(43)99638-9841", "MJ@email.com"));
            listaClientes.Add(new Cliente("Fred Mercury", "777.348.499-74", "(43)99638-9841", "FM@email.com"));
            
        }


    }
}
