using System;

namespace Epam.NetMentoring.HashTableTask
{
    internal class Program
    {
        private static void Main()
        {
            var hash = new HashTable();
            hash.AddItem(new WordEntity { Word = "Yet", Type = WordTypes.Conjunction }, "Used for saying that something could be true or could still happen in the future");
            hash.AddItem(new WordEntity { Word = "Yet", Type = WordTypes.Conjunction }, "Used for saying that something could be true or could still happen in the future");
            hash.AddItem(new WordEntity { Word = "Yet", Type = WordTypes.Adverb }, "Used for talking or asking about something that has not happened or is not true at a particular time but will probably happen or be true in the future");
            hash.AddItem(new WordEntity { Word = "Something" }, "Used for test purposes");
            hash[new WordEntity {Word = "Something"}] = "Basic description change test";
            Console.ReadKey();
        }
    }
}