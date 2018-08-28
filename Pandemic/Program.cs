using Pandemic.model;
using System;
using Pandemic.model.userRoles;
using Pandemic.model.countries;
using Pandemic.controllers;

namespace Pandemic
{
    class Program
    {
        static void Main(string[] args)
        {

            SetUpController setUpGame = new SetUpController();
            setUpGame.StartGame();

            CountryChoiceController countryChoice = new CountryChoiceController();
            countryChoice.CountryChoice();

            //TODO Sanne move this part to a controller
            //TODO Sanne make sure player only sees currentCountry name instead of pandemic.....

            Console.WriteLine("Dear user, would you like to decrement the disease by 1? Yes or No? ");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "Yes":
                    SetUpController.GetChosenPlayer(0).TreatDesease();
                    Console.WriteLine("You decremented the amount of diseases in " + SetUpController.GetChosenPlayer(0).currentCountry);
                    Console.WriteLine("Current ammount of diseases: " + SetUpController.GetChosenPlayer(0).currentCountry.AmountOfDiseases);
                    break;

                case "yes":
                    SetUpController.GetChosenPlayer(0).TreatDesease();
                    Console.WriteLine("You decremented the amount of diseases in " + SetUpController.GetChosenPlayer(0).currentCountry);
                    Console.WriteLine("Current ammount of diseases: " + SetUpController.GetChosenPlayer(0).currentCountry.AmountOfDiseases);
                    break;

                case "No":
                    Console.WriteLine("You didn't decrement the amount of diseases in " + SetUpController.GetChosenPlayer(0).currentCountry);
                    Console.WriteLine("Current ammount of diseases: " + SetUpController.GetChosenPlayer(0).currentCountry.AmountOfDiseases);
                    break;

                case "no":
                    Console.WriteLine("You didn't decrement the amount of diseases in " + SetUpController.GetChosenPlayer(0).currentCountry);
                    Console.WriteLine("Current ammount of diseases: " + SetUpController.GetChosenPlayer(0).currentCountry.AmountOfDiseases);
                    break;

                default:
                    break;


            }


            Console.ReadKey();
        }
    }
}

