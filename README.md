# RefKeyword

internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            AddNumber(number);
            Console.WriteLine(number)///0;

            AddNumber(ref number);
            Console.WriteLine(number)///1;
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
