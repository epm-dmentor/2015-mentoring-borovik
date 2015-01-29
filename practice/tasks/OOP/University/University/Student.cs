using Epam.NetMentoring.University.HumanClass;

namespace Epam.NetMentoring.University.StudentClass
{
    internal class Student : Human
    {
        private int _fid;
        private int _avscore;

        public int FacultetID
        {
            get { return _fid; }
            set { _fid = value; }
        }

        public int AvgScore
        {
            get { return _avscore; }
            set { _avscore = value; }
        }

        public Student(string argname, int argage, int argid, int argfacid, int argavgscore)
            : base(argname, argage, argid)
        {
            FacultetID = argfacid;
            AvgScore = argavgscore;
        }

        public Student()
            : base()
        {
            FacultetID = new int();
            AvgScore = new int();
        }
    }
}