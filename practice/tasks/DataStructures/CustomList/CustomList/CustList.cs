using Epam.NetMentoring.CustomList.CustomNodeClass;

namespace Epam.NetMentoring.CustomList.CustomListClass
{
    class CustomList
    {
        private int size;
        
        private CustListNode current;
        private CustListNode top;

        public int Count
        {
            get { return size; }
        }

        public void Add(object item)
        {
            size++;
            var node = new CustListNode{ Content=item };
            if (top == null) top = node;
            else current.Next = node;
            current = node;
        }

        public CustomList()
        {
            size = 0;
            top = null;
        }

        public bool RemoveAt(int position)
        {
            if (position == 1)
            {
                top = null;
                current = null;
                return true;
            }
            if (position > 1 && position <= size)
            {
                CustListNode temps
            }
            return false;
        }
    }
}
