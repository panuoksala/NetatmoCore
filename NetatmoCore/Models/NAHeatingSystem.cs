// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace netatmocore.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class NAHeatingSystem
    {
        /// <summary>
        /// Initializes a new instance of the NAHeatingSystem class.
        /// </summary>
        public NAHeatingSystem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NAHeatingSystem class.
        /// </summary>
        public NAHeatingSystem(string heatingEnergy = default(string), bool? heatingSystemWindowSeen = default(bool?))
        {
            HeatingEnergy = heatingEnergy;
            HeatingSystemWindowSeen = heatingSystemWindowSeen;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "heating_energy")]
        public string HeatingEnergy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "heating_system_window_seen")]
        public bool? HeatingSystemWindowSeen { get; set; }

    }
}
