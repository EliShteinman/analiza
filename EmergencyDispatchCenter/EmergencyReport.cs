namespace EmergencyDispatchCenter;

public class EmergencyReport
{
    string incidentType;
    string zone;
    int severity;
    int expectedDuration;
    string description;

    public EmergencyReport(
        string incidentType, 
        string zone, 
        int severity, 
        int expectedDuration, 
        string description
        )
    {
        this.incidentType = incidentType;
        this.zone = zone;
        this.severity = severity;
        this.expectedDuration = expectedDuration;
        this.description = description;
    }
}