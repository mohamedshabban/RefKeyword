# RefKeyword
The ref keyword in C# is used for passing or returning references of values to or from Methods. Basically, it means that any change made to a value that is passed by reference will reflect this change since you are modifying the value at the address and not just the value. It can be implemented in the following cases:
 

To pass an argument to a method by its reference.
To define a method signature to return a reference of the variable.
To declare a struct as a ref struct
As local reference

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
