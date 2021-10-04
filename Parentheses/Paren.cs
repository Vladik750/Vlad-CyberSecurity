using System;
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

        public bool isOpening(char c)
        {
            if (c == '{' || c == '(' || c == '[')
            {
                return true;
            }
            else return false;

        }

        public bool IsValid(string s)
        {
            if ( String.IsNullOrEmpty(s) || s.Length % 2 != 0 || !isOpening(s[0]))//input validation
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
            string s = "]";
            Console.WriteLine(p.IsValid(s));
            
        }
    }
}
