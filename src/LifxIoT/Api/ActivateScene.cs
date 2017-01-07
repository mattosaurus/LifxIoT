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
    public class ActivateScene : ApiMethod<ApiResponse, Transition>
    {
        public ActivateScene(ILifxIdentity identity)
            : base(identity, "scenes/{0}/activate", HttpMethod.Put)
        {
        }

        public async Task<ApiResponse> Set(Scene scene, Transition transition)
        {
            return await this.Execute(transition, scene.GetSelectorText()).ConfigureAwait(continueOnCapturedContext: false);
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
