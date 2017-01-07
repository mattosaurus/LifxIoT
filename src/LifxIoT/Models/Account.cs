using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LifxIoT.Models
{
    public class Account
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "uuid")]
        public Guid Uuid { get; set; } = Guid.Empty;

        public override string ToString()
        {
            return this.Uuid.ToString();
        }
    }
}
