using System;
using System.Collections.Generic;
using System.Text;

namespace Pandemic.model
{
    public class Country
    {
        public string Name { get; set; }
        public uint Population { get; set; }
        public int AmountOfDiseases { get; set; }
        public ColorEnum Color { get; set; }

        public Country(string name, uint population, int amountOfDiseases, ColorEnum color)
        {
            this.Name = name;
            this.Population = population;
            this.AmountOfDiseases = amountOfDiseases;
            this.Color = color;
        }
    }
}
