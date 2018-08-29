using System;
using Pandemic.controllers;

namespace Pandemic.controllers
{

    class PlayerActionController
    {
        public void ShowAllActions()
        {
            ActionTreatDisease();
        }


        public void ActionTreatDisease()
        {
            //TODO Sanne make sure player only sees currentCountry name instead of pandemic.....

            Console.WriteLine("Dear user, would you like to decrement the disease by 1? Yes or No? ");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "Yes":
                    SetUpController.GetChosenPlayer(0).TreatDisease();
                    Console.WriteLine("You decremented the amount of diseases in " + SetUpController.GetChosenPlayer(0).currentCountry);
                    Console.WriteLine("Current ammount of diseases: " + SetUpController.GetChosenPlayer(0).currentCountry.AmountOfDiseases);
                    break;

                case "yes":
                    SetUpController.GetChosenPlayer(0).TreatDisease();
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
        }
    }

}