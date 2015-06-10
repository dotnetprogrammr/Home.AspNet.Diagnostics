
namespace Home.AspNet.Builder
{
    using System;

    /// <summary>
    /// Options for the HttpProblemMiddleware.
    /// </summary>
    public class HttpProblemOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpProblemOptions"/> class using the specified base URI.
        /// </summary>
        /// <param name="baseUriString">A <see cref="string"/> representation of a URI that identifies the host of the problem pages.</param>
        public HttpProblemOptions(string baseUriString)
        {
            if (string.IsNullOrWhiteSpace(baseUriString))
            {
                throw new ArgumentException(nameof(baseUriString));
            }

            this.BaseUriString = baseUriString;
        }

        /// <summary>
        /// Gets or sets a <see cref="string"/> representation of the URI at which the problem pages are accessible.
        /// </summary>
        public string BaseUriString { get; set; }
    }
}