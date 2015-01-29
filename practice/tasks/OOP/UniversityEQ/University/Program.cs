using System;
using System.Collections.Generic;
using System.Reflection;
using Epam.NetMentoring.University.DataGenerator;
using Epam.NetMentoring.University.HumanClass;
using Epam.NetMentoring.University.StudentClass;

namespace Epam.NetMentoring.UniversityEQ
{
    class Program
    {
        static void Main(string[] args)
        {
            DataGen DG = new DataGen();
            int arrlng = DG.SomeArrayLength();

            Console.WriteLine("List length will be {0}", arrlng);

            var ObjectList = new List<Object>(arrlng);

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
                Console.WriteLine("Element[{0}].ToString() = {1}", i, ObjectList[i].ToString());
                Console.WriteLine("Element[{0}] = {1}", i, ObjectList[i]);
                Console.WriteLine("Element[{0}].GetType() = {1}", i, ObjectList[i].GetType());
                Console.WriteLine("Element[{0}].GetType().Name = {1}", i, ObjectList[i].GetType().Name);
            }

            Console.ReadKey();
        }
    }
}