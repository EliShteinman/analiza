namespace Modularity
{
    class Program
    {
        static void Main()
        {
            Student student = new Student();
            Update.Result.Update(student);
            PrintReportStudent.Print(student);
        }
    }
}