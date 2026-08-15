namespace TwitterClone.Domain.Entities
{
    public class Retweet
    {   private Guid _id;
        private Guid _userid;
        private Guid _tweetId;
        private string _comment;
        private DateTime _createdAt;
        private DateTime _modifiedAt;

        public Retweet()
        {
            _id = Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
            _modifiedAt = DateTime.UtcNow;
        }

        public Guid Id
        {
            get { return _id; }
        }
        public Guid UserId
        {
            get { return _userid; }
        }
        public Guid TweetId
        {
            get { return _tweetId; }
        }

        private string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

        private DateTime CreatedAt
        {
            get { return _createdAt; }
        }

        private DateTime ModifiedAt
        {
            get { return _modifiedAt; }
            set { _modifiedAt = value; }
        }
    }
}
