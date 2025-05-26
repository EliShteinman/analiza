namespace FileIO;

class Program
{
    public static void Main()
    {
        const string path = "secret.txt";
        var message = MessageInput.GetMessage();
        // Console.WriteLine(message);
        var encryptedMessage = Encrypted.Atbash(message);
        // Console.WriteLine(encryptedMessage);
        Writer.ToFile(path, encryptedMessage);
        var readFromFile = Reader.FromFile(path);
        // Console.WriteLine(readFromFile);
        var decryptedMessage = Decrypted.Atbash(readFromFile);
        // Console.WriteLine(decryptedMessage);
    }
}