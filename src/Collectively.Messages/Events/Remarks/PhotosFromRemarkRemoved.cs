using System;

namespace Collectively.Messages.Events.Remarks
{
    public class PhotosFromRemarkRemoved : IAuthenticatedEvent, IResource
    {
        public Guid RequestId { get; }
        public Resource Resource { get; }
        public string UserId { get; }
        public Guid RemarkId { get; }

        protected PhotosFromRemarkRemoved()
        {
        }

        public PhotosFromRemarkRemoved(Guid requestId, Resource resource, 
            string userId, Guid remarkId)
        {
            RequestId = requestId;
            Resource = resource;
            UserId = userId;
            RemarkId = remarkId;
        }
    }
}