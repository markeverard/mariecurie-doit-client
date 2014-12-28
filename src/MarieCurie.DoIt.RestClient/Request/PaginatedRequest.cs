namespace MarieCurie.DoIt.RestClient.Request
{
    public abstract class PaginatedRequest
    {
        protected PaginatedRequest()
        {
            Page = 1;
        }

        public int Page { get; set; } 
    }
}