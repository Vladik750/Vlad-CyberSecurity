using System;

namespace ReverseString
{
    public class ReverseStr
    {
       
        public static string Reverse(string inputString)
        {
            if (String.IsNullOrEmpty(inputString))
            {
                throw new ArgumentException($"Wrong input: {inputString} is null or empty!");
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
            string reverseTo ="";
            Console.WriteLine(Reverse(reverseTo));
        }
    }
}
