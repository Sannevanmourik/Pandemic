using Pandemic.model;
using System;
using Pandemic.model.userRoles;
using Pandemic.model.countries;
using Pandemic.controllers;
using System.Threading.Tasks;

namespace Pandemic
{
    class Program
    {
        public static void Main(string[] args)
        {
            MainAsync(args).Wait();

            CountryChoiceController countryChoice = new CountryChoiceController();
            countryChoice.CountryChoice();

            PlayerActionController playerAction = new PlayerActionController();
            playerAction.ShowAllActions();

            Console.ReadKey();
        }

        public static async Task<bool> MainAsync(string[] args)
        {
            SetUpController setUpGame = new SetUpController();
            var startGame = setUpGame.StartGame();
            Task.Delay(5000000);

            return await Task.Run(() => startGame);

        }

    }
}



