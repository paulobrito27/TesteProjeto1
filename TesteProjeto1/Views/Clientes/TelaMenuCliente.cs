using System;
using System.Collections.Generic;
using System.Text;
using TesteProjeto1.Views.Clientes;

namespace TesteProjeto1.Views
{
    class TelaMenuCliente
    {

        public static void Apresenta()
        {
            bool continua = true;
            int upArrow = 2490368;
            int downArrow = 2621440;
            int enter = 851981;
            int opcaoEscolha = 1;

            LimpaTela();
            Opcao1();


            while (continua)
            {
                var teclaDigitada = Console.ReadKey().GetHashCode();
                if (teclaDigitada == upArrow && opcaoEscolha > 1)
                {
                    opcaoEscolha--;
                }
                else if (teclaDigitada == downArrow && opcaoEscolha < 5)
                {
                    opcaoEscolha++;
                }


                if (teclaDigitada == enter)
                {
                    switch (opcaoEscolha)
                    {
                        case 1:
                            TelaMostraListaClientes.Mostrar();
                            break;
                        case 5:
                            continua = false;
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
                    case 5:
                        Opcao5();
                        break;

                }
            }

        }

        private static void Opcao1()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\t\t\tUSE OS BOTÕES DIRECIONAIS PARA NAVEGAR:\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t==>\tLISTA DE CLIENTES");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t==>\tNOVO CLIENTE");
            Console.WriteLine("\t\t==>\tALTERAR CLIENTE");
            Console.WriteLine("\t\t==>\tDELETAR CLIENTE");
            Console.WriteLine("\n\n\t\t<<=\tVOLTAR ");
        }

        private static void Opcao2()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\t\t\tUSE OS BOTÕES DIRECIONAIS PARA NAVEGAR:\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t==>\tLISTA DE CLIENTES");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t==>\tNOVO CLIENTE");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t==>\tALTERAR CLIENTE");
            Console.WriteLine("\t\t==>\tDELETAR CLIENTE");
            Console.WriteLine("\n\n\t\t<<=\tVOLTAR ");
        }

        private static void Opcao3()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\t\t\tUSE OS BOTÕES DIRECIONAIS PARA NAVEGAR:\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t==>\tLISTA DE CLIENTES");
            Console.WriteLine("\t\t==>\tNOVO CLIENTE");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t==>\tALTERAR CLIENTE");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t==>\tDELETAR CLIENTE");
            Console.WriteLine("\n\n\t\t<<=\tVOLTAR ");
        }

        private static void Opcao4()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\t\t\tUSE OS BOTÕES DIRECIONAIS PARA NAVEGAR:\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t==>\tLISTA DE CLIENTES");
            Console.WriteLine("\t\t==>\tNOVO CLIENTE");
            Console.WriteLine("\t\t==>\tALTERAR CLIENTE");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t==>\tDELETAR CLIENTE");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n\t\t<<=\tVOLTAR ");
        }
        private static void Opcao5()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\t\t\tUSE OS BOTÕES DIRECIONAIS PARA NAVEGAR:\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t==>\tLISTA DE CLIENTES");
            Console.WriteLine("\t\t==>\tNOVO CLIENTE");
            Console.WriteLine("\t\t==>\tALTERAR CLIENTE");
            Console.WriteLine("\t\t==>\tDELETAR CLIENTE");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\t\t<<=\tVOLTAR ");

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
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(new String(Convert.ToChar(" "), 30));
            }
        }

    }
}

