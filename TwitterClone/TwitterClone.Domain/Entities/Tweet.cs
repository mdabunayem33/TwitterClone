namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEntity
    {
        
        private Guid _authorId;
        private string _content = string.Empty;
   
        public Tweet(string content) : base(Guid.NewGuid())
        {
            _content = content;
        }

        public Guid AuthorId
        {
            get { return _authorId; }
        }
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
       

    }
}
