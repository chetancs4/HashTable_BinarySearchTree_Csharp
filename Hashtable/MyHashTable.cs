using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAndBinarySearchTree.Hashtable
{
    class MyHashTable<TKey, TValue>
    {
        private int size;
        private MyLinkedList<TKey, TValue>[] table;

        public MyHashTable(int size)
        {
            this.size = size;
            table = new MyLinkedList<TKey, TValue>[size];
            for (int i = 0; i < size; i++)
                table[i] = new MyLinkedList<TKey, TValue>();
        }

        private int HashFunction(TKey key)
        {
            int hash = 0;
            foreach (char c in key.ToString())
                hash += (int)c;
            return hash % size;
        }

        public void Insert(TKey key)
        {
            int index = HashFunction(key);
            MyLinkedList<TKey, TValue> linkedList = table[index];

            TValue value = linkedList.Search(key);
            if (value == null)
                linkedList.Insert(key, 1);
            else
                linkedList.Search(key).Value += 1;
        }

        public TValue FindFrequency(TKey key)
        {
            int index = HashFunction(key);
            MyLinkedList<TKey, TValue> linkedList = table[index];

            TValue value = linkedList.Search(key);
            if (value == null)
                return default(TValue);
            else
                return value;
        }
    }

}
