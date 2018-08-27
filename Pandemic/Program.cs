using Pandemic.model;
using System;

namespace Pandemic
{
    class Program
    {
        static void Main(string[] args)
        {

        var InitiateAllUserRoles = new CreateUserRoles();

        Console.Write("Welcome to Pandemic! \r\nWhat is your name? ");
            var name = Console.ReadLine();
            Player player = new Player(name);
            Console.WriteLine();
            Console.WriteLine("Hi, " + player.Name + " nice to meet you!");
            Console.WriteLine();
            Console.Write("Which role would you like to play? ");
            Console.Write("Please choose one from the following list:" +
                "\r\n 1. Medic" +
                "\r\n 2. Researcher" +
                "\r\n 3. Scientist" +
                "\r\n 4. Dispatcher" +
                "\r\n 5. Operations Expert" +
                "\r\n"
                );
            Console.Write("Enter your choice: ");
            var userRole = Convert.ToInt32(Console.ReadLine());
            switch (userRole)
            {
                case 1:
                    Console.WriteLine("\r\nYou chose Medic.");
                    break;
                case 2:
                    Console.WriteLine("\r\nYou chose Researcher.");
                    break;
                case 3:
                    Console.WriteLine("\r\nYou chose Scientist.");
                    break;
                case 4:
                    Console.WriteLine("\r\nYou chose Dispatcher.");
                    break;
                case 5:
                    Console.WriteLine("\r\nYou chose Operations Expert.");
                    break;

                default:
                    Console.WriteLine("\r\nAn error has occured. Please reboot the game. ");
                    break;
            }

            Console.ReadKey();
        }
    }
}

