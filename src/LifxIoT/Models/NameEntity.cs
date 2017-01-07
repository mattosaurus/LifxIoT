using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifxIoT.Models
{
    public abstract class NamedEntity : Entity
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "name")]
        public virtual string Name { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
