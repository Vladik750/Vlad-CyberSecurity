using System;
using System.Linq;
using System.Collections.Generic;

namespace Parentheses
{
    public class Paren
    {
        public Dictionary<char, char> parentheses = new Dictionary<char, char>
        {
            {'(',')' },
            {'[',']' },
            {'{','}' }
        };

        public bool IsOpening(char c)
        {
            if (c == '{' || c == '(' || c == '[')
            {
                return true;
            }
            else return false;

        }

        public bool ValidatedInput(string s)
        {
            if(String.IsNullOrEmpty(s))
            {
                throw new ArgumentException("Wrong input: Input string is null or empty!");
                //return false;
            }
            if(s.Length%2 !=0)
            {
                throw new ArgumentException("Wrong input: Input string length is odd!");
            }
            for(int i=0;i<s.Length;i++)
            {
                if(parentheses.ContainsKey(s[i])|| parentheses.ContainsValue(s[i]))
                {
                    continue;
                }
                else
                {
                    throw new ArgumentException("Wrong input: Input string should contain only parentheses!");
                }
            }
            return true;
            
        }

        public bool IsValidByStack(string s)
        {
            if (!ValidatedInput(s) || !IsOpening(s[0]) || IsOpening(s[s.Length-1]))
            {
                return false; 
            }
            Stack<char> stack = new Stack<char>(s.Length);
            for(int i=0;i<s.Length;i++)
            {
                stack.Push(s[i]);
                if(stack.Count >=2)
                {
                    char last = stack.ElementAt<char>(0);
                    char preLast = stack.ElementAt<char>(1);
                    foreach(var item in parentheses)
                    {
                        if (item.Key == preLast && item.Value == last)
                        {
                            stack.Pop();
                            stack.Pop();
                        }
                    }
                }
            }
            if (stack.Count == 0)
            {
                return true;
            }
            else return false;
        }

        public bool IsValid(string s)
        {
            if ( !ValidatedInput(s) || !IsOpening(s[0]) || IsOpening(s[s.Length - 1]))
            {
                return false;
            }
            int size = s.Length;
            int counter = 0;

            while (counter < size*size)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    foreach (var item in parentheses)
                    {  
                        if (item.Key == s[i] && item.Value == s[i + 1])
                        {
                            s = s.Remove(i, 2);
                            if (String.IsNullOrEmpty(s))
                            {
                                return true;
                            }
                            i = 0; 
                        } 
                    }
                    counter++;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            Paren p = new Paren();
            string s = "[})[()]{}(";
            
            Console.WriteLine(p.IsValidByStack(s));
        }
    }
}
