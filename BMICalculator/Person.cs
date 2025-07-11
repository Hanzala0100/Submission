using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    public class Person
    {
        public int personId, personAge;
        public string personName;
        public double personWeight, personHeight;
        public Person(int id, string name, int age, double weight, double height)
        {
            personId = id;
            personName = name;
            personAge = age;
            personWeight = weight;
            personHeight = height;
        }
        public Person(int id, string name, int age)
        {
            personId = id;
            personName = name;
            personAge = age;
            personWeight = 50.0;
            personHeight = 1.5;
        }
        public double CalcuateBMI()
        {
            double BMIScore = personWeight / (personHeight * personHeight);
            return BMIScore;
        }
        public string GetBodyType()
        {
            double BMIScore = CalcuateBMI();
            if (BMIScore < 18.5)
                return "Underweight";
            else if (BMIScore < 24.9)
                return "Normal weight";
            else if (BMIScore < 29.9)
                return "Overweight";
            else
                return "Obese";
        }
        public override string ToString()
        {
            return $"Id: {personId}, Name: {personName}, Age: {personAge}, Weight: {personWeight}, Height: {personHeight}, BMI Score: {CalcuateBMI()}, Body Type: {GetBodyType()}";
        }
    }
}
