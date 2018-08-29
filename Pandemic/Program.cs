using System;
using Pandemic.controllers;
using System.Threading.Tasks;

public delegate void EventHandler();

namespace Pandemic
{
    class Program
    {
        public static event EventHandler _show;

        public static void Main(string[] args)
        {
            _show += new EventHandler(WelcomeUser);

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
            _show.Invoke();
            Console.WriteLine();
            await Task.Delay(5000);

            var startGame = setUpGame.StartGame();

            return await Task.Run(() => startGame);

        }

        public static void WelcomeUser()
        {
            Console.Write("Welcome! \r\nPlease wait while we load the game...\r\n");

        }


    }
}



