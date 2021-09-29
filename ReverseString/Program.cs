using System;
using System.Linq;
using System.Collections.Generic;


namespace ReverseString
{
    class Program
    {
        private static string ReverseString(string inputString)
        {
            if (inputString.Length == 0 || inputString == null)
            {
                return "Input error";
            }
            else
            {
                string temp = "";
                for (int i = inputString.Length - 1; i > -1; i--)
                {
                    temp += inputString[i];
                }
                return temp;
            }
        }

        static void Main(string[] args)
        {
            string reverseTo = "reverse"; //esrever
            Console.WriteLine(ReverseString(reverseTo));
        }
    }
}
