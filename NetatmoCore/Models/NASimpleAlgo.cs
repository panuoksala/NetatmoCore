// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace netatmocore.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class NASimpleAlgo
    {
        /// <summary>
        /// Initializes a new instance of the NASimpleAlgo class.
        /// </summary>
        public NASimpleAlgo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NASimpleAlgo class.
        /// </summary>
        public NASimpleAlgo(int? highDeadband = default(int?))
        {
            HighDeadband = highDeadband;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "high_deadband")]
        public int? HighDeadband { get; set; }

    }
}