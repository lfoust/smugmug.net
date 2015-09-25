namespace Smugmug.InternalModels
{
    using Newtonsoft.Json;

    internal class PathSegment
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("param_name")]
        public string ParamName { get; set; }

        [JsonProperty("param_value")]
        public string ParamValue { get; set; }
    }
}