using Epam.NetMentoring.HashTable.HashTableClass;
using Epam.NetMentoring.HashTable.WordEnt;
using Epam.NetMentoring.HashTable.WordTypeClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Epam.NetMentoring.HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var hash = new MyHashTable().;
            var word = new WordEntity { Word = "Soxx", Type = new WordType { Description = "Szza" } };
            var changed = new WordEntity { Word = "Essaaa", Type = new WordType { Description = "qwertyu" } };
            hash.AddItem(word, "Just a rubbish string");
            hash.AddItem(new WordEntity { Word = "Laarr3333dd", Type = new WordType { Description = "So" } }, "random");
            hash.AddItem(changed, "QWERTY");
            hash.AddItem(new WordEntity { Word = "IDDQD", Type = new WordType { Description = "Doom" } }, "Immortality code in DOOM PC game");
            hash.AddItem(new WordEntity { Word = "IDDQD", Type = new WordType { Description = "Doom" } }, "Immortality code in DOOM PC game");
            Assert.IsTrue(hash.IfExist("QWERTY"));
            Assert.IsFalse(hash.IfExist("Kirill"));
            Assert.AreEqual(hash[word], "Just a rubbish string");
            Assert.AreNotEqual(hash[word], "hohoho");
            hash[changed] = "Yet another one QWERTY";
            Assert.AreEqual(hash[changed], "Yet another one QWERTY");
        }
    }
}
