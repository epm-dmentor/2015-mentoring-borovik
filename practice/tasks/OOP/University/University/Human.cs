using System;

namespace Epam.NetMentoring.University.HumanClass
{
    internal class Human
    {
        private String _name;
        private int _age;
        private int _id;

        public string PersonName
        {
            get { return _name; }
            set { _name = value; }
        }

        public int PersonAge
        {
            get { return _age; }
            set { _age = value; }
        }

        public int PersonID
        {
            get { return _id; }
            set { _id = value; }
        }

        public Human(string argname, int argage, int argid)
        {
            PersonName = argname;
            PersonAge = argage;
            PersonID = argid;
        }

        public Human()
        {
            PersonName = String.Empty;
            PersonAge = new int();
            PersonID = new int();
        }

        public Human Clone()
        {
            return (Human)MemberwiseClone();
        }

        public bool Compare(Object _argObject)
        {
            return this.Equals(_argObject);
        }
    }
}