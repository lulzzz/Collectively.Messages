﻿using System;

namespace Collectively.Messages.Events.Remarks
{
    public class RemarkResolved : RemarkStateChangedBase
    {
        protected RemarkResolved()
        {
        }

        public RemarkResolved(Guid requestId, Resource resource, 
            string userId, Guid remarkId, Guid? groupId = null)
            : base(requestId, resource, userId, remarkId, groupId)
        {
        }
    }
}