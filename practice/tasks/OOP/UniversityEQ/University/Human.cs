using System;

namespace Epam.NetMentoring.University.HumanClass
{
    internal class Human : IEquatable<Human>
    {
        private String _name;
        private int _age;
        private int _id;

        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Human p = obj as Human;
            if ((System.Object)p == null)
            {
                return false;
            }

            return (_name == p._name) && (_age == p._age) && (_id == p._id);
        }

        public bool Equals(Human p)
        {
            if (p == null)
            {
                return false;
            }

            return (_name == p._name) && (_age == p._age) && (_id == p._id);
        }


        public static bool operator ==(Human q, Human w)
        {
            if (System.Object.ReferenceEquals(q, w))
            {
                return true;
            }

            if (((object)q == null) || ((object)w == null))
            {
                return false;
            }

            return q._name == w._name && q._age == w._age && q._id == w._id;
        }

        public static bool operator !=(Human q, Human w)
        {
            return !(q == w);
        }


        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override string ToString()
        {
            string s = "Name: " + _name + " | Age: " + _age + " | ID: " + _id;
            return s;
        }


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