namespace Smugmug.InternalModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    internal class OutputField
    {
        internal OutputField()
        {
            this.Options = new List<string>();
        }

        public string Name { get; set; }
        public string Type { get; set; }

        [JsonProperty("OPTIONS")]
        public IEnumerable<string> Options { get; set; }

        [JsonProperty("MIN_COUNT")]
        public int MinCount { get; set; }

        [JsonProperty("MAX_COUNT")]
        public int MaxCount { get; set; }

        [JsonProperty("MIN_CHARS")]
        public int MinChars { get; set; }

        [JsonProperty("MAX_CHARS")]
        public string MaxChars { get; set; }

        [JsonProperty("MIN_VALUE")]
        public int MinValue { get; set; }

        [JsonProperty("MAX_VALUE")]
        public int MaxValue { get; set; }
    }
}