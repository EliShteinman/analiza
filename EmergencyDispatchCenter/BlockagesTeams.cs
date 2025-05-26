namespace EmergencyDispatchCenter;

public class BlockagesTeams: EmeergencyTeams
{
    string name;
    string zone;
    bool avilable;
    public BlockagesTeams(string name, string zone, bool avilable)
    {
        this.name = name;
        this.zone = zone;
        this.avilable = avilable;
    }
    
}