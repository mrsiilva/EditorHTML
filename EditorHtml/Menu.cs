using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();
            int option = int.Parse(Console.ReadLine());
            HandleMenuOption(option);

            Console.ReadLine();
        }

        public static void DrawScreen()//Essa funcao DrawScreen responsavel por desenhar a nossa tela
        {

            PrimeiraLinha();
            CorpoDaTela();
            LinhaFinal();
        }

        public static void PrimeiraLinha()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }

        public static void CorpoDaTela()
        {
            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }
        }

        public static void LinhaFinal()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(10, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(10, 3);
            Console.WriteLine("-----------");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo: ");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("3 - Salvar");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("4 - SAIR");
            Console.SetCursorPosition(3, 11);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOption(int option)
        {
            switch (option)
            {
                case 1: Console.WriteLine("editor");break;
                case 2: Console.WriteLine("view"); break;
                case 3: Console.WriteLine("salvar em"); break;
                case 4:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break; //renderiza o menu novamente
            }
        }
    }
}
