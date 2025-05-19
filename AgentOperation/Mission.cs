namespace oop;

public class Mission
{
    string missionName;
    string targetLocation;
    Agent assignedAgent;

    public Mission(
        string missionName, 
        string targetLocation
        )
    {
        this.missionName = missionName;
        this.targetLocation = targetLocation;
    }

    public void AssignAgent(Agent agent)
    {
        assignedAgent = agent;
    }
    public void Brief()
    {
        Console.WriteLine($"Mission: [{missionName}], Target: [{targetLocation}], Agent: [{assignedAgent.codeName}]");
    }
}