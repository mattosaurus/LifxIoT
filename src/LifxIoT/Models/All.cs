using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifxIoT.Models
{
    public class All : Interfaces.ISelector
    {
        public string GetSelectorText()
        {
            return "all";
        }
    }
}
