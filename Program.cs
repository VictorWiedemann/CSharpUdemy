using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using CSharpUdemy.Classes;




namespace CSharpUdemy
{

    /*
    //Intermediate here:
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var person = new Person();
            //person.Name = "John";
            //person.Introduce("vic");

            //same result as the above 3 lines
            var person = Person.Parse("Rick");
            person.Introduce("rock");
        }
    }
    */

/*
    public class PresentationObject
    {
        //common shared code
        public int Width { get; set; }
        public int height { get; set; }

        public void Copy()
        {
            Console.WriteLine("was copied");
        }

        public void paste()
        {
            Console.WriteLine("was pasted");
        }
    }

    public class Text : PresentationObject
    {
        //code specific to Text
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink()
        {
            Console.WriteLine("hyperlink added here");
        }
    }
    */

    class Program
    {




        static void Main(string[] args)
        {
            /*
            var customer = new Customer(1, "john");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            */

            /*
            try
            {
                var point = new Point(10, 20);

                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 220);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception e)
            {
                e = null;
                Console.WriteLine("unexpected error here.");
            }

            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1,2,34));
            */

            //var customer = new Customer(1);
            //customer.Orders.Add(new Order());
            //customer.Orders.Add(new Order());

            //Promote will auto-write over the list by accident and remove the two orders above. this is why you want readonly.
            //customer.Promote();

            //Console.WriteLine(customer.Orders.Count);








            //Access Modifiers:
            /*
             * Private -> only access to class itself.
             * Encapsulation sets fields as private
             *             useful for null checking
             *
             *
             * 
             */

            //below commented out lines are for public setters
            //var person = new Person
            //{
            //    Birthdate = new DateTime(1982, 1, 1)
            //};

            /*
            //new constructor is:
            var person = new Person(new DateTime(1982, 1, 1));

            Console.WriteLine(person.Age);
            */

            /*
            var cookie = new HttpCookie();
            cookie["name"] = "Mosh";
            Console.WriteLine(cookie["name"]);
            */




            //Section 3 

            //var text = new Text();
            //text. shows all text and presentation items.
            //text.Width = 100;
            //text.Copy();




            /*
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
            */




            //composition vs inheritence





            /*
            // Code here to read Classes question 1
            var stopwatch = new Stopwatch();
            stopwatch.StartTime();
            //stopwatch.StartTime();
            stopwatch.ReadTime();
            Thread.Sleep(5000);
            stopwatch.ReadTime();
            */

            /*
            //Classes question 2
            var post = new Post("text", "long text");
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.UpVote();
            post.UpVote();
            post.print();
            */


            //var customer = new Customer();





            //var car = new Car("gello");
            //var car2 = new Car();

            /*
            var text = new Text();
            Shape shape = text;

            //both of these values point to the same value.
            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width);
            */

            //StreamReader reader = new StreamReader(new MemoryStream());
            //var list = new ArrayList();
            //list.Add(1);
            //list.Add("Mosh");
            //list.Add(new Text());

            //var anotherList = new List<Shape>;


            //Shape shape = new Text();
            //when hovering over shape. you will get only the properties in the shape object, not the ones in Text.
            //shape.

            //to get access to the Text. Methods, you need to cast it
            //Text text = (Text) shape;




            /*
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            */


            //Method Overriding:
            /*
            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());
            shapes.Add(new Text());
            shapes.Add(new Triangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
            */

            //var oracleConn = new OracleConnection("ori test");
            //var sqlConn = new SqlConnection("sql conn");

            /*

            var fullName = "      Mosh Hamedani       ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("Trim: '{0}'", fullName.ToUpper());
            Console.WriteLine("Trim: '{0}'", fullName.ToUpperInvariant());
            Console.WriteLine("Trim: '{0}'", fullName.ToLower());
            var index = fullName.Split(' ');

            foreach (string strong in index)
            {
                Console.WriteLine(strong + "---");
            }

            var index2 = fullName.Trim().Split(' ');

            foreach (string strong in index2)
            {
                Console.WriteLine(strong + ">>>");
            }

            var newFullName = fullName.Replace("Mosh", "Moshfegh");
            Console.WriteLine(newFullName);

            var str = "35";
            var age = Convert.ToInt32(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));
           */
            /*

             var sentence =
                 "This isad akrhale rtas oiu uyta s; uth a l ; ori ty a slituhas lkrjth as;iourtyawkjsrethalsiurdhtalskjrbtasi;udht";
             Console.WriteLine(SummerizeText(sentence));


         }

         static string SummerizeText(string Text, int MaxLength = 20)
         {
             var summaryWords = new List<string>();

             if (Text.Length < maxLength)
                 return Text;

             var words = Text.Split(' ');
             var totalCharacters = 0;

             foreach (string word in words)
             {
                 totalCharacters += word.Length + 1; //1 for space
                 if (totalCharacters > maxLength)
                 {
                     break;
                 }
                 summaryWords.Add(word);

             }



             return String.Join(" ", summaryWords) + "...";
     */
            /*

           var builder = new StringBuilder("hello world");
            builder.Append('-', 10);
            Console.WriteLine(builder);
            Console.WriteLine();
            builder.AppendLine();
            Console.WriteLine(builder.Append("Header"));
            Console.WriteLine();
            builder.AppendLine();
            Console.WriteLine(builder.Append('-', 10));

            Console.WriteLine(builder.Replace('-', '+'));
            Console.WriteLine();

            Console.WriteLine(builder.Remove(0, 10));
            Console.WriteLine();

            builder.Insert(0, new string('-', 10));
            Console.WriteLine(builder);

            Console.WriteLine("First Char: " + builder[0]);



            //oooor
               var builder2 = new StringBuilder("hello world");

               builder2
                   .Append("test")
                   .Append("hello")
                   .AppendLine();

               Console.WriteLine(builder2);
               */

            /*
            var path = @"c:\temp\myfile2.jpg";
        
            //File is static methods, do not generate a class, but will need a security check per line of code
            //File.Copy("C:\\temp\\myfile.jpg, c:\\temp\\myfile2.jpg");
            //equiv to above
            //File.Copy(@"C:\temp\myfile.jpg", @"c:\temp\myfile2.jpg", true);
            //File.Delete();

            //creates a class. slower generation, but one security check only. Do this with many file methods.
            //var fileInfo = new FileInfo(path);
            //fileInfo.CopyTo("...");
            //fileInfo.Delete();
            //if (fileInfo.Exists)
            {
            }


            var directory = @"C:\Users\kirbo\Documents\code_projects";

            Directory.CreateDirectory(directory);
            //This will get a full directory list of all files in the temp folder and recursively all directories.
            var files = Directory.GetFiles(directory, "*", SearchOption.AllDirectories);
            
            //This will get a full directory list of all files above that are .sln type
            var files2 = Directory.GetFiles(directory, ".sln", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                //Console.WriteLine(file);
            }

            foreach (string file in files2)
            {
                Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(directory);

            foreach (string direct in directories)
            {
                Console.WriteLine(direct);
            }
            */

            /*
            var path = @"C:\Users\kirbo\Documents\code_projects\CSharpUdemy\CSharpUdemy\CSharpUdemy.sln";
            
            //this is a manual way to work
            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            //here is the C# library solution
            Console.WriteLine( "Extension: " + Path.GetExtension(path) );
            Console.WriteLine( "FileName: " + Path.GetFileName(path));
            Console.WriteLine("FileName: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("DirectoryName: " + Path.GetDirectoryName(path));
            */
            /*
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order {DatePlace = DateTime.Now, TotalPrice = 100f};
            orderProcessor.Process(order);
            */

            //var dbMigrator = new DbMigrator(new ConsoleLogger());



            /*
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.Encode();
            */


            var workflow = new Workflow();
            
            workflow.Add(new Init());
            workflow.Add(new CreateTemplate());
            workflow.Add(new GenerateNoise());
            
            var workflowEngine = new WorkflowEngine();

            workflowEngine.Run(workflow);

        }
    }
}

