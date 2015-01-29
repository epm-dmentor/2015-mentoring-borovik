using System;
using Epam.NetMentoring.University.HumanClass;
using Epam.NetMentoring.University.StudentClass;

namespace Epam.NetMentoring.University.DataGenerator
{
    internal class DataGen
    {
        private string[] _fname = { "Andrew", "Stephen", "Kumar", "Stepan", "Valdis", "His Majesty", "Batman", "Namless" };
        private string[] _lname = { "Trump", "Sharma", "Zaz", "Wolf", "Madman", "Lars", "Ivanov", "de-Bour" };
        private Random _random;


        public DataGen()
        {
            _random = new Random();
        }

        public string SomeFName()
        {

            int arrlng = _fname.Length;
            return _fname[ReturnRandomNumber(arrlng)];
        }

        public string SomeLName()
        {
            int arrlng = _lname.Length;
            return _lname[ReturnRandomNumber(arrlng)];
        }

        public int SomeAge()
        {
            return ReturnRandomNumber(1, 100);
        }

        public int SomeID()
        {
            return ReturnRandomNumber(9000, 9999);
        }

        public int SomeArrayLength()
        {
            return ReturnRandomNumber(3, 7);
        }

        public int SomeFacID()
        {
            return ReturnRandomNumber(7000, 7999);
        }

        public int SomeAVGScore()
        {
            return ReturnRandomNumber(150);
        }

        private int ReturnRandomNumber(int argmaxitem)
        {

            return _random.Next(argmaxitem);
        }

        private int ReturnRandomNumber(int argminitem, int argmaxitem)
        {
            return _random.Next(argminitem, argmaxitem);
        }

        public Human GetSomeHuman()
        {
            Human TrueHuman = new Human(SomeFName() + " " + SomeLName(), SomeAge(), SomeID());
            return TrueHuman;
        }

        public Student GetSomeStudent()
        {
            Student TrueStudent = new Student(SomeFName() + " " + SomeLName(), SomeAge(), SomeID(), SomeFacID(), SomeAVGScore());
            return TrueStudent;
        }

        public Boolean GetSomeBool()
        {
            int val = _random.Next(100);
            return (val < 20);
        }

    }
}