using HashTableAndBinarySearchTree.Hashtable;

namespace HashTableAndBinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "To be or not to be";
            string[] words = sentence.Split();

            // Create a hash table to store the word frequencies
            MyHashTable<string, int> hashTable = new MyHashTable<string, int>(words.Length);

            // Count word frequencies and update the hash table
            foreach (string word in words)
            {
                string lowerWord = word.ToLower(); // Convert all words to lowercase for case-insensitive comparison
                hashTable.Insert(lowerWord);
            }

            // Find and display the frequency of each word
            foreach (string word in words)
            {
                string lowerWord = word.ToLower();
                int frequency = hashTable.FindFrequency(lowerWord);
                Console.WriteLine($"The frequency of '{word}' is: {frequency}");
            }
        }
    }
    }
}