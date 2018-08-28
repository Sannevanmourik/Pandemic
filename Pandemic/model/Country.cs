using System;
using System.Collections.Generic;
using System.Text;

namespace Pandemic.model
{
    class Country
    {
        public string Name { get; set; }
        public long Population { get; set; }
        public int AmountOfDiseases { get; set; }
        public ColorEnum Color { get; set; }

        public Country(string name, long population, int amountOfDiseases, ColorEnum color)
        {
            this.Name = name;
            this.Population = population;
            this.AmountOfDiseases = amountOfDiseases;
            this.Color = color;
        }
    }
}
