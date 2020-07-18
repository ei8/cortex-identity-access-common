using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ei8.Cortex.IdentityAccess.Common
{
    public class NeuronValidationResult
    {
        public NeuronValidationResult() : this(Guid.Empty, new ErrorInfo[0])
        {
        }

        [JsonConstructor]
        public NeuronValidationResult(Guid neuronId, IEnumerable<ErrorInfo> errors)
        {
            this.NeuronId = neuronId;
            this.Errors = errors;
        }

        public Guid NeuronId { get; private set; }

        public IEnumerable<ErrorInfo> Errors { get; private set; }
    }
}
