using System;
using System.Collections.Generic;
using System.Text;

namespace ei8.Cortex.IdentityAccess.Common
{
    public class ErrorInfo
    {
        public ErrorInfo() : this(string.Empty, ErrorType.Message)
        {
        }

        public ErrorInfo(string description, ErrorType type)
        {
            this.Description = description;
            this.Type = type;
        }

        public string Description { get; private set; }

        public ErrorType Type { get; private set; }
    }
}
