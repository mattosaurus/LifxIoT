using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifxIoT.Models
{
    public class Light : Entity, Interfaces.ISelector
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "uuid")]
        public Guid Uuid { get; set; } = Guid.Empty;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "label")]
        public string Label { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "connected")]
        public bool Connected { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "power")]
        public string Power { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "color")]
        public Color Color { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "brightness")]
        public double Brightness { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "group")]
        public Group Group { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "location")]
        public Location Location { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "product")]
        public Product Product { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "last_seen")]
        public DateTime LastSeen { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "seconds_since_seen")]
        public double SecondsSinceSeen { get; set; }

        public override string ToString()
        {
            return this.Label;
        }

        public string GetSelectorText()
        {
            return string.Format("id:{0}", this.Id);
        }
    }
}
