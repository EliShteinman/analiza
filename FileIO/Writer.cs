namespace FileIO;

public static class Writer
{
    public static void ToFile(string path, string content)
    {
        File.AppendAllLines(path, [content] );
    }
}