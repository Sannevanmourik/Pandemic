using Pandemic.model;
using System;
using Pandemic.model.userRoles;
using Pandemic.model.countries;
using Pandemic.controllers;

namespace Pandemic
{
    class Program
    {
        public static void Main(string[] args)
        {

            SetUpController setUpGame = new SetUpController();
            setUpGame.StartGame();

            CountryChoiceController countryChoice = new CountryChoiceController();
            countryChoice.CountryChoice();

            PlayerActionController playerAction = new PlayerActionController();
            playerAction.ShowAllActions();

            Console.ReadKey();
        }
    }
}

