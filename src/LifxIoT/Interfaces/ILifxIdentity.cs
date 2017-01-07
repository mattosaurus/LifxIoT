using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace LifxIoT.Interfaces
{
    public interface ILifxIdentity
    {
        AuthenticationHeaderValue Authentication { get; set; }
        Uri BaseUri { get; }
        string Token { get; set; }
    }
}
