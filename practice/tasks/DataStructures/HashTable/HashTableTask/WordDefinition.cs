namespace Epam.NetMentoring.HashTableTask
{
    public class WordDefinition
    {
        public string Definition { get; set; }
        public string Word { get; set; }
        public WordDefinition Next { get; set; }
    }
}