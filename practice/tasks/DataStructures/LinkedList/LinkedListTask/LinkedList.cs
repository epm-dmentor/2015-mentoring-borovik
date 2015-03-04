namespace Epam.NetMentoring.Practice.Tasks.DataStructures.LinkedListTask
{
    public class LinkedList
    {
        private Node _firstElement;

        public LinkedList(params object[] args)
        {
            foreach (var element in args)
            {
                Add(element);
            }
        }

        public int Count { get; private set; }

        public void Add(object item)
        {
            var node = new Node {Content = item};

            if (_firstElement == null)
            {
                _firstElement = node;
            }
            else
            {
                var temp = _firstElement;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Count++;
        }

        public bool InsertAt(int index, object item)
        {
            var result = false;

            if (index > 0 && index < Count)
            {
                var temp = _firstElement;
                for (var q = 0; q < index - 1; q++)
                {
                    temp = temp.Next;
                }
                temp.Next = new Node {Content = item, Next = temp.Next};
                Count++;
                result = true;
            }

            else if (index == 0)
            {
                _firstElement = new Node {Content = item, Next = _firstElement};
                Count++;
                result = true;
            }

            return result;
        }

        public bool RemoveFrom(int index)
        {
            var result = false;
            if (index > 0 && index < Count)
            {
                var current = _firstElement;
                var previous = new Node();
                for (var q = 0; q < index; q++)
                {
                    previous = current;
                    current = current.Next;
                }
                previous.Next = current.Next;
                Count--;
                result = true;
            }
            else if (index == 0)
            {
                _firstElement = _firstElement.Next;
                Count--;
                result = true;
            }

            return result;
        }

        public bool Remove(object obj)
        {
            var result = false;
            if (obj == _firstElement.Content)
            {
                _firstElement = _firstElement.Next;
                Count--;
                result = true;
            }

            else
            {
                var current = _firstElement.Next;
                var previous = _firstElement;
                var found = false;
                while (current != null && !found)
                {
                    found = (current.Content == null && obj == null);
                    if (!found) found = (current.Content != null && current.Content.Equals(obj));
                    if (found)
                    {
                        previous.Next = current.Next;
                        Count--;
                        result = true;
                    }
                    previous = current;
                    current = current.Next;
                }
            }
            return result;
        }

        public object GetElementAt(int index)
        {
            object result = null;
            if (index >= 0 && index < Count)
            {
                var temp = _firstElement;
                for (var q = 0; q < index; q++)
                {
                    temp = temp.Next;
                }
                result = temp.Content;
            }
            return result;
        }
    }
}