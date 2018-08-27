using System;
using System.Collections.Generic;
using System.Text;

namespace Pandemic.model
{
    class CreateUserRoles
    {

        public void CreateAllUserRoles()
        {
            UserRole Researcher = new UserRole("Researcher");
            UserRole Medic = new UserRole("Medic");
            UserRole LogisticsManager = new UserRole("Logistics Manager");
            UserRole Scientist = new UserRole("Scientist");
            UserRole ProjectManager = new UserRole("Project Manager");
            UserRole QuarantineSpecialist = new UserRole("Quarantine Specialist");
            UserRole CrisisManager = new UserRole("Crisis Manager");
        }
    }
}
