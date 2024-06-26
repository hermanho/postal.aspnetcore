using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.IO;
using System.Net.Mime;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;
using System.Runtime.Serialization;

namespace Postal
{
    /// <summary>
    /// Used by the <see cref="HtmlExtensions.EmbedImageAsync"/> helper method.
    /// It generates the <see cref="LinkedResource"/> objects need to embed images into an email.
    /// </summary>
    public class ImageEmbedder
    {
        internal static string ViewDataKey = "Postal.ImageEmbedder";

        /// <summary>
        /// Creates a new <see cref="ImageEmbedder"/>.
        /// </summary>
        public ImageEmbedder()
        {
            createLinkedResourceAsync = CreateLinkedResourceAsync;
        }

        /// <summary>
        /// Creates a new <see cref="ImageEmbedder"/>.
        /// </summary>
        /// <param name="createLinkedResourceAsync">A delegate that creates a <see cref="LinkedResource"/> from an image path or URL.</param>
        public ImageEmbedder(Func<string, Task<LinkedResource>> createLinkedResourceAsync)
        {
            this.createLinkedResourceAsync = createLinkedResourceAsync;
        }

        readonly Func<string, Task<LinkedResource>> createLinkedResourceAsync;
        readonly Dictionary<string, LinkedResource> images = new Dictionary<string, LinkedResource>();

        /// <summary>
        /// Gets if any images have been referenced.
        /// </summary>
        public bool HasImages
        {
            get { return images.Count > 0; }
        }

        /// <summary>
        /// Creates a <see cref="LinkedResource"/> from an image path or URL.
        /// </summary>
        /// <param name="imagePathOrUrl">The image path or URL.</param>
        /// <returns>A new <see cref="LinkedResource"/></returns>
        public static async Task<LinkedResource> CreateLinkedResourceAsync(string imagePathOrUrl)
        {
            if (Uri.IsWellFormedUriString(imagePathOrUrl, UriKind.Absolute))
            {
                byte[] bytes = Array.Empty<byte>();
                using (HttpClient client = new HttpClient())
                {
                    using HttpResponseMessage response = await client.GetAsync(imagePathOrUrl);
                    using HttpContent content = response.Content;
                    bytes = await content.ReadAsByteArrayAsync();
                }
                return new LinkedResource(new MemoryStream(bytes));
            }
            else
            {
                return new LinkedResource(File.OpenRead(imagePathOrUrl));
            }
        }

        /// <summary>
        /// Records a reference to the given image.
        /// </summary>
        /// <param name="imagePathOrUrl">The image path or URL.</param>
        /// <param name="contentType">The content type of the image e.g. "image/png". If null, then content type is determined from the file name extension.</param>
        /// <returns>A <see cref="LinkedResource"/> representing the embedded image.</returns>
        public async Task<LinkedResource> ReferenceImageAsync(string imagePathOrUrl, string? contentType = null)
        {
            LinkedResource? resource;
            if (images.TryGetValue(imagePathOrUrl, out resource)) return resource;

            resource = await createLinkedResourceAsync(imagePathOrUrl);

            contentType = contentType ?? DetermineContentType(imagePathOrUrl);
            if (contentType != null)
            {
                resource.ContentType = new ContentType(contentType);
            }

            images[imagePathOrUrl] = resource;
            return resource;
        }

        string? DetermineContentType(string pathOrUrl)
        {
            if (pathOrUrl == null) throw new ArgumentNullException(nameof(pathOrUrl));

            var extension = Path.GetExtension(pathOrUrl).ToLowerInvariant();
            switch (extension)
            {
                case ".png":
                    return "image/png";
                case ".jpeg":
                case ".jpg":
                    return "image/jpeg";
                case ".gif":
                    return "image/gif";
                default:
                    return null;
            }
        }

        /// <summary>
        /// Adds recorded <see cref="LinkedResource"/> image references to the given <see cref="AlternateView"/>.
        /// </summary>
        public void AddImagesToView(AlternateView view)
        {
            foreach (var image in images)
            {
                view.LinkedResources.Add(image.Value);
            }
        }

    }
}
