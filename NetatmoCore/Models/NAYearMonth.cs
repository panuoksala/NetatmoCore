// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace netatmocore.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class NAYearMonth
    {
        /// <summary>
        /// Initializes a new instance of the NAYearMonth class.
        /// </summary>
        public NAYearMonth()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NAYearMonth class.
        /// </summary>
        public NAYearMonth(int? y = default(int?), int? m = default(int?))
        {
            Y = y;
            M = m;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "y")]
        public int? Y { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "m")]
        public int? M { get; set; }

    }
}
