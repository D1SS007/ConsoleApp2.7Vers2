using System;

namespace ConsoleApp2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int offset = 1;
            int stringsAmount = 3;
            int yNamePosition = 6;

            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("введите символ");
            string symbol = Console.ReadLine();

            for (int i = 0; i < stringsAmount; i++)
            {
                Console.Write("\n" + symbol);
                
                for (int j = 0; j < name.Length + offset; j++)
                {
                    Console.Write(symbol);
                }                
            }            
            Console.SetCursorPosition(offset, yNamePosition);
            Console.WriteLine(name + "\n");
        }
    }
}
