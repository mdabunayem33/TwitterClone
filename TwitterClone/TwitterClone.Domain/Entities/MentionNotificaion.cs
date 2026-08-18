namespace TwitterClone.Domain.Entities
{
    public class MentionNotification : Notification
    {
        public MentionNotification(Guid mentionedByUserId) : base("Mention")
        {
            MentionedByUserId = mentionedByUserId;
        }
        public Guid MentionedByUserId { get; set; }
        public void AddMessage(string message)
        {
            Message = message;
        }
        public override string GetMassage()
        {
            return $"User with ID {MentionedByUserId} mentioned you in a post.";
        }
    }
}
