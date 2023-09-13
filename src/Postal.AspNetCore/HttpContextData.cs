using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postal.AspNetCore
{
    public class HttpContextData
    {
        public Endpoint Endpoint { get; internal set; }
        public RouteValueDictionary RouteValues { get; internal set; }
    }
}
