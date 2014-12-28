namespace MarieCurie.DoIt.RestClient.Response
{
    public class ItemsResponse<T> : DoItResponse
    {
        public ItemsContainer<T> Data { get; set; }       
    }
}