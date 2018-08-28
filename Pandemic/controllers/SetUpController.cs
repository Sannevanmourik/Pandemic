using System;
using Pandemic.model;
using Pandemic.model.countries;
using Pandemic.model.userRoles;

namespace Pandemic.controllers
{
    class SetUpController
    {
        //create countries
        private Country netherlands = new Netherlands("Netherlands", 17_000_000, 0, ColorEnum.Blue);
        private Country belgium = new Belgium("Belgium", 11_350_000, 0, ColorEnum.Black);

        public Country Netherlands { get => netherlands;}
        public Country Belgium { get => belgium;}

        public string AskUserForName()
        {
            //welcome user and ask for name
            Console.Write("Welcome to Pandemic! \r\nWhat is your name? ");
            var name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hi, " + name + " nice to meet you!");
            Console.WriteLine();
            return name;
        }


        public void ChooseUserRole(string name)
        { 
         
                Console.Write("Which role would you like to play? ");
                Console.Write("Please choose one from the following list:" +
                    "\r\n 1. Medic" +
                    "\r\n 2. Researcher" +
                    "\r\n 3. Scientist" +
                    "\r\n 4. Crisis Manager" +
                    "\r\n 5. Logistics Manager" +
                    "\r\n 6. Project Manager" +
                    "\r\n 7. Quarantine Specialist" +
                    "\r\n"
                    );
                Console.Write("Enter your choice: ");
                var userRole = Convert.ToInt32(Console.ReadLine());
                switch (userRole)
                {
                    case 1:
                        Console.WriteLine("\r\nYou chose Medic.");
                        Player medic = new MedicPlayer(name);
                        break;
                    case 2:
                        Console.WriteLine("\r\nYou chose Researcher.");
                        Player researcher = new ResearcherPlayer(name);

                        break;
                    case 3:
                        Console.WriteLine("\r\nYou chose Scientist.");
                        Player scientist = new ScientistPlayer(name);
                        break;
                    case 4:
                        Console.WriteLine("\r\nYou chose Crisis Manager.");
                        Player crisisManager = new CrisisManagerPlayer(name);
                        break;
                    case 5:
                        Console.WriteLine("\r\nYou chose Operations Expert.");
                        Player logisticsManager = new LogisticsManagerPlayer(name);
                        break;
                    case 6:
                        Console.WriteLine("\r\nYou chose Project Manager.");
                        Player projectManager = new ProjectManager(name);
                        break;
                    case 7:
                        Console.WriteLine("\r\nYou chose Quarantine Specialist.");
                        Player quarantineSpecialist = new QuarantineSpecialistPlayer(name);
                        break;

                    default:
                        Console.WriteLine("\r\nAn error has occured. Please reboot the game. ");
                        break;
                }
            }

        }
}
