using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifxIoT.Models
{
    public class SelectorList : List<Interfaces.ISelector>, Interfaces.ISelector
    {
        public string GetSelectorText()
        {
            return String.Join(",", this.Select(t => t.GetSelectorText()).ToArray());
        }
    }
}
