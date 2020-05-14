using System;

namespace CSharpUdemy.Classes
{
    public class Person
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime Birthdate { get; private set; } //set is private since it should be done at the constructor time

        public int Age {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
            //no set because it does not make sense to set someones birthday if you have their birthdate.
        }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public void Introduce()
        {
            Console.WriteLine("My name is " + Name + " " + Username);
        }

    }
}