using System;

namespace ConsoleApp2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int offset = 2;
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("введите символ");
            string symbol = Console.ReadLine();

            for (int i = 0; i < name.Length + offset; i++)
            {
                Console.Write(symbol);                
            }
            
            Console.WriteLine("\n" + symbol + name + symbol);

            for (int i = 0; i < name.Length + offset; i++)
            {
                Console.Write(symbol);
            }            
        }
    }
}
