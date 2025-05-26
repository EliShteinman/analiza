namespace FileIO;

class Program
{
    public static void Main()
    {
        var message = MessageInput.GetMessage();
        var encryptedMessage = Encrypted.Atbash(message);
        Console.WriteLine(encryptedMessage);
        Writer.ToFile("secret.txt", encryptedMessage);
        var readFromFile = Reader.FromFile("secret.txt");
        var decryptedMessage = Decrypted.Atbash(readFromFile);
        Console.WriteLine(decryptedMessage);
    }
}