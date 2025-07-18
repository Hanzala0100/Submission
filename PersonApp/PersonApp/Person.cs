using System;

namespace PersonApp
{
    enum BodyType
    {
        Underweight,
        Normal_Weight,
        Overweight,
        Obese
    }
    internal class Person
    {
        public int id;
        public string name;
        public int age;
        public double height;
        public double weight;

        public Person(int id, string name, int age, double height, double weight)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.height = height;
            this.weight = weight;
        }

        public Person(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.height = 5; // Height in feet
            this.weight = 50;
        }

        public double BMI()
        {
            double heightInMeters = height * 0.3048; // Converted hieght in feet to meters
            double bmi = weight / (heightInMeters * heightInMeters);
            Console.WriteLine($"BMI of {name} is {bmi:F}");
            return bmi;
        }

        public void getBodyType(double bmi)
        {
            if (bmi < 18)
            {
                Console.WriteLine($"{name} is {BodyType.Underweight}");
            }
            else if (bmi >= 18 && bmi < 25)
            {
                Console.WriteLine($"{name} has a {BodyType.NormalWeight}");
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine($"{name} is {BodyType.Overweight}");
            }
            else
            {
                Console.WriteLine($"{name} is {BodyType.Obese}");
            }
        }
    }
}
