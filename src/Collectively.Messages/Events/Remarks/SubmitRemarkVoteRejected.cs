using System;

namespace Collectively.Messages.Events.Remarks
{
    public class SubmitRemarkVoteRejected : IRejectedEvent
    {
        public Guid RequestId { get; }
        public string UserId { get; }
        public Guid RemarkId { get; }
        public string Code { get; }
        public string Reason { get; }

        protected SubmitRemarkVoteRejected()
        {
        }

        public SubmitRemarkVoteRejected(Guid requestId, 
            string userId, Guid remarkId,
            string code, string reason)
        {
            RequestId = requestId;
            UserId = userId;
            RemarkId = remarkId;
            Code = code;
            Reason = reason;
        }
    }
}