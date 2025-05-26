namespace FileIO;

public static class Reader
{
    public static string FromFile(string path)
    {
        return File.ReadAllText(path);
    }
}