public interface IWorkflow
{
    void Add(ITask task);
    void Remove(ITask task);
    IEnumerable<ITask> GetTasks();
}

public interface ITask
{
    public void Execute();
}

public class Init : ITask
{
    public void Execute()
    {
        Console.WriteLine("starting program...");
    }
}

public class CreateTemplate : ITask
{
    public void Execute()
    {
        Console.WriteLine("creating template now...");
    }
}

public class GenerateNoise : ITask
{
    public void Execute()
    {
        Console.WriteLine("blah blah blah blah");
    }
}

public class Workflow : IWorkflow
{
    private readonly List<ITask> _tasks;

    public Workflow()
    {
        _tasks = new List<ITask>();
    }
    public void Add(ITask task)
    {
        _tasks.Add(task);
    }

    public void Remove(ITask task)
    {
        _tasks.Remove(task);
    }

    //this only returns a readonly version of the list.
    public IEnumerable<ITask> GetTasks()
    {
        return _tasks;
    }
}


public class WorkflowEngine
{
    public void Run(IWorkflow workflow)
    {
        foreach (var step in workflow.GetTasks())
        {
            step.Execute();
        }
    }

}


/*
public class HigherBeing
{
    public string Purity { get; private set; }
    protected bool isAvailable { get; set; }

    public HigherBeing(string purity)
    {
        Console.WriteLine($"I AM {purity} THE HIGHER BEING");
    }
}

public class Person : HigherBeing
{
    public int Dick { get; protected set; }

    public Person(int height, string name) : base(name)
    {
        Console.WriteLine("I AM THE PERSON" + height + name);
        isAvailable = true;
    }
}


public class Cat : Person
{
    public Cat() : base(60, "cat")
    {
        Console.WriteLine("I AM A Cat");
    }

    public void HangOut()
    {
        if (isAvailable)
        {
            Console.WriteLine("I can hang out");
        }
        else
        {
            Console.WriteLine("I am unavailable");
        }
    }


}
}
*/

