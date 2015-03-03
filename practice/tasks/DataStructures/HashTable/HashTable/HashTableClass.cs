using Epam.NetMentoring.HashTable.WordDef;
using Epam.NetMentoring.HashTable.WordEnt;
using System;

namespace Epam.NetMentoring.HashTable.HashTableClass
{
    public class MyHashTable
    {
        private WordDefinition[] items;

        public int Size { get; set; }

        public string this[WordEntity key]
        {
            get
            {
                return GetItemByKey(key);
            }
            set
            {
                ChangeByKey(key, value);
            }
        }

        public MyHashTable()
        {
            Size = 25;
            items = new WordDefinition[Size];
        }

        public void AddItem(WordEntity key, string definition)
        {
            if (key != null && definition != null && key.Type != null)
            {
                var word = new WordDefinition { Definition = definition, Word = key.Word, Description = key.Type.Description };

                int hash = Hash(key);
                if (items[hash] == null)
                {
                    items[hash] = word;
                }
                else
                {
                    var temp = items[hash];
                    while (temp.Next != null)
                    {
                        temp = temp.Next;
                    }
                    temp.Next = word;
                }
            }
        }

        public bool IfExist(string definition)
        {
            bool result = false;
            if (definition != null)
            {
                for (int q = 0; q < Size; q++)
                {
                    if (items[q] != null)
                    {
                        var temp = items[q];
                        while (temp != null)
                        {
                            if (temp.Definition == definition)
                            {
                                result = true;
                                break;
                            }
                            temp = temp.Next;
                        }
                    }
                    if (result) break;
                }
            }
            return result;
        }

        private string GetItemByKey(WordEntity key)
        {
            string result = null;
            if (key != null)
            {
                int hash = Hash(key);
                if (items[hash] != null)
                {
                    if (items[hash].Word == key.Word && items[hash].Description == key.Type.Description)
                    {
                        result = items[hash].Definition;
                    }
                    else
                    {
                        var temp = items[hash];
                        while (temp != null)
                        {
                            if (temp.Word == key.Word && temp.Description == key.Type.Description)
                            {
                                result = temp.Definition;
                                break;
                            }
                            temp = temp.Next;
                        }
                    }
                }
            }
            return result;
        }

        private bool ChangeByKey(WordEntity key, string definition)
        {
            bool result = false;
            if (key != null && definition != null && key.Type != null)
            {

                if (key != null)
                {
                    int hash = Hash(key);
                    if (items[hash] != null)
                    {
                        if (items[hash].Word == key.Word && items[hash].Description == key.Type.Description)
                        {
                            items[hash].Definition = definition;

                            result = true;
                        }
                        else
                        {
                            var temp = items[hash];
                            while (temp != null)
                            {
                                if (temp.Word == key.Word && temp.Description == key.Type.Description)
                                {
                                    temp.Definition = definition;
                                    result = true;
                                    break;
                                }
                                temp = temp.Next;
                            }
                        }
                    }
                }
            }
            return result;
        }

        private int Hash(WordEntity key)
        {
            return Math.Abs(((17 * key.GetHashCode() + 47) % 13249) % Size);
        }
    }
}
