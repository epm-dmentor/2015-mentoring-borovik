
namespace Epam.NetMentoring.HashTable.WordTypeClass
{
    public class WordType
    {
        public string Description { get; set; }

        public override int GetHashCode()
        {
            return Description.GetHashCode();
        }
    }
}
