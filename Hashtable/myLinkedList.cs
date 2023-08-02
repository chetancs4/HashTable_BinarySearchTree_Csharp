using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAndBinarySearchTree.Hashtable
{

    public class MyLinkedList<TKey, TValue>
    {
        private MyMapNode<TKey, TValue> head;

        public void Insert(TKey key, TValue value)
        {
            MyMapNode<TKey, TValue> newNode = new MyMapNode<TKey, TValue>(key, value);
            newNode.Next = head;
            head = newNode;
        }

        public TValue Search(TKey key)
        {
            MyMapNode<TKey, TValue> current = head;
            while (current != null)
            {
                if (current.Key.Equals(key))
                    return current.Value;
                current = current.Next;
            }
            return default(TValue);
        }

        public bool Remove(TKey key)
        {
            MyMapNode<TKey, TValue> current = head;
            MyMapNode<TKey, TValue> prev = null;

            while (current != null)
            {
                if (current.Key.Equals(key))
                {
                    if (prev == null)
                    {
                        // Removing the head node
                        head = current.Next;
                    }
                    else
                    {
                        prev.Next = current.Next;
                    }
                    return true;
                }

                prev = current;
                current = current.Next;
            }

            return false;
        }
    }

}
