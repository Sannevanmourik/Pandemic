using System;
using System.Collections.Generic;
using System.Text;

namespace Pandemic.model
{
    class Player
    {
        private String name;

        public Player(string name)
        {
            this.name = name;
        }

        public string Name { get => name; set => name = value; }

    }
}
