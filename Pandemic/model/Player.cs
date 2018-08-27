namespace Pandemic.model
{
    public class Player
    {
        private string name { get; set; }

        public Player(string name)
        {
            this.name = name;
            
        }

        public string Name { get => name; set => name = value; }

        //create userRoles for players
        public UserRole Researcher = new UserRole("Researcher");
        public UserRole Medic = new UserRole("Medic");
        public UserRole LogisticsManager = new UserRole("Logistics Manager");
        public UserRole Scientist = new UserRole("Scientist");
        public UserRole ProjectManager = new UserRole("Project Manager");
        public UserRole QuarantineSpecialist = new UserRole("Quarantine Specialist");
        public UserRole CrisisManager = new UserRole("Crisis Manager");

    }
}
