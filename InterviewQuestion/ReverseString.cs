using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace InterviewQuestion
{
    public class ReverseString
    {

        public void ReverseStringMethod(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                Console.WriteLine("string is empty");

            StringBuilder sb = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }
            Console.WriteLine("Given Sting ={0}", s);
            Console.WriteLine("Reversed Sting ={0}", sb);
        }
    }
}
