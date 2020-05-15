using System;


namespace CSharpUdemy
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber) // this line specifically pushed reg number to the vehicle class.
        {
            //init fields specific to car class
            Console.WriteLine("car being init");
        }

        public Car() : base("reg num goes here") // this will pass "reg num goes here" to the Vehicle class.
        {
            Console.WriteLine("car init without reg number");
        }
    }
}
