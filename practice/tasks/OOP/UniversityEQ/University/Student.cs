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

        public override bool Equals(System.Object obj)
        {
            Student p = obj as Student;
            return base.Equals(p) && _avscore == p._avscore && _fid == p._fid;
        }


        public static bool operator ==(Student q, Student w)
        {
            if (System.Object.ReferenceEquals(q, w))
            {
                return true;
            }

            if (((object)q == null) || ((object)w == null))
            {
                return false;
            }

            return q.Equals(w);
        }

        public static bool operator !=(Student q, Student w)
        {
            return !(q == w);
        }


        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override string ToString()
        {
            string s = base.ToString() + " | Facultet: " + _fid + " | AvgScore: " + _avscore;
            return s;
        }
    }
}