using System;

namespace Collectively.Messages.Events.Remarks
{
    public class CommentEditedInRemark : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid RemarkId { get; }
        public Guid CommentId { get; }
        public string Text { get; }
        public DateTime CreatedAt { get; }

        protected CommentEditedInRemark()
        {
        }

        public CommentEditedInRemark(Guid requestId, string userId,
            Guid remarkId, Guid commentId, string text,
            DateTime createdAt)
        {
            RequestId = requestId;
            UserId = userId;
            RemarkId = remarkId;
            CommentId = commentId;
            Text = text;
            CreatedAt = createdAt;
        }
    }
}