using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestion
{
    public class MaxOccuranceOfChar
    {

        //MaxOccuranceOfChar _stringDT = new MaxOccuranceOfChar();
        ////Check multiple occurance of a char in string  
        //var value7 = _stringDT.CheckMaxOccuranceOfChar("Hello World");
        //Console.WriteLine("Multiple occurance char in 'Hello world' is = " + value7);

        public char? CheckMaxOccuranceOfChar(string _title)
        {
            char? maxOccuranceChar = null;
            int maxOccuranceValue = 0;

            if (string.IsNullOrEmpty(_title))
                return null;

            _title = _title.ToLower().Trim();
            char[] arr = _title.ToCharArray();

            Dictionary<char, int> _dictionary = new Dictionary<char, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != ' ')
                {
                    if (!_dictionary.ContainsKey(arr[i]))
                    {
                        _dictionary.Add(arr[i], 1);
                    }
                    else
                    {
                        _dictionary[arr[i]]++;
                    }
                }
            }


            foreach (KeyValuePair<char, int> item in _dictionary)
            {
                if (item.Value > maxOccuranceValue)
                {
                    maxOccuranceChar = item.Key;
                    maxOccuranceValue = item.Value;
                }
            }

            return maxOccuranceChar;
        }
    }
}
