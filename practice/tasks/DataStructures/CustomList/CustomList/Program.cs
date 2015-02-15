using Epam.NetMentoring.CustomList.LinkedListClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Epam.NetMentoring.CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new LinkedList("Some Random Text", 8, '%', 2345, null, 22);
            Assert.AreEqual(test.Count, 6);
            Assert.IsTrue(test.InsertAt(3, "New"));
            Assert.IsFalse(test.InsertAt(99, "Fake"));
            Assert.AreEqual(test.ElementAt(3), "New");
            Assert.IsTrue(test.RemoveAt(1));
            Assert.AreNotEqual(test.ElementAt(1), 8);
            Assert.IsFalse(test.Remove("Delete"));
            Assert.IsTrue(test.Remove(22));
            Assert.IsTrue(test.InsertAt(0, null));
            Assert.IsTrue(test.Remove(null));
        }
    }
}
