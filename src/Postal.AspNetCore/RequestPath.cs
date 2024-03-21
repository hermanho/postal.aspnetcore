using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Postal
{
    public class RequestPath
    {
        public string Path { get; set; } = string.Empty;
        public string PathBase { get; set; } = string.Empty;
        public string Host { get; set; } = string.Empty;
        public bool IsHttps { get; set; } = true;
        public string Scheme { get; set; } = string.Empty;
        public string Method { get; set; } = string.Empty;
    }
}
