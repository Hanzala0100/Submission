using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_vs_Classes
{
    public class Student
    {
        public int Id;
        public string Name;
        public string Course;

        public Student(int id, string name, string course)
        {
            Id = id;
            Name = name;
            Course = course;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Course: {Course}\n");
        }
    }
}
