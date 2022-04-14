using System;

namespace taskmain2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var number = 128;
            var sum = 0; 

            while (number > 0)
            {
                var reminder = number % 10;
                sum = sum + reminder;
                    number = number / 10;
             
            }
            Console.WriteLine(sum);
        }
    }
}
