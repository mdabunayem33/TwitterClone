using System.Security.Cryptography.X509Certificates;

namespace TwitterClone.Domain.Entities
{
    public class LikeNotification : Notification
    {
        public LikeNotification(Guid likeByUserId) : base("Like")
        {
            LikeByUserId = likeByUserId;
        }

        public Guid LikeByUserId { get; set; }

        public void AddMessage(string message)
        {
            Message = message;
        }
        public override string DescribeRecord()
        {
            var baseRecord =base.DescribeRecord();
            return $"{baseRecord} - Notification Type: {Type}, Message: {Message}, IsRead: {IsRead}, LikeByUserId: {LikeByUserId}";
        }

        public override string GetMassage()
        {
            return $"User with ID {LikeByUserId} liked your post.";
        }

    }
}
