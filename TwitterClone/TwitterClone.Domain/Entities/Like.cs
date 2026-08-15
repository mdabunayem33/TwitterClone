namespace TwitterClone.Domain.Entities
{
    public class Like
    {   private Guid _id;
        private Guid _userId;
        private Guid _tweetId;
        private DateTime _createdAt;
        private DateTime _modifiedAt;

        public Like()
        {
            _id = Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
        }

        public Guid UserId
        {
            get { return _userId; }
        }
        public Guid TweetId
        {
            get { return _tweetId; }
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
