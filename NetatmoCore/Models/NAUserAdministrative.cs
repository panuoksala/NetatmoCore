// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace netatmocore.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class NAUserAdministrative
    {
        /// <summary>
        /// Initializes a new instance of the NAUserAdministrative class.
        /// </summary>
        public NAUserAdministrative()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NAUserAdministrative class.
        /// </summary>
        /// <param name="country">user country</param>
        /// <param name="lang">user locale</param>
        /// <param name="regLocale">user regional preferences (used for
        /// displaying date)</param>
        /// <param name="unit">0 -&gt; metric system, 1 -&gt; imperial
        /// system</param>
        /// <param name="windunit">0 -&gt; kph, 1 -&gt; mph, 2 -&gt; ms, 3
        /// -&gt; beaufort, 4 -&gt; knot</param>
        /// <param name="pressureunit">0 -&gt; mbar, 1 -&gt; inHg, 2 -&gt;
        /// mmHg</param>
        /// <param name="feelLikeAlgo">algorithm used to compute feel like
        /// temperature, 0 -&gt; humidex, 1 -&gt; heat-index</param>
        public NAUserAdministrative(string country = default(string), string lang = default(string), string regLocale = default(string), string unit = default(string), string windunit = default(string), string pressureunit = default(string), string feelLikeAlgo = default(string))
        {
            Country = country;
            Lang = lang;
            RegLocale = regLocale;
            Unit = unit;
            Windunit = windunit;
            Pressureunit = pressureunit;
            FeelLikeAlgo = feelLikeAlgo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets user country
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets user locale
        /// </summary>
        [JsonProperty(PropertyName = "lang")]
        public string Lang { get; set; }

        /// <summary>
        /// Gets or sets user regional preferences (used for displaying date)
        /// </summary>
        [JsonProperty(PropertyName = "reg_locale")]
        public string RegLocale { get; set; }

        /// <summary>
        /// Gets or sets 0 -&amp;gt; metric system, 1 -&amp;gt; imperial system
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or sets 0 -&amp;gt; kph, 1 -&amp;gt; mph, 2 -&amp;gt; ms, 3
        /// -&amp;gt; beaufort, 4 -&amp;gt; knot
        /// </summary>
        [JsonProperty(PropertyName = "windunit")]
        public string Windunit { get; set; }

        /// <summary>
        /// Gets or sets 0 -&amp;gt; mbar, 1 -&amp;gt; inHg, 2 -&amp;gt; mmHg
        /// </summary>
        [JsonProperty(PropertyName = "pressureunit")]
        public string Pressureunit { get; set; }

        /// <summary>
        /// Gets or sets algorithm used to compute feel like temperature, 0
        /// -&amp;gt; humidex, 1 -&amp;gt; heat-index
        /// </summary>
        [JsonProperty(PropertyName = "feel_like_algo")]
        public string FeelLikeAlgo { get; set; }

    }
}
