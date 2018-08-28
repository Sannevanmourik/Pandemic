using System;

namespace Pandemic.model
{
    public class Player
    {
        private string Name { get; set; }
        public Country currentCountry { get; set; }
        
        public Player(string name)
        {
            this.Name = name;

        }

        public void TreatDesease()
        {
            currentCountry.AmountOfDiseases--;
            
        }



    }


}
