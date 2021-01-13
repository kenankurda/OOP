using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Person
    {
        public string FullName { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Age = 15;
        }
        public Person(string fullName) : this()
        {
            this.FullName = fullName;
        }
        public Person(string fullName, int age) : this(fullName)
        {
            this.FullName = fullName;
            this.Age = age;
        }



        public void GetDetails()
        {

            Console.WriteLine($"The Fullname is :{FullName} and the Age is {Age}");
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            // Person p = new Person("Kenan Kurda", 50);

            Person p = new Person
            {
                FullName = "Kenan Kurda",
                Age = 50
            };


            p.GetDetails();

        }
    }
}
