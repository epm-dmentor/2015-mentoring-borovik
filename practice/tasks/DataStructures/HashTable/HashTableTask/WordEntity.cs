namespace Epam.NetMentoring.HashTableTask
{
    public class WordEntity
    {
        public string Word { get; set; }
        public WordTypes Type { get; set; }

        public override int GetHashCode()
        {
            return Word.GetHashCode() ^ Type.GetHashCode();
        }
    }
}