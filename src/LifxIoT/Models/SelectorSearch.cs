using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifxIoT.Models
{
    public class SelectorSearch : Interfaces.ISelector
    {
        public string SearchType { get; set; }

        public string SearchValue { get; set; }

        public string GetSelectorText()
        {
            return SearchType + ":" + SearchValue;
        }
    }
}
