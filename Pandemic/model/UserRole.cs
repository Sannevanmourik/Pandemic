using System;
using System.Collections.Generic;
using System.Text;

namespace Pandemic.model
{
    public class UserRole
    {
        private string name;
        private string Description;

        public UserRole(string name)
        {
            this.name = name;
        }

        public string Name { get => name; set => name = value; }


    }


}
