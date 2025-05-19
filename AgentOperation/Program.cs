namespace oop;

class MyClass
{
    static void Main()
    {
        Agent izak = new Agent("8214453", 2);
        Report report = new Report(izak,4,"Enemy forces detected in sector 7.");
        MissionControl.AnalyzeReport(report);
        IntelTools.LogTransmission(izak.codeName,IntelTools.EncryptMessage(report.summary));
    }
}