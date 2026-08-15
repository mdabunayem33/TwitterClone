namespace TwitterClone.Domain.Entities
{
    public class Like : BaseEntity
    {  
        private Guid _userId;
        private Guid _tweetId;

        public Like() : base(Guid.NewGuid())
        {

        }

        public Guid UserId
        {
            get { return _userId; }
        }
        public Guid TweetId
        {
            get { return _tweetId; }
        }
        

    }
}
