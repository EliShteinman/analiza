namespace Modularity
{
    class Program
    {
        static void Main()
        {
            Student student = new Student();
            Update.Name.Update(student);
            Update.Grade.Update(student);
            Update.Result.Update(student);
            PrintReportStudent.Print(student);
        }
    }
}