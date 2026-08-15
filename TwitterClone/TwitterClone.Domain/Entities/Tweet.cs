namespace TwitterClone.Domain.Entities
{
    public class Tweet
    {
        private Guid _id;
        private Guid _authorId;
        private string _content = string.Empty;
        private DateTime _createdAt;
        private DateTime _modifiedAt;

        public Tweet()
        {
            _id = Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
            _modifiedAt = DateTime.UtcNow;
        }

        public Guid Id
        {
            get { return _id; }
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
        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }
        public DateTime ModifiedAt
        {
            get { return _modifiedAt; }
            set { _modifiedAt = value; }
        }

    }
}
