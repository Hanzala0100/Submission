using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradingSystem
{
    public class Student
    {
        public string studentName, rollNumber;
        public char Grade;
        public int[] Marks = new int[5];
        public int average = 0;

        public Student(string name, string RollNumber, int[] marks)
        {
            studentName = name;
            rollNumber = RollNumber;
            Marks = marks;
        }
        public double CalculateAverage()
        {
            int sum = 0;
            for (int i = 0; i < Marks.Length; i++)
            {
                sum += Marks[i];
            }
            average = sum / 5;
            return average;
        }
        public char CalculateGrade()
        {
            if (average >= 90)
            {
                Grade = 'A';
            }
            else if (average >= 80 && average <= 89)
            {
                Grade = 'B';
            }
            else if (average >= 70 && average <= 79)
            {
                Grade = 'C';
            }
            else
            {
                Grade = 'D';
            }
            return Grade;
        }
        public void printReport()
        {
            Console.WriteLine($"Name: {studentName}, Roll Number: {rollNumber}, Average: {average}, Grade: {Grade}");
            for (int i = 0; i < Marks.Length; i++)
            {
                Console.WriteLine("Marks of 5 subjects are: " + Marks[i]);
            }
        }
    }
}
