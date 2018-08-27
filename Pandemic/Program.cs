using Pandemic.model;
using System;

namespace Pandemic
{
    class Program
    {
        static void Main(string[] args)
        {

        Console.Write("Welcome to Pandemic! \r\nWhat is your name? ");
            var name = Console.ReadLine();
            Console.Write("Which role would you like to play? Please choose one from the following list:" +
                "\r\n 1. Medic" +
                "\r\n 2. Researcher" +
                "\r\n 3. Scientist" +
                "\r\n 4. Dispatcher" +
                "\r\n 5. Operations Expert"
                );
            //var userRole = Console.ReadLine();
            Player player = new Player(name) ;
            Console.WriteLine();
            Console.WriteLine("Hi, " + player.Name + " nice to meet you!");
            Console.ReadKey();
        }
    }
}

