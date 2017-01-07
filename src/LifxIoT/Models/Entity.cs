using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifxIoT.Models
{
    public abstract class Entity : Interfaces.IEntity
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "id")]
        public virtual string Id { get; set; }

        public override string ToString()
        {
            return this.Id;
        }
    }
}
