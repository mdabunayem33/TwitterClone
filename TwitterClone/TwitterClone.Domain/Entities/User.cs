namespace TwitterClone.Domain.Entities
{
    public class User
    {
        private Guid _id;
        private string _FirstName = string.Empty;
        private string _LastName = string.Empty;
        private string _Email = string.Empty;

        public User() {
            _id = Guid.NewGuid();
        
        }
        public Guid Id
        { 
          get { return _id; } 
        }

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

    }
}
