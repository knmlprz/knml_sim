using Newtonsoft.Json;

namespace ROSBridge.KalmanInterfaces
{
    public struct WheelState
    {
        [JsonIgnore]
        public static readonly string ROSMessageType = "knml_interfaces/msg/WheelState";

        [JsonProperty("velocity")]
        public float Velocity { get; set; }

        [JsonProperty("angle")]
        public float Angle { get; set; }
    }
}
