using System;

namespace Collectively.Messages.Events.Remarks
{
    public class RemarkVoteSubmitted : IAuthenticatedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid RemarkId { get; }
        public bool Positive { get; }
        public DateTime CreatedAt { get; }

        protected RemarkVoteSubmitted()
        {
        }

        public RemarkVoteSubmitted(Guid requestId, string userId,
            Guid remarkId, bool positive, DateTime createdAt)
        {
            RequestId = requestId;
            UserId = userId;
            RemarkId = remarkId;
            Positive = positive;
            CreatedAt = createdAt;            
        }
    }
}