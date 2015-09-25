namespace Smugmug.InternalModels
{
    internal class Response
    {
        public string Uri { get; set; }
        public string UriDescription { get; set; }
        public string EndpointType { get; set; }
        public string Locator { get; set; }
        public string LocatorType { get; set; }
        public string ResponseLevel { get; set; }
        public string DocUri { get; set; }
        public Timing Timing { get; set; }
    }
}