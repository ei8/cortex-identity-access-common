using neurUL.Common.Domain.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ei8.Cortex.IdentityAccess.Common
{
    public class ActionValidationResult
    {
        public ActionValidationResult() : this(Guid.Empty, new ErrorInfo[0], new NeuronValidationResult[0])
        {
        }        

        [JsonConstructor]
        public ActionValidationResult(Guid userNeuronId, IEnumerable<ErrorInfo> errors, IEnumerable<NeuronValidationResult> neuronValidationResults)
        {
            AssertionConcern.AssertArgumentNotNull(errors, nameof(errors));
            AssertionConcern.AssertArgumentNotNull(neuronValidationResults, nameof(neuronValidationResults));

            this.UserNeuronId = userNeuronId;
            this.Errors = errors;
            this.NeuronValidationResults = neuronValidationResults;
        }

        public Guid UserNeuronId { get; private set; }

        public IEnumerable<ErrorInfo> Errors { get; private set; }

        public IEnumerable<NeuronValidationResult> NeuronValidationResults { get; private set; }

        [JsonIgnore]
        public bool HasErrors => this.Errors.Any(e => e.Type == ErrorType.Error) ||
                this.NeuronValidationResults.Any(nvr => nvr.Errors.Any(ei => ei.Type == ErrorType.Error));
    }
}