/*class Program
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


/*
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
*/







/*
//Section 7 Dates & times!!!!!

var dateTime = new DateTime(2015, 1, 2); //get value that is Jan, 2cd, 2015
var now = DateTime.Now; //get the value right now
var today = DateTime.Today; //get the date


Console.WriteLine(now); // can also do now.ToString()
Console.WriteLine(today);
Console.WriteLine(now.Hour);
Console.WriteLine(now.Minute);

var tomorrow = now.AddDays(1);
var yesterday = now.AddDays(-1);

Console.WriteLine(now.ToLongDateString());
Console.WriteLine(now.ToShortDateString());
Console.WriteLine(now.ToLongTimeString());
Console.WriteLine(now.ToShortTimeString());

Console.WriteLine(now.ToString("O")); //the letter can be modified in MANY ways.
Console.WriteLine(now.ToString("yyyy-MMM-dd")); //the letter can be modified in MANY ways.




var timeSpan = new TimeSpan(1,2,3);
var timeSpan1 = TimeSpan.FromHours(1);

var start = DateTime.Now;
var end = DateTime.Now.AddMinutes(2);
var duration = end - start;
Console.WriteLine("time duration is: " + duration); // There will be a very short amount of time added to the 2 minutes. That could be due to the amount of time from setting start and setting end.



Console.WriteLine("minutes: " + timeSpan.Minutes); //this is 2 minutes as shown above
Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes); //this is 62.5 mintes (1 hour + 2 minutes + 3 seconds)

// Add and subtract. Both of these methods return a new timeSpan value
Console.WriteLine("Add Example " + timeSpan.Add(TimeSpan.FromMinutes(8))); //adds 8 min
Console.WriteLine("Subtract Example " + timeSpan.Subtract(TimeSpan.FromMinutes(8))); //takes away 8 min.

//conversions to and from strings
Console.WriteLine("ToString" + timeSpan.ToString()); //ToString isn't needed. Already taken care of.

Console.WriteLine("Parse: " + TimeSpan.Parse("1:02:03"));


*/
/*




}
}
}
}
*/
  