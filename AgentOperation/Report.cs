namespace oop;

public class Report
{
    public string summary;
    public int urgencyLevel;
    public Agent submittedBy;

    public Report(Agent submittedBy, int urgencyLevel, string summary)
    {
        this.summary = summary;
        this.submittedBy = submittedBy;
        this.urgencyLevel = urgencyLevel;
    }
}