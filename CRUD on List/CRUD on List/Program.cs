namespace CRUD_on_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Console.WriteLine("---------------------Welcome to the Student Management System!-----------------\n");
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Exit");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddStudent(students);
                        break;
                    case "2":
                        ViewStudents(students);
                        break;
                    case "3":
                        UpdateStudent(students);
                        break;
                    case "4":
                        DeleteStudent(students);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }

        }

        public static void AddStudent(List<Student> students)
        {
            Console.Write("Enter Student ID:");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name:");
            string name = Console.ReadLine();
            Console.Write("Enter Student Surname:");
            string surname = Console.ReadLine();
            Console.Write("Enter Student Email:");
            string email = Console.ReadLine();
            Console.Write("Enter Student Phone Number:");
            string phoneNumber = Console.ReadLine();
            students.Add(new Student(id, name, surname, email, phoneNumber));
        }

        public static void UpdateStudent(List<Student> students)
        {
            Console.Write("Enter Student ID to update:");
            int id = int.Parse(Console.ReadLine());
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                Console.Write("Enter new Name:");
                student.Name = Console.ReadLine();
                Console.Write("Enter new Surname:");
                student.Surname = Console.ReadLine();
                Console.Write("Enter new Email:");
                student.Email = Console.ReadLine();
                Console.Write("Enter new Phone Number:");
                student.PhoneNumber = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public static void DeleteStudent(List<Student> students)
        {
            Console.Write("Enter Student ID to delete:");
            int id = int.Parse(Console.ReadLine());
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Student deleted successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public static void ViewStudents(List<Student> students)
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students available.");
                return;
            }
            foreach (var student in students)
            {
                student.PrintDetails();
            }
        }

    }
}
