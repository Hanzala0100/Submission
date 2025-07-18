namespace Struct_vs_Classes
{
    public struct Classroom
    {
        public string name;
        public string course;

        public Classroom(string name, string course)
        {
            this.name = name;
            this.course = course;
        }
    }
    public class Program
    {
        
        static void Main(string[] args)
        { 
            Classroom classroom1 = new Classroom("10th F","Science");
            Classroom classroom2 = new Classroom("10th E","Geography");

            Console.WriteLine($"Classroom 1: {classroom1.name}, Course: {classroom1.course}\n");
            Console.WriteLine($"Classroom 2: {classroom2.name}, Course: {classroom2.course}\n");

            Student student1 = new Student(1, "Alice", "Physics");
            Student student2 = new Student(2, "Bob", "Chemistry");

            student1.DisplayInfo();
            student2.DisplayInfo();

        }
    }
}
