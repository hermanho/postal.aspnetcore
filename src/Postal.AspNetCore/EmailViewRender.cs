using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.Extensions.Options;
using Postal.AspNetCore;

namespace Postal
{
    /// <summary>
    /// Renders <see cref="Email"/> view's into raw strings using the MVC ViewEngine infrastructure.
    /// </summary>
    public class EmailViewRender : IEmailViewRender
    {
        /// <summary>
        /// Creates a new <see cref="EmailViewRender"/> that uses the given view engines.
        /// </summary>
        /// <param name="viewEngines">The view engines to use when rendering email views.</param>
        public EmailViewRender(
            ITemplateService templateService,
            IOptions<EmailServiceOptions> options
            )
        {
            _templateService = templateService;
            _emailViewDirectoryName = options?.Value?.EmailViewsDirectory ?? "Emails";
        }

        readonly ITemplateService _templateService;

        /// <summary>
        /// The name of the directory in "Views" that contains the email views.
        /// By default, this is "Emails".
        /// </summary>
        private string _emailViewDirectoryName;

        /// <summary>
        /// Renders an email view.
        /// </summary>
        /// <param name="email">The email to render.</param>
        /// <returns>The rendered email view output.</returns>
        public virtual Task<string> RenderAsync(Email email)
        {
            var imageEmbedder = new ImageEmbedder();
            return RenderAsync(email, null, imageEmbedder);
        }

        /// <summary>
        /// Renders an email view.
        /// </summary>
        /// <param name="email">The email to render.</param>
        /// <param name="viewName">Optional email view name override. If null then the email's ViewName property is used instead.</param>
        /// <returns>The rendered email view output.</returns>
        public virtual Task<string> RenderAsync(Email email, string? viewName)
        {
            var imageEmbedder = new ImageEmbedder();
            return RenderAsync(email, viewName, imageEmbedder);
        }

        /// <summary>
        /// Renders an email view.
        /// </summary>
        /// <param name="email">The email to render.</param>
        /// <param name="viewName">Optional email view name override. If null then the email's ViewName property is used instead.</param>
        /// <param name="imageEmbedder">Optional ImageEmbedder. If null then the email cannot be generated with Image.</param>
        /// <returns>The rendered email view output.</returns>
        public virtual async Task<string> RenderAsync(Email email, string? viewName = null, ImageEmbedder? imageEmbedder = null)
        {
            viewName = viewName ?? email.ViewName;

            var routeData = new Microsoft.AspNetCore.Routing.RouteData();
            routeData.Values["controller"] = _emailViewDirectoryName;
            routeData.Values["page"] = _emailViewDirectoryName;
            if (!string.IsNullOrWhiteSpace(email.AreaName))
            {
                routeData.Values["area"] = email.AreaName;
                routeData.DataTokens["area"] = email.AreaName;
            }

            Dictionary<string, object?> viewData = new Dictionary<string, object?>();
            viewData[ImageEmbedder.ViewDataKey] = imageEmbedder;
            var viewOutput = await _templateService.RenderTemplateAsync(routeData, viewName, email, viewData, true);
            viewData.Remove(ImageEmbedder.ViewDataKey);
            return viewOutput;
        }
    }
}
