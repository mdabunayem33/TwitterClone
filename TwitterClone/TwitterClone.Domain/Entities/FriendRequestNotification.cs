namespace TwitterClone.Domain.Entities
{
    public class FriendRequestNotification : Notification
    {
        public FriendRequestNotification(Guid requestedByUserId) : base("FriendRequest")
        {
            RequestedByUserId = requestedByUserId;
        }

        public Guid RequestedByUserId { get; set; }

        public void AddMessage(string message)
        {
            Message = message;
        }   

        public override string GetMassage()
        {
            return $"User with ID {RequestedByUserId} sent you a friend request.";
        }

    }
}
