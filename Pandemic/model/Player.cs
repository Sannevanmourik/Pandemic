namespace Pandemic.model
{
    public class Player
    {
        private string name;
        UserRole userRole;

        public Player()
        {

        }
        
        public Player(string name)
        {
            this.name = name;

        }

        public string Name { get => name; set => name = value; }


    }

    
}
