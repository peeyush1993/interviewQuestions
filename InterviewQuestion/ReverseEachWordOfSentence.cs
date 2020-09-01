using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestion
{
    public class ReverseEachWordOfSentence
    {
        //this is the test string
        public void ReverseEachWord(string str)
        {
            StringBuilder res = new StringBuilder();
            string[] arr = str.Split(" ");
            foreach (var s in arr)
            {
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    res.Append(s[i]);
                }
                res.Append(" ");
            }
            Console.WriteLine("Given the sentance={0}", str);
            Console.WriteLine("Reverse the sentance={0}",res);
        }

    }
}
