using System;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Transactions;
using CSharpUdemy.Classes;

namespace CSharpUdemy
{
    class Program
    {

        public enum ShippingMethod
        {
            RegularAirMail = 1,
            RegisteredAirMail = 2,
            Express = 3
        }

        public enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        static void Main(string[] args)
        {
            /*
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            int i = 500;
            byte j = (byte)i;
            //byte k = 200;
            //i = k;
            Console.WriteLine(j);
            string strNum = "1";
            int numNum = int.Parse(strNum);

            try
            {
                var number = "1234";
                byte b = Convert.ToByte((number));
            }
            catch (Exception e)
            {
                Console.WriteLine("The number could not work");
                
            }
            
            var John = new Person();
            John.FirstName = "Victor";
            John.LastName = "Wiedemann";
            John.Introduce();

            var calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

            
            var arrNumbers = new int[3] {1, 2 ,3};
            var peopleNames = new string[] {"Jack", "John", "Mary"};
            

            string name = string.Format("{0} {1} {0}", "hello", "world");
            string list = string.Join(" asdfasdf ", peopleNames);
            
            string path =      "c:\\projects\\csharp";
            string pathequiv = @"c:\projects\csharp";
            if (path == pathequiv)
            {
                //we will get here.
                Console.WriteLine("it works!");
            }

            string formattedText = @"Hi John
Look into the following paths:
c:\place 1
c:\place 2";
            Console.WriteLine(formattedText);
            
            {
                var method = ShippingMethod.Express;
                Console.WriteLine((int) method);

                var MethodID = 3;
                //below will convert 3 to the string "Express". All lines below will print Express
                Console.WriteLine((ShippingMethod) MethodID);
                Console.WriteLine(method.ToString());
                Console.WriteLine(method);

                //below will parse the methodName as the enum type Shipping method.
                var methodName = "Express";
                var shippingMethod = Enum.Parse(typeof(ShippingMethod), methodName, false);
                Console.WriteLine(shippingMethod);
            }

            //note: when passing a class variable, it acts like a C pointer instead of a by-value variable.

            //different if statement. This is identical to C
            bool isGoldMember = true;
            float price = (isGoldMember) ? 19.95f : 29.95f;
            //prints 19.95
            Console.WriteLine(price);
            

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Spring:
                    Console.WriteLine("odd seasons");
                    break;
                default:
                    Console.WriteLine("even seasons");
                    break;

            }
            

            //Basics application to read a value and print if it is valid or not
            string UserValue = Console.ReadLine();
            int integerValue = 0;
            bool didParse = int.TryParse(UserValue, out integerValue);

            if (!didParse)
            {
                Console.WriteLine("Invalid");
            } else if ((integerValue >= 0) & (integerValue <= 10))
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            /








            //Gets 2 values with error handling and displays the larger
            int intValue1 = 0;
            int intValue2 = 0;

            bool didParse = false;
            do
            {
                Console.WriteLine("Enter your first number:");
                string userValue1 = Console.ReadLine();
                didParse = (int.TryParse(userValue1, out intValue1));
                if (!didParse)
                {
                    Console.WriteLine("Your number is not a real number, please enter a real one.");
                }
            } while (!didParse);

            didParse = false;
            do
            {
                Console.WriteLine("Enter Your Second Number");
                string userValue2 = Console.ReadLine();
                didParse = int.TryParse(userValue2, out intValue2);
                if (!didParse)
                {
                    Console.WriteLine("Your number is not a real number, please enter a real one.");
                }
            } while (!didParse);

            if (intValue1 > intValue2)
            {
                Console.WriteLine("The largest value is: " + intValue1);
            }
            else
            {
                Console.WriteLine("The largest value is: " + intValue2);
            }






            /



            //Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.
            //almost identical to the last problem.
            int width = 0;
            int height = 0;

            bool didParse = false;
            do
            {
                Console.WriteLine("Enter your first number:");
                string userValue1 = Console.ReadLine();
                didParse = (int.TryParse(userValue1, out width));
                if (!didParse)
                {
                    Console.WriteLine("Your number is not a real number, please enter a real one.");
                }
            } while (!didParse);

            didParse = false;
            do
            {
                Console.WriteLine("Enter Your Second Number");
                string userValue2 = Console.ReadLine();
                didParse = int.TryParse(userValue2, out height);
                if (!didParse)
                {
                    Console.WriteLine("Your number is not a real number, please enter a real one.");
                }
            } while (!didParse);

            if (width > height)
            {
                Console.WriteLine("The image is landscape");
            }
            else
            {
                Console.WriteLine("the image is portrait");
            }


            /




            // Your job is to write a program for a speed camera.For simplicity,
            // ignore the details such as camera, sensors, etc and focus purely on the logic.
            // Write a program that asks the user to enter the speed limit.Once set,
            // the program asks for the speed of a car.If the user enters a value less than the speed limit,
            // program should display Ok on the console.If the value is above the speed limit,
            // the program should calculate the number of demerit points.For every 5km / hr above the speed limit,
            // 1 demerit points should be incurred and displayed on the console.If the number of demerit points is above 12,
            // the program should display License Suspended.
            //Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.
            //almost identical to the last problem.
            int speedLimit = 0;
            int measuredSpeed = 0;

            bool didParse = false;
            do
            {
                Console.WriteLine("Enter the speed limit:");
                string userValue1 = Console.ReadLine();
                didParse = (int.TryParse(userValue1, out speedLimit));
                if (!didParse)
                {
                    Console.WriteLine("Your number is not a real number, please enter a real one.");
                }
            } while (!didParse);

            didParse = false;
            do
            {
                Console.WriteLine("Enter the measured speed of the car: ");
                string userValue2 = Console.ReadLine();
                didParse = int.TryParse(userValue2, out measuredSpeed);
                if (!didParse)
                {
                    Console.WriteLine("Your number is not a real number, please enter a real one.");
                }
            } while (!didParse);

            if (speedLimit < measuredSpeed)
            {
                const int demeritsIncrement = 5;
                int numOfDemerits = (measuredSpeed - speedLimit) / demeritsIncrement;
                if (numOfDemerits >= 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("Number of Demerits received is: " + numOfDemerits);
                }

            }
            else
            {
                Console.WriteLine("Ok");
            }

            /



            //random class:
            var random = new Random();
            for (var i = 0; i < 10; i++)
            {
                Console.Write((char) random.Next(97, 122));
            }
            Console.WriteLine("");
            */


        }
    }
}
