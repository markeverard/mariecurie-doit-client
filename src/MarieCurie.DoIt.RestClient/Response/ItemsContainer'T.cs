using System.Collections.Generic;

namespace MarieCurie.DoIt.RestClient.Response
{
    public class ItemsContainer<T>
    {
        public List<T> Items { get; set; }
        public string Description { get; set; }
    }
}