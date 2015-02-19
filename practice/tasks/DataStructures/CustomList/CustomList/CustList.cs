using Epam.NetMentoring.CustomList.LinkedNodeClass;

namespace Epam.NetMentoring.CustomList.LinkedListClass
{
    public class LinkedList
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
            bool result = false;

            if (index > 0 && index < size)
            {
                var temp = firstElement;
                for (int q = 0; q < index - 1; q++)
                {
                    temp = temp.Next;
                }
                temp.Next = new Node { Content = item, Next = temp.Next };
                size++;
                result = true;
            }

            else if (index == 0)
            {
                firstElement = new Node { Content = item, Next = firstElement };
                size++;
                result = true;
            }

            return result;
        }

        public bool RemoveAt(int index)
        {
            bool result = false;
            if (index > 0 && index < size)
            {

                Node current = firstElement;
                Node previous = new Node();
                for (int q = 0; q < index; q++)
                {

                    previous = current;
                    current = current.Next;
                }
                previous.Next = current.Next;
                size--;
                result = true;

            }
            else if (index == 0)
            {
                firstElement = firstElement.Next;
                size--;
                result = true;
            }

            return result;
        }

        public bool Remove(object obj)
        {
            bool result = false;
            if (obj == firstElement.Content)
            {
                firstElement = firstElement.Next;
                size--;
                result = true;
            }

            else
            {
                Node current = firstElement.Next;
                Node previous = firstElement;
                for (int q = 1; q < size; q++)
                {
                    if ((current.Content != null && current.Content.Equals(obj)) || (current.Content == null && obj == null))
                    {
                        previous.Next = current.Next;
                        size--;
                        result = true;
                        break;
                    }

                    previous = current;
                    current = current.Next;
                }
            }
            return result;
        }

        public object ElementAt(int index)
        {
            object result = null;
            if (index >= 0 && index < size)
            {
                Node temp = firstElement;
                for (int q = 0; q < index; q++)
                {
                    temp = temp.Next;
                }
                result = temp.Content;
            }
            return result;
        }

    }
}
