using System;
using System.Collections.Generic;

namespace Epam.NetMentoring.HashTableTask
{
    public class HashTable
    {
        private const int Size = 100;
        private readonly WordDefinition[] _wordDefinitions;

        public HashTable()
        {
            _wordDefinitions = new WordDefinition[Size];
        }

        public string this[WordEntity key]
        {
            get { return GetWordByKey(key); }
            set { ChangeWordByKey(key, value); }
        }

        public void AddItem(WordEntity wordEntity, string definition)
        {
            if (definition == null || wordEntity == null) throw new ArgumentNullException();
            var wordDefinition = new WordDefinition
            {
                Definition = definition,
                Word = wordEntity.Word
            };

            var hash = CalculateHash(wordEntity);

            if (_wordDefinitions[hash] == null)
            {
                _wordDefinitions[hash] = wordDefinition;
            }
            else
            {
                var next = _wordDefinitions[hash];
                while (next.Next != null)
                {
                    next = next.Next;
                }
                next.Next = wordDefinition;
            }
        }

        private string GetWordByKey(WordEntity wordEntity)
        {
            if (wordEntity == null) throw new ArgumentNullException();
            var hash = CalculateHash(wordEntity);
            string result = String.Empty;
            var next = _wordDefinitions[hash];
            bool wasFound = false;
            while (next != null && !wasFound)
            {
                if (next.Word == wordEntity.Word)
                {
                    result = next.Definition;
                    wasFound = true;
                }
                next = next.Next;
            }
            if (!wasFound) throw new KeyNotFoundException();
            return result;
        }

        private void ChangeWordByKey(WordEntity wordEntity, string definition)
        {
            if (wordEntity == null || definition == null) throw new ArgumentNullException();
            var hash = CalculateHash(wordEntity);
            if (_wordDefinitions[hash] == null) throw new KeyNotFoundException();
            var next = _wordDefinitions[hash];
            var wasFound = false;
            while (next != null && !wasFound)
            {
                if (next.Word == wordEntity.Word)
                {
                    next.Definition = definition;
                    wasFound = true;
                }
                next = next.Next;
            }
            if (!wasFound) throw new KeyNotFoundException();
        }

        private static int CalculateHash(WordEntity key)
        {
            return Math.Abs(((17*key.GetHashCode() + 47)%13249)%Size);
        }
    }
}