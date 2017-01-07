using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifxIoT.Models
{
    public class Selector
    {
        public static Interfaces.ISelector All
        {
            get
            {
                return new All();
            }
        }

        public static Interfaces.ISelector CreateList(params Interfaces.ISelector[] selectors)
        {
            SelectorList returnValue = new SelectorList();

            returnValue.AddRange(selectors);

            return returnValue;
        }
    }
}
