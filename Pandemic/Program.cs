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
            SetUpController.GetChosenPlayer(0).TreatDesease();
            Console.WriteLine("You decremented the amount of diseases in " + SetUpController.GetChosenPlayer(0).currentCountry);
            Console.WriteLine("Current ammount of diseases: " + SetUpController.GetChosenPlayer(0).currentCountry.AmountOfDiseases);
            

            Console.ReadKey();
        }
    }
}

