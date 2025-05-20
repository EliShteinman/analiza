namespace Modularity
{
    public class Student
    {
        public string name;
        public int grade;
        public string result;
    }
    public static class PrintReportStudent
    {
        public static void Print(Student student)
        {
            Console.WriteLine($"Student: {student.name}, Grade: {student.grade}, Result: {student.result}");
        }
    }
}