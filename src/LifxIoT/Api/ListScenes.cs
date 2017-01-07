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
    public class ListScenes : ApiMethod<IEnumerable<Scene>>
    {
        public ListScenes(ILifxIdentity identity)
            : base(identity, "scenes")
        {
        }

        public async Task<IEnumerable<Scene>> Get()
        {
            return await this.Execute().ConfigureAwait(continueOnCapturedContext: false);
        }

        protected async override Task<IEnumerable<Scene>> OnExecuted(HttpResponseMessage response)
        {
            IEnumerable<Scene> returnValue = new Scene[0];

            string json = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
            returnValue = JsonConvert.DeserializeObject<IEnumerable<Scene>>(json);

            return returnValue;
        }
    }
}
