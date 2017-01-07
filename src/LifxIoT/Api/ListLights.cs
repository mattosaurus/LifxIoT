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
    public class ListLights : ApiMethod<IEnumerable<Light>>
    {
        public ListLights(ILifxIdentity identity)
            : base(identity, "lights/{0}")
        {
        }

        public async Task<IEnumerable<Light>> Get(ISelector selector)
        {
            return await this.Execute(selector.GetSelectorText()).ConfigureAwait(continueOnCapturedContext: false);
        }

        protected async override Task<IEnumerable<Light>> OnExecuted(HttpResponseMessage response)
        {
            IEnumerable<Light> returnValue = new Light[0];

            string json = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
            returnValue = JsonConvert.DeserializeObject<IEnumerable<Light>>(json);

            return returnValue;
        }
    }
}
