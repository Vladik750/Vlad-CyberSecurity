using System;

namespace ReverseString
{
    public class ReverseStr
    {

        public static string Reverse(string inputString)
        {
            if (String.IsNullOrEmpty(inputString))
            {
                throw new ArgumentException($"Wrong input: input string is null or empty!");
            }

            string temp = "";
            for (int i = inputString.Length - 1; i > -1; i--)
            {
                temp += inputString[i];
            }
            return temp;
        }

        public static string ReverseNew(string inputString)
        {
            if (String.IsNullOrEmpty(inputString))
            {
                throw new ArgumentException($"Wrong input: input string is null or empty!");
            }

            int size = inputString.Length;
            for (int i = size - 1; i > -1; i--)
            {
                inputString += inputString[i];
            }
            inputString = inputString.Remove(0, size);
            return inputString;
        }

        public static string ReverseXOR(string inputString)
        {
            if (String.IsNullOrEmpty(inputString))
            {
                throw new ArgumentException("Wrong input: Input string is null or empty!");
            }
            char[] input = inputString.ToCharArray();
            
            int start = 0;
            int end = input.Length - 1;

            while (start < end)
            {
                input[start] ^= input[end];
                input[end] ^= input[start];
                input[start] ^= input[end];

                ++start;
                --end;
            }
            return String.Join("", input);
        }


        static void Main(string[] args)
        {
            string reverseTo = "rev";
            Console.WriteLine(ReverseXOR(reverseTo));
        }
    }
}
