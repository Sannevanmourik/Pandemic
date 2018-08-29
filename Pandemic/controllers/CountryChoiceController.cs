using System;
using System.Collections.Generic;
using System.Text;
using Pandemic.controllers;

namespace Pandemic.controllers
{
    class CountryChoiceController
    {

        public void CountryChoice()
        {
            var countryName = AskUserCountryChoice();
            ShowCountryDetailsOfChosenCountry(countryName);
        }



        public int AskUserCountryChoice()
        {
            //Ask user to which country he/she wants to go
            Console.Write("To which country would you like to go? ");
            Console.Write("Please choose one from the following list:" +
                "\r\n 1. Netherlands" +
                "\r\n 2. Belgium" +
                "\r\n"
                );
            Console.Write("Enter your choice: ");
            var countryName = Convert.ToInt32(Console.ReadLine());
            return countryName;
        }

        public void ShowCountryDetailsOfChosenCountry(int countryName)
        {
            switch (countryName)
            {
                case 1:
                    SetUpController.GetChosenPlayer(0).currentCountry = SetUpController.GetCountryFromCountries(0);
                    Console.WriteLine("\r\nYou are now in the Netherlands.");
                    Console.WriteLine("Population: " + SetUpController.GetCountryFromCountries(0).Population +
                                      "\r\nAmount of diseases: " + SetUpController.GetCountryFromCountries(0).AmountOfDiseases +
                                      "\r\nColor: " + SetUpController.GetCountryFromCountries(0).Color);
                    break;
                case 2:
                    SetUpController.GetChosenPlayer(0).currentCountry = SetUpController.GetCountryFromCountries(1);
                    Console.WriteLine("\r\nYou are now in Belgium.");
                    Console.WriteLine("Population: " + SetUpController.GetCountryFromCountries(1).Population +
                                        "\r\nAmount of diseases: " + SetUpController.GetCountryFromCountries(1).AmountOfDiseases +
                                        "\r\nColor: " + SetUpController.GetCountryFromCountries(1).Color);
                    break;

                default:
                    Console.WriteLine("\r\nAn error has occured. Please reboot the game. ");
                    break;
            }
        }
}
}
