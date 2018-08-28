using System;
using System.Collections.Generic;
using System.Text;

namespace Pandemic.model.countries
{
    class Netherlands : Country
    {
        public Netherlands(string name, long population, int amountOfDiseases, ColorEnum color) : base(name, population, amountOfDiseases, color)
        {
        }
    }
}
