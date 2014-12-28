namespace MarieCurie.DoIt.RestClient.Request
{
    public class AuthenticatedRequest<T>
    {
        public T Request { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } 
    }
}