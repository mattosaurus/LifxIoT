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
    public class ValidateColor : ApiMethod<Color>
    {
        public ValidateColor(ILifxIdentity identity)
            : base(identity, "color?string={0}")
        {
        }

        public async Task<Color> Get(string colorText)
        {
            return await this.Execute(colorText).ConfigureAwait(continueOnCapturedContext: false);
        }

        protected async override Task<Color> OnExecuted(HttpResponseMessage response)
        {
            Color returnValue = null;

            string json = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
            returnValue = JsonConvert.DeserializeObject<Color>(json);

            return returnValue;
        }
    }
}
