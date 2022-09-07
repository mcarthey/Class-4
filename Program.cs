using System;

namespace Class_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            var myUserInput = Console.ReadLine();

            try 
            { 
                var myValue = Int32.Parse(myUserInput);
            }
            catch (FormatException ex)
            {
                // intentionally ignoring exceptions
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            int myConvertedValue = 0;
            var isValid = Int32.TryParse(myUserInput, out myConvertedValue);

            if (isValid)
            {
                // continue processing
            }

            if (myConvertedValue != default(int))
            {
                // continue processing
            }

            Console.WriteLine($"myConvertedValue: {myConvertedValue}");

            int myInt1 = Convert.ToInt16(myUserInput);
            Console.WriteLine($"My Integer: {myInt1}");

            int myDoubledValue = 0;
            var output = MyMethod(myInt1, out myDoubledValue);
            Console.WriteLine($"output: {output}");
            Console.WriteLine($"myDoubledValue: {myDoubledValue}");
        }

        private static int MyMethod(int myInteger, out int doubleInteger)
        {
            doubleInteger = myInteger * myInteger;
            return myInteger;
        }
    }
}
