using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_on_List
{
    public class Student
    {
        public int Id;
        public string Name;
        public string Surname;
        public string Email;
        public string PhoneNumber;


        public Student(int id, string name, string surname, string email, string phoneNumber)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Email = email;
            PhoneNumber = phoneNumber;
        }
        
        public void PrintDetails()
        {
            Console.WriteLine($"\nId: {Id},\nName: {Name},\nSurname: {Surname},\nEmail: {Email},\nPhone Number: {PhoneNumber}\n");
        }
    }
}
