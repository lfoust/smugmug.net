namespace Smugmug.InternalModels
{
    using System.Collections.Generic;

    internal class Options
    {
        internal Options()
        {
            this.MediaTypes = new List<string>();
            this.Output = new List<OutputField>();
            this.ResponseLevels = new List<string>();
            this.Path = new List<PathSegment>();
        }

        public IEnumerable<string> MediaTypes { get; set; }

        public IEnumerable<OutputField> Output { get; set; }

        public IEnumerable<string> ResponseLevels { get; set; }

        public IEnumerable<PathSegment> Path { get; set; }
    }
}