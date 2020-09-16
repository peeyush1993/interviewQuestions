using System;
using System.Text;

namespace InterviewQuestion
{
    class Solution
    {
        public static void PrintEvenOdd()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                //input.Add(Console.ReadLine());      
                print(Console.ReadLine());
            }


        }

        public static void print(string s)
        {

            StringBuilder evenWord = new StringBuilder();
            StringBuilder oddWord = new StringBuilder();

            char[] f = s.ToCharArray();
            for (int j = 0; j < f.Length; j++)
            {

                if (j % 2 == 0)
                {
                    evenWord.Append(f[j]);
                }
                else
                {
                    oddWord.Append(f[j]);
                }
            }
            Console.WriteLine(evenWord + " " + oddWord);

        }
    }
}
