// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace netatmocore.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class NAThermostatDataBody
    {
        /// <summary>
        /// Initializes a new instance of the NAThermostatDataBody class.
        /// </summary>
        public NAThermostatDataBody()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NAThermostatDataBody class.
        /// </summary>
        public NAThermostatDataBody(IList<NAPlug> devices = default(IList<NAPlug>), NAUser user = default(NAUser))
        {
            Devices = devices;
            User = user;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "devices")]
        public IList<NAPlug> Devices { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public NAUser User { get; set; }

    }
}
