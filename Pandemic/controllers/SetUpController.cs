using System;
using System.Collections;
using System.Collections.Generic;
using Pandemic.model;
using Pandemic.model.countries;
using Pandemic.model.userRoles;

namespace Pandemic.controllers
{
    public class SetUpController
    {
        public static IList<Country> countries = new List<Country>();
        public static IList<Player> players = new List<Player>();
        
        /// <summary>
        /// initilizes all functions described in this class
        /// </summary>
        public bool StartGame()
        {
            try
            {
                AddCountryToCountriesList();
                string name = AskUserForName();
                ChooseUserRole(name);
                return true;
            }
            catch
            {
                return false;
            }

        }

                     
        /// <summary>
        /// creates a new country and adds it to the countries list
        /// </summary>
        /// <returns>countries list</returns>
        public IList<Country> AddCountryToCountriesList()
        {
            countries.Add(new Netherlands("Netherlands", 17_000_000, 3, ColorEnum.Blue));
            countries.Add(new Belgium("Belgium", 11_350_000, 1, ColorEnum.Black));
            
            return countries;

        }

        public static Country GetCountryFromCountries(int index)
        {

            return countries[index];
        }

        public static Player GetChosenPlayer(int index)
            {
                return players[index];
            }

        /// <summary>
        /// asks user for name
        /// </summary>
        /// <returns>the name of the user</returns>
        public string AskUserForName()
        {
            Console.Write("Welcome to Pandemic! \r\nWhat is your name? ");
            var name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hi, " + name + " nice to meet you!");
            Console.WriteLine();
            return name;
        }

        /// <summary>
        /// gives the user the option to choose a user role
        /// </summary>
        /// <param name="name"></param>
        public Player ChooseUserRole(string name)
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
                        players.Add(medic);
                        return medic;
                        
                    case 2:
                        Console.WriteLine("\r\nYou chose Researcher.");
                        Player researcher = new ResearcherPlayer(name);
                        players.Add(researcher);
                        return researcher;
                        
                    case 3:
                        Console.WriteLine("\r\nYou chose Scientist.");
                        Player scientist = new ScientistPlayer(name);
                        players.Add(scientist);
                        return scientist;

                    case 4:
                        Console.WriteLine("\r\nYou chose Crisis Manager.");
                        Player crisisManager = new CrisisManagerPlayer(name);
                        players.Add(crisisManager);
                        return crisisManager;

                    case 5:
                        Console.WriteLine("\r\nYou chose Operations Expert.");
                        Player logisticsManager = new LogisticsManagerPlayer(name);
                        players.Add(logisticsManager);
                        return logisticsManager;

                    case 6:
                        Console.WriteLine("\r\nYou chose Project Manager.");
                        Player projectManager = new ProjectManager(name);
                        players.Add(projectManager);
                        return projectManager;

                    case 7:
                        Console.WriteLine("\r\nYou chose Quarantine Specialist.");
                        Player quarantineSpecialist = new QuarantineSpecialistPlayer(name);
                        players.Add(quarantineSpecialist);
                        return quarantineSpecialist;

                    default:
                        Console.WriteLine("\r\nYou are a Project Manager. ");
                        Player defaultPlayer = new ProjectManager(name);
                        players.Add(defaultPlayer);
                        return defaultPlayer;
                }
            }

        }
}
