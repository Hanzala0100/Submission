using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Student_Encapsulation
{
    internal class Student
    {
        private int rollno;
        private string name;
        private double cgpa;

        public Student(int rollno, string name, double cgpa)
        {
            SetRollno(rollno);
            SetName(name);
            SetCgpa(cgpa);
        }

        public void SetRollno(int value)
        {
            if (value > 0)
                rollno = value;
            else
                rollno = 0;
        }

        public void SetName(string value)
        {
            if (value.Length >= 5)
                name = value;
            else
                name = "";
        }

        public void SetCgpa(double value)
        {
            if (value >= 1 && value <= 10)
                cgpa = value;
            else
                cgpa = 0;
        }

        public double GetPercentage()
        {
            return cgpa * 9.5;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"\nRoll No: {rollno}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"CGPA: {cgpa}");
            Console.WriteLine($"Percentage: { GetPercentage()}\n");
        }
    }
}
