using Microsoft.VisualBasic.CompilerServices;

namespace CSharpUdemy.Classes
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }


        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}