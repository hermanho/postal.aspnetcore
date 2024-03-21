using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Text;

namespace Postal.AspNetCore
{
    public interface IViewData
    {
        Dictionary<string, object> ViewData { get; set; }
        RequestPath RequestPath { get; set; }
    }
}
