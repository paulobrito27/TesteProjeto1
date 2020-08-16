using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteProjeto1.Banco;

namespace TesteProjeto1.Views.Clientes
{
    class TelaMostraListaClientes
    {
        public static void Mostrar()
        {
            var BD = new BancoFake();
            BD.PopulaCliente();

            LimpaTela();

            Console.WriteLine("\n\n\t\t\t\t\t\tLISTA DE CLIENTES");
            Console.WriteLine($"\n\n\t|||-----------------------------------------------------------------------------------------------------|||");
            Console.WriteLine($"\t|||\tNOME\t\t|\tCPF \t\t|\tTELEFONE\t|\tEMAIL\t\t\t|||");
            Console.WriteLine($"\t|||\t    \t\t|\t    \t\t|\t        \t|\t     \t\t\t|||");
            foreach (var cliente in BD.listaClientes)
            {
                Console.WriteLine($"\t|||\t{cliente.Nome}\t|\t{cliente.CPF}\t|\t{cliente.Telefone}\t|\t{cliente.Email}\t\t|||");
            }
            Console.WriteLine($"\t|||\t    \t\t|\t    \t\t|\t        \t|\t     \t\t\t|||");
            Console.WriteLine($"\t|||\t    \t\t|\t    \t\t|\t        \t|\t     \t\t\t|||");
            Console.WriteLine($"\t|||-----------------------------------------------------------------------------------------------------|||");

            Console.WriteLine("\n\n\n\n\n\nTecle algo para sair");
            Console.ReadKey();
        }



        private static void LimpaTela()
        {
            WriteCharacterStrings(1, 26, true);
            Console.MoveBufferArea(0, Console.CursorTop - 10, 30, 1,
                Console.CursorLeft, Console.CursorTop + 1);
            Console.CursorTop = Console.CursorTop + 3;
            Console.Clear();

        }
        private static void WriteCharacterStrings(int start, int end,
            bool changeColor)
        {
            for (int ctr = start; ctr <= end; ctr++)
            {
                if (changeColor)
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(new String(Convert.ToChar(" "), 30));
            }
        }
    }
}
