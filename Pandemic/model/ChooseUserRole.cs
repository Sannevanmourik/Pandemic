using Pandemic.model.userRoles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pandemic.model
{
    class ChooseUserRole
    {
        public static void chooseUserRole(String name)
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
