﻿using System;

namespace Collectively.Messages.Events.Users
{
    public class NewPasswordSet : IEvent
    {
        public Guid RequestId { get; }
        public string Email { get; }

        protected NewPasswordSet()
        {
        }

        public NewPasswordSet(Guid requestId, string email)
        {
            RequestId = requestId;
            Email = email;
        }
    }
}