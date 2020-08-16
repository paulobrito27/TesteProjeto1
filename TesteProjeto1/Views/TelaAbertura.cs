using System;

namespace TesteProjeto1.Views
{
    class TelaAbertura
    {
        public static void Apresenta()
        {
            LimpaTela();

            Padawan();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(
                "\t\t\t\t     #########  #######    ###   ###  #######       \n" +
                "\t\t\t\t     ##         ##    ##   ###   ###  ##     #      \n" +
                "\t\t\t\t     ##         ##   ##    ###   ###  ##     ##     \n" +
                "\t\t\t\t     ##         ##  ##     ###   ###  ##      ##    \n" +
                "\t\t\t\t     ##         #####      ###   ###  ##      ##    \n" +
                "\t\t\t\t     ##         ##  ##     ###   ###  ##      ##    \n" +
                "\t\t\t\t     ##         ##   ##    ###   ###  ##     ##     \n" +
                "\t\t\t\t     #########  ##    ##   #########  ########      \n"+
                "\n\n\n\n\nEnter para continuar!!"
            );
            Console.ReadKey();
            Console.Clear();

        }

        private static void Padawan()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n" +
                              "\t\t\t\t\t\t   PROJETO PADAWAN     \n" 
                              );
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
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(new String(Convert.ToChar(" "), 30));
            }
        }


    }
}
