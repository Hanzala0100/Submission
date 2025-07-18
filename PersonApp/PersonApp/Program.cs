namespace PersonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------Person BMI index Calculator-----------");
            Person person1 = new Person(1, "John", 30, 6.0, 180);
            double bmi= person1.BMI();
            person1.getBodyType(bmi);
            Person person2 = new Person(2, "Jane", 25);
            double bmi2 = person2.BMI();
            person2.getBodyType(bmi2);
        }
    }
}
