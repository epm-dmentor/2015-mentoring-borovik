
namespace Epam.NetMentoring.HashTable.WordDef
{
    public class WordDefinition
    {
        public string Definition { get; set; }
        public string Word { get; set; }
        public string Description { get; set; }
        public WordDefinition Next { get; set; }
    }
}
