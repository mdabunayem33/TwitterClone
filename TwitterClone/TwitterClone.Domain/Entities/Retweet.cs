namespace TwitterClone.Domain.Entities
{
    public class Retweet
    {
        private Guid _userid;
        private Guid _tweetId;
        private DateTime _dateretweeted;

        public Guid UserId
        {
            get { return _userid; }
        }
        public Guid TweetId
        {
            get { return _tweetId; }
        }
        public DateTime Dateretweeted
        {
            get { return _dateretweeted; }
            set { _dateretweeted = value; }

        }
    }
}
