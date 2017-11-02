// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace netatmocore.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class NAWelcomeCamera
    {
        /// <summary>
        /// Initializes a new instance of the NAWelcomeCamera class.
        /// </summary>
        public NAWelcomeCamera()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NAWelcomeCamera class.
        /// </summary>
        /// <param name="id">Id of the camera</param>
        /// <param name="type">Type of the camera</param>
        /// <param name="status">If camera is monitoring (on/off)</param>
        /// <param name="vpnUrl">Only for scope access_camera. Address of the
        /// camera</param>
        /// <param name="isLocal">Only for scope access_camera. If Camera and
        /// application requesting the information are on the same IP
        /// (true/false)</param>
        /// <param name="sdStatus">If SD card status is ok (on/off)</param>
        /// <param name="alimStatus">If power supply is ok (on/off)</param>
        /// <param name="name">Name of the camera</param>
        public NAWelcomeCamera(string id = default(string), string type = default(string), string status = default(string), string vpnUrl = default(string), bool? isLocal = default(bool?), string sdStatus = default(string), string alimStatus = default(string), string name = default(string))
        {
            Id = id;
            Type = type;
            Status = status;
            VpnUrl = vpnUrl;
            IsLocal = isLocal;
            SdStatus = sdStatus;
            AlimStatus = alimStatus;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of the camera
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets type of the camera
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets if camera is monitoring (on/off)
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets only for scope access_camera. Address of the camera
        /// </summary>
        [JsonProperty(PropertyName = "vpn_url")]
        public string VpnUrl { get; set; }

        /// <summary>
        /// Gets or sets only for scope access_camera. If Camera and
        /// application requesting the information are on the same IP
        /// (true/false)
        /// </summary>
        [JsonProperty(PropertyName = "is_local")]
        public bool? IsLocal { get; set; }

        /// <summary>
        /// Gets or sets if SD card status is ok (on/off)
        /// </summary>
        [JsonProperty(PropertyName = "sd_status")]
        public string SdStatus { get; set; }

        /// <summary>
        /// Gets or sets if power supply is ok (on/off)
        /// </summary>
        [JsonProperty(PropertyName = "alim_status")]
        public string AlimStatus { get; set; }

        /// <summary>
        /// Gets or sets name of the camera
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}