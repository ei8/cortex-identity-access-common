using System;
using System.Collections.Generic;
using System.Text;

namespace ei8.Cortex.IdentityAccess.Common
{
    public class AuthorInfo
    {
        public AuthorInfo() : this(Guid.Empty, false)
        {
        }

        public AuthorInfo(Guid userNeuronId, bool active)
        {
            this.UserNeuronId = userNeuronId;
            this.Active = active;
        }

        public Guid UserNeuronId { get; private set; }

        public bool Active { get; private set; }
    }
}
