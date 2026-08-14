namespace TwitterClone.Domain.Entities
{
    public class Follow
    {
        private Guid _followerid;
        private Guid _followingid;
        private DateTime _followat;

        public Guid FollowerId
        {
            get { return _followerid; }
        }

        public Guid FollowingId
        {
            get { return _followingid; }
        }

        public DateTime FollowAt
        {
            get { return _followat; }
        }



    }
}
