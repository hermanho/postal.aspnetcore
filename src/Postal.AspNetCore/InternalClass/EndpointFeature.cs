using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postal.AspNetCore.InternalClass
{
   internal sealed class EndpointFeature : IEndpointFeature
    {
        public Endpoint Endpoint { get; set; }

        public EndpointFeature(Endpoint endpoint)
        {
            Endpoint = endpoint;
        }
    }
}
