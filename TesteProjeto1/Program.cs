using System;
using TesteProjeto1.Views;
using TesteProjeto1.Views.Clientes;

namespace TesteProjeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            TelaAbertura.Apresenta();
            TelaMenuInicial.Apresenta();
            Console.ReadKey();
        }
    }
}
