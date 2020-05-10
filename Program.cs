using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
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
            /








            int numberOfmult3 = 0;
            for(var i = 1; i < 100; i++)
            {
                if ( (i % 3) == 0)
                {
                    numberOfmult3++;
                }
            }
            Console.WriteLine("number of values between 1 and 100 that are divisible by 3 are: " + numberOfmult3);

            /

            //Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
            int totalValue = 0;
            do
            {
                Console.WriteLine("Enter a value:");
                string userValue = Console.ReadLine();
                if (userValue == "ok")
                {
                    break;
                }

                int userInt = 0;
                bool didParse = (int.TryParse(userValue, out userInt));
                if (!didParse)
                {
                    Console.WriteLine("Your number is not a real number, please enter a real one.");
                    continue;
                }
                else
                {
                    totalValue += userInt;
                }

                Console.WriteLine("Running total value is: " + totalValue);
            } while (true);








            /
            //Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
            do
            {
                Console.WriteLine("Enter a value:");
                string userValue = Console.ReadLine();
                int userInt = 0;
                bool didParse = (int.TryParse(userValue, out userInt));
                if (!didParse)
                {
                    Console.WriteLine("Your number is not a real number, please enter a real one.");
                    continue;
                }
                else if (userInt <= 0)
                {
                    Console.WriteLine("Number must be greater than 0");
                }
                else
                {
                    int factorialNum = 1; // make 1 so that the multiplication is 1 times values. If 0, will always be 0.
                    for (var i = userInt; i != 0; i--)
                    {
                        factorialNum *= i;
                    }

                    if (factorialNum == 0)
                    {
                        Console.WriteLine("number is too large to print");
                        break;
                    }

                    Console.WriteLine("factorial number is: " + factorialNum);
                    break;
                }

                
            } while (true);
            /







            //array demo
            var numbers = new[] {3, 7 ,9, 2, 14, 6};

            Console.WriteLine("Length: " + numbers.Length);

            //IndexOf finds where the value is in an array.
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("location of value 9 is: " + index); //prints 2 because it is in location 2 with 0 indexed

            //Clear ()
            //3 parameters, the array, the starting point, and number of items to remove from the array.
            //clear will set values to null, false, 0, etc.
            Array.Clear(numbers, 0, 2);

            foreach (var num in numbers)
            {
                Console.WriteLine(num); //replaced the 3 and 7 from the list with 0
            }

            Console.WriteLine("effect of copy()");
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);//will only copy the first 3 items

            foreach (var num in another)
            {
                Console.WriteLine(num); //replaced the 3 and 7 from the list with 0
            }

            Console.WriteLine("effect of sort");

            Array.Sort(numbers);
            foreach (var num in numbers)
            {
                Console.WriteLine(num); //replaced the 3 and 7 from the list with 0
            }

            Console.WriteLine("effect of reverse");
            Array.Reverse(numbers);
            foreach (var num in numbers)
            {
                Console.WriteLine(num); //replaced the 3 and 7 from the list with 0
            }
            */




            /*


            //Lists
            //<> means that the instance is a "generic" type
            //IEnumerable: I means Instance. IEnumerable means you can supply an instance of a class.
            var numbers = new List<int>() {10,20,30,40};
            numbers.Add(10);
            numbers.AddRange(new int[3] {50, 60, 70});

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();
            Console.WriteLine(numbers.IndexOf(1));
            Console.WriteLine(numbers.LastIndexOf(1));
            Console.WriteLine("Count: " + numbers.Count);

            //numbers.Remove(10); //this removes the first time that 10 appears
           
            
            
            //the foreach below will fail due to removing a value and shortening the list
            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //    if (num == 10)
            //        numbers.Remove(num);
            //}

            //the below for loop allows for the removal of the values. When this happens number.Count gets smaller
            //and the for loop will recalculate numbers.Count every time it runs. This way we never access a 
            //value outside of the list.
            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 10)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            numbers.Clear(); //this removes all elements of the list.
            Console.WriteLine(numbers.Count);
            */


            /*
            // When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

            //If no one likes your post, it doesn't display anything.
            //    If only one person likes your post, it displays: [Friend's Name] likes your post.
            //    If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
            //    If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
            //Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
            
            var listOfNames = new List<string>();
            do
            {
                Console.WriteLine("Enter a name:");
                string userValue = Console.ReadLine();
                if (String.IsNullOrEmpty(userValue))
                {
                    break;
                }
                else
                {
                    listOfNames.Add(userValue);
                }
            } while (true);

            if (listOfNames.Any())
            {
                for (var i = 0; i < listOfNames.Count; i++)
                {
                    if (i == 0)
                    {
                        Console.Write(listOfNames[0]);
                    }
                    else if (i == 1)
                    {
                        Console.Write(", " + listOfNames[1]);
                    }
                    else
                    {
                        var numRemainingFriends = listOfNames.Count - 2;
                        Console.Write(" and " + numRemainingFriends + " others");
                        break;
                    }
                }

                Console.WriteLine(" have liked your post");
            }
            */

            /*
            //2 - Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string.Display the reversed name on the console.
            bool _abort = false;
            do
            {
                Console.WriteLine("Enter a name:");
                string userValue = Console.ReadLine();
                if (String.IsNullOrEmpty(userValue))
                {
                    Console.WriteLine("please enter a real name");
                    continue;
                }

                var reversed = new List<char>();
                reversed.AddRange(userValue.Reverse());
                foreach (var character in reversed)
                {
                    Console.Write(character);
                }


                _abort = true;

            } while (!_abort);





            */



            /*
            //3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
            int userInt = 0;
            var listOfNum = new List<int>();
            do
            {
                Console.WriteLine("Enter a number:");
                string userValue = Console.ReadLine();
                bool didParse = int.TryParse(userValue, out userInt);
                if (!didParse)
                {
                    Console.WriteLine("that is not a number.");
                    Console.WriteLine();
                    continue;
                }

                if (listOfNum.Contains(userInt))
                {
                    Console.WriteLine("Number has already been added, pick a new one");
                    continue;
                }

                listOfNum.Add(userInt);
            } while (listOfNum.Count < 5);

            listOfNum.Sort();
            Console.WriteLine("list of sorted numbers are: ");
            foreach (var num in listOfNum)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            */




            //Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates.Display the unique numbers that the user has entered.
            /*
            int userInt = 0;
            var listOfNum = new List<int>();
            var uniqueListOfNum = new List<int>();
            do
            {
                Console.WriteLine("Enter a number:");
                string userValue = Console.ReadLine();

                if (userValue == "Quit")
                    break;

                bool didParse = int.TryParse(userValue, out userInt);
                if (!didParse)
                {
                    Console.WriteLine("that is not a number.");
                    Console.WriteLine();
                    continue;
                }


                listOfNum.Add(userInt);
            } while (true);

            foreach (var num in listOfNum)
            {
                if(!uniqueListOfNum.Contains(num))
                {
                    uniqueListOfNum.Add(num);//don't actually need list list. Keeping here if future problem requires the code.
                    Console.WriteLine(num);
                }
            }
            */



            var listOfNum = new List<int>();
            do
            {
                Console.WriteLine("Enter a comma seperated list of numbers:");
                string userValue = Console.ReadLine();

                if (String.IsNullOrEmpty(userValue))
                {
                    Console.WriteLine("Invalid List, try again");
                    continue;
                }

                try
                {
                    listOfNum = userValue.Split(",").Select(int.Parse).ToList();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid List, try again");
                    continue;
                }
                if (listOfNum.Count < 3)
                {
                    Console.WriteLine("Invalid List, try again");
                    continue;
                }

                break;
            } while (true);

            listOfNum.Sort();
            Console.WriteLine("{0}, {1}, {2}", listOfNum[0], listOfNum[1], listOfNum[2]);
        }
    }
}
