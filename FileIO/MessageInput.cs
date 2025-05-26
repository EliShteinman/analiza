namespace FileIO;

public static class MessageInput
{
    public static string GetMessage()
    {
        Console.WriteLine("Please type the message you want to encrypt.");
        return Console.ReadLine()!;
    }
}