using Pandemic.model;
using System;

namespace Pandemic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to Pandemic! \r\nWhat is your name? ");
            string name = Console.ReadLine();
            Player player = new Player(name) ;
            Console.WriteLine();
            Console.WriteLine("Hi, " + player.Name + " nice to meet you!");
            Console.ReadKey();
        }
    }
}
