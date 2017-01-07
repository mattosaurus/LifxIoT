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
    public class Cycle : ApiMethod<ApiResponse, Mix>
    {
        public Cycle(ILifxIdentity identity)
            : base(identity, "lights/{0}/cycle", HttpMethod.Post)
        {
        }

        public async Task<ApiResponse> Set(ISelector selector, Mix mix)
        {
            return await this.Execute(mix, selector.GetSelectorText()).ConfigureAwait(continueOnCapturedContext: false);
        }

        protected async override Task<ApiResponse> OnExecuted(HttpResponseMessage response)
        {
            ApiResponse returnValue = null;

            string json = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
            returnValue = JsonConvert.DeserializeObject<ApiResponse>(json);

            return returnValue;
        }
    }
}
