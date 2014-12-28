namespace MarieCurie.DoIt.RestClient.Response
{
    public class Meta
    {
        public string code { get; set; }
        public int page { get; set; }
        public int items_per_page { get; set; }
        public int total_items { get; set; }
        public int total_pages { get; set; }   
    }
}