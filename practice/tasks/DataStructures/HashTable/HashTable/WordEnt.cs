using Epam.NetMentoring.HashTable.WordTypeClass;

namespace Epam.NetMentoring.HashTable.WordEnt
{
    public class WordEntity
    {
        public string Word { get; set; }
        public WordType Type { get; set; }

        public override int GetHashCode()
        {
            return Word.GetHashCode() ^ Type.GetHashCode();
        }

    }
}
