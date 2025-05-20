using Modularity;
namespace Update
{
    public static class Name
    {
        public static void Update(Student student)
        {
            Console.WriteLine("Enter student name:");
            student.name = Console.ReadLine();
        }
    }
    public static class Grade
    {
        public static void Update(Student student)
        {
            bool isValid = false;
            int grade = 0;
            while (!isValid)
            {
                Console.WriteLine("Enter grade:");
                isValid = int.TryParse(Console.ReadLine(), out grade) && grade >= 0 && grade <= 100;
            }
            student.grade = grade;
        }
    }
    public static class Result
    {
        public static void Update(Student student)
        {
            if (student.name == null)
            {
                Name.Update(student);
            }

            if (student.grade == null)
            {
                Grade.Update(student);
            }
            student.result = GradeEvaluator.Grade(student.grade);
        }
    }
    public static class GradeEvaluator
    {
        public static string Grade(int grade)
        {
            switch (grade)
            {
                case >= 90:
                    return "Excellent";
                case >= 75:
                    return "Good";
                case >= 60:
                    return "Pass";
                default:
                    return "Fail";
            }
        }
    }
}

