﻿using System;
using System.Text;
using System.Collections.Generic;

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

        public static string ReverseNew(string inputString)
        {
            if (String.IsNullOrEmpty(inputString))
            {
                throw new ArgumentException($"Wrong input: {inputString} is null or empty!");
            }

            int size = inputString.Length;
            for(int i=size-1;i>-1;i--)
            {
                inputString += inputString[i];
            }
            inputString = inputString.Remove(0, size);
            return inputString;
        }

        static void Main(string[] args)
        {
            string reverseTo = "abc";
            Console.WriteLine(ReverseNew(reverseTo));
        }
    }
}
