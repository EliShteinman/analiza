namespace oop;

public class Agent
{
    public string codeName;
    private int clearanceLevel;
    public Agent(string codeName, int clearanceLevel)
    {
        SetClearanceLevel(clearanceLevel);
        this.codeName = codeName;
    }
    public void Report()
    {
        Console.WriteLine($"Agent [{codeName}] reporting. Clearance level: [{clearanceLevel}].");
    }

    public int GetClearanceLevel()
    {
        return clearanceLevel;
    }
    public void SetClearanceLevel(int clearanceLevel)
    {
        if (clearanceLevel >= 1 && clearanceLevel <= 5)
        {
            this.clearanceLevel = clearanceLevel;
        }
        else
        {
            throw new Exception("Clearance level must be between 1 and 5.");
        }
    }
}