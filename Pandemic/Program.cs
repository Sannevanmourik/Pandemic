using Pandemic.model;
using System;
using Pandemic.model.userRoles;

namespace Pandemic
{
    class Program
    {
        static void Main(string[] args)
        {

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

