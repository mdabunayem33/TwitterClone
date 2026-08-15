namespace TwitterClone.Domain.Entities
{
    public class User : BaseEntity
    {

        public User() : base(Guid.NewGuid())
        {
            
        }
       
        private string _FirstName = string.Empty;
        private string _LastName = string.Empty;
        private string _Email = string.Empty;
        
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
