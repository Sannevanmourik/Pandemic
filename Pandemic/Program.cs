using Pandemic.model;
using System;
using Pandemic.model.userRoles;
using Pandemic.model.countries;

namespace Pandemic
{
    class Program
    {
        static void Main(string[] args)
        {
            //create countries
            Country netherlands = new Netherlands("Netherlands", 17_000_000, 0, ColorEnum.Blue);
            Country belgium = new Belgium("Belgium", 11_350_000, 0, ColorEnum.Black);

            //welcome user and ask for name
            Console.Write("Welcome to Pandemic! \r\nWhat is your name? ");
                var name = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Hi, " + name + " nice to meet you!");
                Console.WriteLine();
                ChooseUserRole.chooseUserRole(name);
                Console.WriteLine();
               
            //Ask user to which country he/she wants to go
            Console.Write("To which country would you like to go? ");
            Console.Write("Please choose one from the following list:" +
                "\r\n 1. Netherlands" +
                "\r\n 2. Belgium" +
                "\r\n"
                );
            Console.Write("Enter your choice: ");
            var countryName = Convert.ToInt32(Console.ReadLine());
            switch (countryName)
            {
                case 1:
                    Console.WriteLine("\r\nYou are now in the Netherlands.");
                    Console.WriteLine("Population: " + netherlands.Population +
                                      "\r\nAmount of diseases: " + netherlands.AmountOfDiseases +
                                      "\r\nColor: " + netherlands.Color);
                    break;
                case 2:
                    Console.WriteLine("\r\nYou are now in Belgium.");
                    Console.WriteLine(  "Population: " + belgium.Population +
                                        "\r\nAmount of diseases: " + belgium.AmountOfDiseases +
                                        "\r\nColor: " + belgium.Color);
                    break;

                default:
                    Console.WriteLine("\r\nAn error has occured. Please reboot the game. ");
                    break;
            }

            Console.ReadKey();
        }
    }
}

