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

    public partial class NAThermStateBody
    {
        /// <summary>
        /// Initializes a new instance of the NAThermStateBody class.
        /// </summary>
        public NAThermStateBody()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NAThermStateBody class.
        /// </summary>
        public NAThermStateBody(NASetpoint setpoint = default(NASetpoint), NASetpoint setpointOrder = default(NASetpoint), NAThermProgram thermProgram = default(NAThermProgram), IList<NAThermProgram> thermProgramBackup = default(IList<NAThermProgram>), NAThermProgram thermProgramOrder = default(NAThermProgram), int? thermOrientation = default(int?), int? thermRelayCmd = default(int?), int? batteryVp = default(int?), int? rfStatus = default(int?), int? plugConnectedBoiler = default(int?), bool? udpConn = default(bool?), int? lastThermSeen = default(int?), int? lastPlugSeen = default(int?), int? wifiStatus = default(int?), NAThermMeasure measured = default(NAThermMeasure))
        {
            Setpoint = setpoint;
            SetpointOrder = setpointOrder;
            ThermProgram = thermProgram;
            ThermProgramBackup = thermProgramBackup;
            ThermProgramOrder = thermProgramOrder;
            ThermOrientation = thermOrientation;
            ThermRelayCmd = thermRelayCmd;
            BatteryVp = batteryVp;
            RfStatus = rfStatus;
            PlugConnectedBoiler = plugConnectedBoiler;
            UdpConn = udpConn;
            LastThermSeen = lastThermSeen;
            LastPlugSeen = lastPlugSeen;
            WifiStatus = wifiStatus;
            Measured = measured;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "setpoint")]
        public NASetpoint Setpoint { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "setpoint_order")]
        public NASetpoint SetpointOrder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "therm_program")]
        public NAThermProgram ThermProgram { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "therm_program_backup")]
        public IList<NAThermProgram> ThermProgramBackup { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "therm_program_order")]
        public NAThermProgram ThermProgramOrder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "therm_orientation")]
        public int? ThermOrientation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "therm_relay_cmd")]
        public int? ThermRelayCmd { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "battery_vp")]
        public int? BatteryVp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rf_status")]
        public int? RfStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "plug_connected_boiler")]
        public int? PlugConnectedBoiler { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "udp_conn")]
        public bool? UdpConn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "last_therm_seen")]
        public int? LastThermSeen { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "last_plug_seen")]
        public int? LastPlugSeen { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "wifi_status")]
        public int? WifiStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "measured")]
        public NAThermMeasure Measured { get; set; }

    }
}