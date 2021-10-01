using System;


namespace ReverseString
{
    class Program
    {
        private static string ReverseString(string inputString)
        {
            if (String.IsNullOrEmpty(inputString))
            {
                throw new ArgumentException($"Wrong input {inputString}");
            }

            string temp = "";
            for (int i = inputString.Length - 1; i > -1; i--)
            {
                temp += inputString[i];
            }
            return temp;

        }

        static void Main(string[] args)
        {
            string reverseTo = ""; 
            Console.WriteLine(ReverseString(reverseTo));
        }
    }
}
