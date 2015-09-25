namespace Smugmug.InternalModels
{
    using Newtonsoft.Json;

    internal class TimingMeasurement
    {
        [JsonProperty("time")]
        public double Time { get; set; }

        [JsonProperty("cycles")]
        public int Cycles { get; set; }

        [JsonProperty("objects")]
        public int Objects { get; set; }
    }
}