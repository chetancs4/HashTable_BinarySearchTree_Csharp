using HashTableAndBinarySearchTree.Hashtable;

namespace HashTableAndBinarySearchTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
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

            // Remove the word "avoidable"
            string wordToRemove = "avoidable";
            hashTable.Remove(wordToRemove.ToLower());

            // Find and display the frequency of each word (excluding the removed word)
            foreach (string word in words)
            {
                string lowerWord = word.ToLower();
                if (lowerWord != wordToRemove.ToLower())
                {
                    int frequency = hashTable.FindFrequency(lowerWord);
                    Console.WriteLine($"The frequency of '{word}' is: {frequency}");
                }
            }
        }
    }
}