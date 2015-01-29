using System;
using System.Collections.Generic;
using System.Reflection;
using Epam.NetMentoring.University.DataGenerator;
using Epam.NetMentoring.University.HumanClass;
using Epam.NetMentoring.University.StudentClass;

namespace Epam.NetMentoring.University
{
    class Program
    {
        private static void ToNextTask()
        {
            Console.WriteLine(Environment.NewLine + "Any key for next task");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Task1Typesreduction()
        {

            Console.WriteLine("Task 1 - Types Reduction:" + Environment.NewLine);

            var isEqual = new Human("Igor", 29, 1) == new Human("Igor", 29, 1);
            var isEqual2 = new Human("Igor", 29, 1).Equals(new Human("Igor", 29, 1));
            Console.WriteLine(isEqual);
            Console.WriteLine(isEqual2);
            Console.ReadKey();
            ToNextTask();
        }

        public static void Task2ListWithHumanType()
        {

            DataGen DG = new DataGen();
            int arrlng = DG.SomeArrayLength();

            Console.WriteLine("Task 2 - List With Human Type:" + Environment.NewLine);
            Console.WriteLine("List length will be {0}", arrlng);

            var HumanList = new List<Human>(arrlng);

            for (int i = 0; i <= arrlng - 1; i++)
            {
                if (DG.GetSomeBool())
                {
                    HumanList.Add(DG.GetSomeHuman());
                }
                else
                {
                    HumanList.Add(DG.GetSomeStudent());
                }
            }

            for (int i = 0; i <= arrlng - 1; i++)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Element[{0}] without ToString call will return {1}", i, HumanList[i]);
                Console.WriteLine("Element[{0}] with ToString call will return {1}", i, HumanList[i].ToString());
                Console.WriteLine("Element[{0}].PersonName = {1}", i, HumanList[i].PersonName);
                Console.WriteLine("Element[{0}].PersonAge = {1}", i, HumanList[i].PersonAge);
                Console.WriteLine("Element[{0}].PersonID = {1}", i, HumanList[i].PersonID);
                Console.WriteLine("Element[{0}] GetType call will return {1}", i, HumanList[i].GetType());
                Console.WriteLine("---------------------------------------");
            }


            ToNextTask();
        }

        public static void Task3ListWithObjectType()
        {

            DataGen DG = new DataGen();
            int arrlng = DG.SomeArrayLength();

            Console.WriteLine("Task 3 - List With Object Type:" + Environment.NewLine);
            Console.WriteLine("List length will be {0}", arrlng);

            var ObjectList = new List<Human>(arrlng);

            for (int i = 0; i <= arrlng - 1; i++)
            {
                if (DG.GetSomeBool())
                {
                    ObjectList.Add(DG.GetSomeHuman());
                }
                else
                {
                    ObjectList.Add(DG.GetSomeStudent());
                }
            }

            for (int i = 0; i <= arrlng - 1; i++)
            {
                Console.WriteLine("---------------------------------------");
                if (ObjectList[i].GetType().ToString() == "Epam.NetMentoring.University.StudentClass.Student")
                {
                    Console.WriteLine("Element[{0}] is Student", i);
                    Console.WriteLine("Element[{0}] Facultet ID = {1}", i, (ObjectList[i] as Student).FacultetID);
                }
                else
                {
                    Console.WriteLine("Element[{0}] is Human", i);
                }

                Console.WriteLine("Element[{0}] Person ID = {1}", i, (ObjectList[i] as Human).PersonID);

                Type ListItemType = ObjectList[i].GetType();
                var BFlages = ListItemType.GetFields(BindingFlags.Public | BindingFlags.Static);

                for (int q = 0; q < BFlages.Length; q++)
                {
                    Console.WriteLine(BFlages[q].ToString());
                }
                Console.WriteLine("---------------------------------------");
            }

            ToNextTask();
        }

        public static void Task4LetItClone()
        {
            Console.WriteLine("Task 4 - Let It Clone:" + Environment.NewLine);
            DataGen DG = new DataGen();

            Human TrueHuman = DG.GetSomeHuman();
            Human ClonedHuman = TrueHuman.Clone();

            Console.WriteLine("Human Name {0}", TrueHuman.PersonName);
            Console.WriteLine("Cloned Human Name {0}", ClonedHuman.PersonName);
            Console.WriteLine("Human Age {0}", TrueHuman.PersonAge);
            Console.WriteLine("Cloned Human Age {0}", ClonedHuman.PersonAge);

            ToNextTask();
        }
        static void Main(string[] args)
        {
            Task1Typesreduction();
            Task2ListWithHumanType();
            Task3ListWithObjectType();
            Task4LetItClone();
        }
    }
}