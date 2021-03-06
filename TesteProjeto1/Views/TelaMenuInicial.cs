﻿using System;


namespace TesteProjeto1.Views
{
    class TelaMenuInicial
    {

        public static void Apresenta()
        {
            int upArrow = 2490368;
            int downArrow = 2621440;
            int enter = 851981;
            int opcaoEscolha = 1;

            LimpaTela();
            Opcao1();

            while (true)
            {
                var teclaDigitada = Console.ReadKey().GetHashCode();
                if (teclaDigitada == upArrow && opcaoEscolha > 1)
                {
                    opcaoEscolha--;
                }else if (teclaDigitada == downArrow && opcaoEscolha < 4)
                {
                    opcaoEscolha++;
                }

                if (teclaDigitada == enter)
                {
                    switch (opcaoEscolha)
                    {
                        case 1:
                            TelaMenuCliente.Apresenta();
                            break;
                        
                    }
                    //zera contagem da escolha
                    LimpaTela();
                    opcaoEscolha = 1;

                }


                switch (opcaoEscolha)
                {
                    case 1:
                        Opcao1();
                        break;
                    case 2:
                        Opcao2();
                        break;
                    case 3:
                        Opcao3();
                        break;
                    case 4:
                        Opcao4();
                        break;
                }

            }

        }



        private static void Opcao1()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\tUSE OS BOTÕES DIRECIONAIS PARA NAVEGAR:\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t==>\tClientes");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\t\t==>\tPedidos");
            Console.WriteLine("\t\t==>\tHistorico de vendas");
            Console.WriteLine("\t\t==>\tVendas detalhadas por mês");
        }

        private static void Opcao2()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\tUSE OS BOTÕES DIRECIONAIS PARA NAVEGAR:\n");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\t\t==>\tClientes");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t==>\tPedidos");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\t\t==>\tHistorico de vendas");
            Console.WriteLine("\t\t==>\tVendas detalhadas por mês");
        }

        private static void Opcao3()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\tUSE OS BOTÕES DIRECIONAIS PARA NAVEGAR:\n");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\t\t==>\tClientes");
            Console.WriteLine("\t\t==>\tPedidos");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t==>\tHistorico de vendas");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\t\t==>\tVendas detalhadas por mês");
        }

        private static void Opcao4()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\tUSE OS BOTÕES DIRECIONAIS PARA NAVEGAR:\n");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\t\t==>\tClientes");
            Console.WriteLine("\t\t==>\tPedidos");
            Console.WriteLine("\t\t==>\tHistorico de vendas");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t==>\tVendas detalhadas por mês");
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
                    Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine(new String(Convert.ToChar(" "), 30));
            }
        }

    }
}
