namespace SingleInheritance
{

    class Person
    {
        public string Name;
        public int Age;

        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }

    class Student : Person
    {
        public string Course;

        public void ShowStudentDetails()
        {
            // Call base class method
            DisplayInfo();
            Console.WriteLine("Course: " + Course);
        }
    }

    class Program
    {
        static void Main()
        {
            // Create an object of derived class
            Student student = new Student();

            // Assign values (inherited and own)
            student.Name = "Alice";
            student.Age = 21;
            student.Course = "Computer Science";

            // Display details
            student.ShowStudentDetails();
        }
    }
}
