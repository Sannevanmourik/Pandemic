using System;

namespace Pandemic.model
{
    public class Player
    {
        private string Name { get; set; } //Name moet met hoofdletter
        
        
        public Player(string name)
        {
            this.Name = name;

        }

       // public string Name { get => Name; set => Name = value; }


    }


}
