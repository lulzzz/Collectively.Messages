﻿using System;

namespace Collectively.Messages.Events.Remarks
{
    public class RemarkProcessed : RemarkStateChangedBase
    {
        protected RemarkProcessed()
        {
        }

        public RemarkProcessed(Guid requestId, Resource resource, 
            string userId, Guid remarkId, Guid? groupId = null)
            : base(requestId, resource, userId, remarkId, groupId)
        {
        }
    }
}