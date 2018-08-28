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
            Console.Write("Welcome to Pandemic! \r\nWhat is your Name? ");
            var name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hi, " + name + " nice to meet you!");
            Console.WriteLine();
            ChooseUserRole.chooseUserRole(name);
            Console.ReadKey();
        }
    }
}

