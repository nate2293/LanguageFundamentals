namespace LanguageFundamentals
{
    internal class Adding
    {
        public static int SumOfTwo(int a, int b)        // Expecting 2 intergers and returning 1
        {
            return a + b;       // Sum of two intergers 
        }

        static void Main()
        {
            // Display Output -  'WriteLine(); create a gap between each number printed 

            int result = SumOfTwo(1, 2);        // Output - 3
            Console.WriteLine(result);
            Console.WriteLine();

            result = SumOfTwo(5, 6);        // Output - 11
            Console.WriteLine(result);
            Console.WriteLine();

            result = SumOfTwo(8, 5);        // Output - 13
            Console.WriteLine(result);
            Console.WriteLine();

        }
    }
}

// Projects that I am practicing to enhance my math and use of numbers further.

// Task - Create a function of two intergers that returns their sum.