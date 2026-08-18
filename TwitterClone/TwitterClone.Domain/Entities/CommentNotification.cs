namespace TwitterClone.Domain.Entities
{
    public class CommentNotification : Notification
    {
        public CommentNotification(Guid commentedByUserId) : base("Comment")
        {
            CommentedByUserId = commentedByUserId;
        }

        public Guid CommentedByUserId { get; set; }

        public void AddMessage(string message)
        {
            Message = message;
        }   

        public override string GetMassage()
        {
            return $"User with ID {CommentedByUserId} commented on your post.";
        }
    }
}
