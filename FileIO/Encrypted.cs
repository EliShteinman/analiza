namespace FileIO;

public static class Encrypted
{
    public static string Atbash(string encrypted)
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

                string decrypted = "";
                foreach (char letter in encrypted)
                {
                    if (decryptionKey.ContainsKey(letter))
                    {
                        decrypted += decryptionKey[letter];
                    }
                    else
                    {
                        decrypted += letter;
                    }
                }
            return decrypted;
        }
}
