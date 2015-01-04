namespace MarieCurie.DoIt.RestClient.Request
{
    public abstract class LocationSearchRequestBase
    {
        public int Page { get; set; }
        public int Limit { get; set; }
    }
}