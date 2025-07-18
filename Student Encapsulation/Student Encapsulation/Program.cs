namespace Student_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------Student Details------------");
            Student student1 = new Student(101, "Abhay", 8.5);
            student1.ShowDetails();
            Student student2 = new Student(102, "Rohit", 9.0);
            student2.ShowDetails();
            Student student3 = new Student(103, "Anjali", 7.5);
            student3.ShowDetails();
        }
    }
}
