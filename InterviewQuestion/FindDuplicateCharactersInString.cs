using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace InterviewQuestion
{
    /// <summary>
    /// 1-Find duplicate character in string 
    /// 2- Find unique character 
    /// 3- count most char occurence 
    /// </summary>
    public class FindDuplicateCharactersInString
    {

        public int LetterCount(string str, char c)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i].ToString().IndexOf(c.ToString()) == 0)
                {
                    count++;
                }

            }
            return count;
        }
        public Tuple<StringBuilder, StringBuilder, Dictionary<char, int>> DuplicateCharacterInString(string str)
        {
            Tuple<StringBuilder, StringBuilder, Dictionary<char, int>> d;
            if (string.IsNullOrWhiteSpace(str))
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("empty string");
                d = Tuple.Create(stringBuilder, stringBuilder, new Dictionary<char, int>());
                return d;
            }
            StringBuilder uniquestring = new StringBuilder();
            StringBuilder duplicatechar = new StringBuilder();
            //google
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (uniquestring.ToString().IndexOf(str[i].ToString().ToLower()) == -1)
                {
                    uniquestring.Append(str[i]);
                    //  var count = str.Count(x => x == str[i]);
                    keyValuePairs.Add(str[i], LetterCount(str, str[i]));


                }
                else
                {
                    duplicatechar.Append(str[i]);
                }
               
            }
           
            d = Tuple.Create(uniquestring, duplicatechar, keyValuePairs);
            return d;
        }

    }
}
