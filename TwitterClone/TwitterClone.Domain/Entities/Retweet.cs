namespace TwitterClone.Domain.Entities
{
    public class Retweet : BaseEntity
    { 
        private Guid _userid;
        private Guid _tweetId;
        private string _comment;

        public Retweet() : base(Guid.NewGuid())
        {

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

       
    }
}
