using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifxIoT.Models
{
    public class Group : NamedEntity, Interfaces.ISelector
    {
        public string GetSelectorText()
        {
            return string.Format("group_id:{1}", this.Id);
        }
    }
}
