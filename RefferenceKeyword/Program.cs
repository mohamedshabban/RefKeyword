using System;

namespace RefferenceKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            AddNumber(number);
            Console.WriteLine(number);

            AddNumber(ref number);
            Console.WriteLine(number);


        }
        public static void AddNumber(int number)
        {
            number++;
        }
        public static void AddNumber(ref int number)
        {
            number++;
        }
    }
}
