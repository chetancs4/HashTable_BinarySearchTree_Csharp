using HashTableAndBinarySearchTree.Hashtable;

namespace HashTableAndBinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] words = paragraph.Split(' ', StringSplitOptions.RemoveEmptyEntries);

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