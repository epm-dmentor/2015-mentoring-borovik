using Epam.NetMentoring.CustomList.LinkedNodeClass;

namespace Epam.NetMentoring.CustomList.LinkedListClass
{
    internal class LinkedList
    {
        private int size;
        private Node firstElement;

        public int Count
        {
            get
            {
                return size;
            }
        }
        public LinkedList(params object[] args)
        {
            foreach (object element in args)
            {
                Add(element);
            }
        }

        public void Add(object item)
        {
            Node node = new Node { Content = item };

            if (firstElement == null)
            {
                firstElement = node;
            }
            else
            {
                Node temp = firstElement;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            size++;
        }


        public bool InsertAt(int index, object item)
        {
            var temp = firstElement;
            if (index > 0 && index <= size - 1)
            {
                for (int q = 0; q <= size - 1; q++)
                {
                    if (q == index - 1)
                    {
                        temp.Next = new Node { Content = item, Next = temp.Next };
                        size++;
                        return true;
                    }
                    temp = temp.Next;
                }

            }
            else if (index == 0)
            {
                temp = new Node { Content = item, Next = temp };
                size++;
                return true;
            }

            return false;
        }

        public bool RemoveAt(int index)
        {
            if (index > 0 && index <= size - 1)
            {

                Node current = firstElement;
                Node previous = new Node();
                for (int q = 0; q <= size - 1; q++)
                {
                    if (q == index)
                    {
                        previous.Next = current.Next;
                        size--;
                        return true;
                    }
                    previous = current;
                    current = current.Next;
                }
            }
            else if (index == 0)
            {
                firstElement = firstElement.Next;
                size--;
            }

            return false;
        }

        public bool Remove(object obj)
        {

            if (obj == firstElement.Content)
            {
                firstElement = firstElement.Next;
                size--;
                return true;
            }

            Node current = firstElement.Next;
            Node previous = firstElement;

            for (int q = 1; q <= size - 1; q++)
            {
                if ((current.Content != null && current.Content.Equals(obj)) || (current.Content == null && obj == null))
                {
                    previous.Next = current.Next;
                    size--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
        }

        public object ElementAt(int index)
        {
            Node temp = firstElement;
            for (int q = 0; q <= size - 1; q++)
            {
                if (q == index)
                {
                    return temp.Content;
                }
                temp = temp.Next;
            }
            return null;
        }

    }
}
