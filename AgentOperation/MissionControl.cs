namespace oop;

public static class MissionControl
{
    public static void AnalyzeReport(Report r)
    {
        if (r.urgencyLevel >= 4)
        {
            Console.WriteLine("Immediate response required.");
        }
        else if (r.urgencyLevel == 3)
        {
            Console.WriteLine("High priority. Monitor closely.");
        }
        else
        {
            Console.WriteLine("Routine analysis.");
        }
    }
}