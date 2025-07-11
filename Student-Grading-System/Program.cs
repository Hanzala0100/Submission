namespace StudentGradingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = { 2, 3, 4, 5, 6 };
            Student student = new Student("Akanksha", "121A7016", marks);
            student.CalculateAverage();
            student.CalculateGrade();
            student.printReport();
        }
    }
}
