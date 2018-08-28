using System;
using System.Collections.Generic;
using System.Text;

namespace Pandemic.model.countries
{
    class Belgium : Country
    {
        public Belgium(string name, long population, int amountOfDiseases, ColorEnum color) : base(name, population, amountOfDiseases, color)
        {
        }
    }
}
