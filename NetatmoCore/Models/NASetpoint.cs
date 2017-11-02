// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace netatmocore.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class NASetpoint
    {
        /// <summary>
        /// Initializes a new instance of the NASetpoint class.
        /// </summary>
        public NASetpoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NASetpoint class.
        /// </summary>
        public NASetpoint(double? setpointTemp = default(double?), int? setpointEndtime = default(int?), string setpointMode = default(string))
        {
            SetpointTemp = setpointTemp;
            SetpointEndtime = setpointEndtime;
            SetpointMode = setpointMode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "setpoint_temp")]
        public double? SetpointTemp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "setpoint_endtime")]
        public int? SetpointEndtime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "setpoint_mode")]
        public string SetpointMode { get; set; }

    }
}