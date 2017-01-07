using LifxIoT.Interfaces;
using LifxIoT.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LifxIoT.Api
{
    public class SetStates : ApiMethod<IEnumerable<OperationResult>, Mix>
    {
        public SetStates(ILifxIdentity identity)
            : base(identity, "lights/states", HttpMethod.Put)
        {
        }

        public async Task<IEnumerable<OperationResult>> Set(Mix mix)
        {
            return await this.Execute(mix).ConfigureAwait(continueOnCapturedContext: false);
        }

        protected async override Task<IEnumerable<OperationResult>> OnExecuted(HttpResponseMessage response)
        {
            IEnumerable<OperationResult> returnValue = null;

            string json = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
            returnValue = JsonConvert.DeserializeObject<IEnumerable<OperationResult>>(json);

            return returnValue;
        }
    }
}
