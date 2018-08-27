using System;
using System.Collections.Generic;
using System.Text;

namespace Pandemic.model
{
    public class UserRole
    {
        private string Name { get; set; }
        private string Description { get; }

        public UserRole(string name)
        {
            Name = name;
        }

    }

}
