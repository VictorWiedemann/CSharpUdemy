using System;

namespace CSharpUdemy
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("vehicle is being init {0}", registrationNumber);
        }



    }
}