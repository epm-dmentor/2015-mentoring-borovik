using Epam.NetMentoring.Practice.Tasks.DataStructures.LinkedList.LinkedListTask.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Epam.NetMentoring.Practice.Tasks.DataStructures.LinkedList.LinkedListTask.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new LinkedList.LinkedList("Some Random Text", 8, '%', 2345, null, 22);
            Assert.IsTrue(test.InsertAt(0, 12345));
            Assert.AreEqual(test.GetElementAt(0), 12345);
            Assert.AreEqual(test.Count, 7);
            Assert.IsTrue(test.InsertAt(3, "New"));
            Assert.IsFalse(test.InsertAt(99, "Fake"));
            Assert.AreEqual(test.GetElementAt(3), "New");
            Assert.IsTrue(test.RemoveFrom(1));
            Assert.AreNotEqual(test.GetElementAt(4), 8);
            Assert.IsFalse(test.Remove("Delete"));
            Assert.IsTrue(test.Remove(22));
            Assert.IsTrue(test.InsertAt(0, null));
            Assert.IsTrue(test.Remove(null));
            Assert.AreNotEqual(test.GetElementAt(0), null);
        }
    }
}
