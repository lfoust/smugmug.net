namespace Smugmug.InternalModels
{
    internal class SmugmugResponse
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public Request Request { get; set; }
        public Options Options { get; set; }
        public Response Response { get; set; }
    }
}