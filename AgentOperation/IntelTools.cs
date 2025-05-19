namespace oop;

public static class IntelTools
{
    public static string EncryptMessage(string msg)
    {
        string temp = "";
        for (int i = msg.Length - 1; i >= 0; i--)
        {
            temp += msg[i];
        }
        
        return temp;
    }
    public static void LogTransmission(string agentName, string message)
    {
        Console.WriteLine($"[{agentName}] send encrypted message: [{message}].");
    }

}