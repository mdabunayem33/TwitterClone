using TwitterClone.Domain.Entities;


Console.WriteLine("Task1 complete");

var likeNotification = new LikeNotification(Guid.NewGuid());
Console.WriteLine(likeNotification.GetMassage());

var commentNotification = new CommentNotification(Guid.NewGuid());
Console.WriteLine(commentNotification.GetMassage());

var friendRequestNotification = new FriendRequestNotification(Guid.NewGuid());
Console.WriteLine(friendRequestNotification.GetMassage());

var mentionNotification = new MentionNotification(Guid.NewGuid());
Console.WriteLine(mentionNotification.GetMassage());

var systemNotification = new SystemNotification();
Console.WriteLine(systemNotification.GetMassage());



//Task 2: emon kichu dorkar jeno mention class obbosi thake
