namespace ATBASH
{
    class myClass
    {
        static void Main(string[] args)
        {
            
        }

        /// <summary>
        /// Deciphers an array of encrypted strings using the ATBASH cipher technique.
        /// </summary>
        /// <param name="encrypted">An array of strings containing the encrypted words.</param>
        /// <returns>An array of strings where each input string is decrypted using the ATBASH cipher.</returns>
        static string[] Decrypted(string[] encrypted)
        {
            Dictionary<char, char> decryptionKey = new Dictionary<char, char>
            {
                {'a', 'z'},
                {'b', 'y'},
                {'c', 'x'},
                {'d', 'w'},
                {'e', 'v'},
                {'f', 'u'},
                {'g', 't'},
                {'h', 's'},
                {'i', 'r'},
                {'j', 'q'},
                {'k', 'p'},
                {'l', 'o'},
                {'m', 'n'},
                {'n', 'm'},
                {'o', 'l'},
                {'p', 'k'},
                {'q', 'j'},
                {'r', 'i'},
                {'s', 'h'},
                {'t', 'g'},
                {'u', 'f'},
                {'v', 'e'},
                {'w', 'd'},
                {'x', 'c'},
                {'y', 'b'},
                {'z', 'a'},
                {'A', 'Z'},
                {'B', 'Y'},
                {'C', 'X'},
                {'D', 'W'},
                {'E', 'V'},
                {'F', 'U'},
                {'G', 'T'},
                {'H', 'S'},
                {'I', 'R'},
                {'J', 'Q'},
                {'K', 'P'},
                {'L', 'O'},
                {'M', 'N'},
                {'N', 'M'},
                {'O', 'L'},
                {'P', 'K'},
                {'Q', 'J'},
                {'R', 'I'},
                {'S', 'H'},
                {'T', 'G'},
                {'U', 'F'},
                {'V', 'E'},
                {'W', 'D'},
                {'X', 'C'},
                {'Y', 'B'},
                {'Z', 'A'},
            };
            string[] decrypted = new string[encrypted.Length];
            int index = 0;
            foreach (string word in encrypted)
            {
                string decryptedWord = "";
                foreach (char letter in word)
                {
                    if (decryptionKey.ContainsKey(letter))
                    {
                        decryptedWord += decryptionKey[letter];
                    }
                    else
                    {
                        decryptedWord += letter;
                    }
                }
                decrypted[index] = decryptedWord;
                index++;
            }
            return decrypted;
        }
        static string[] InputManager(string[] args)
        {
            
        }

        /// <summary>
        /// Analyzes the decrypted content to determine occurrences of specific watched words.
        /// </summary>
        /// <param name="decrypted">An array of strings containing decrypted words to be analyzed.</param>
        /// <returns>A tuple containing an integer representing the count of matched watched words and an array of the decrypted words.</returns>
        static (int, string[]) ContetAnalysis(string[] decrypted)
        {
            int points = 0;
            string[] WatchedWords = new []
            {
                "bomb", 
                "nukhba", 
                "fighter", 
                "rocket", 
                "secret"
            };
            foreach (string word in decrypted)
            {
                if (WatchedWords.Contains(word))
                {
                    points++;
                }
            }
            return (points, WatchedWords);
        }
        static void SummaryAndPrinting(string[] args)
        {
            
        }
    }
}