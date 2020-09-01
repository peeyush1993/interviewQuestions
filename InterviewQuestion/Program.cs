using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InterviewQuestion
{
    public class Program
    {

        static void Main(string[] args)
        {
           
            //palindrom
            string s = "radar";
            Console.WriteLine(s.Equals("radar") ? "This string is palindrom" : "no palindrom");
           
            //ReverseEachWordOfSentence
            ReverseEachWordOfSentence revrs = new ReverseEachWordOfSentence();
            revrs.ReverseEachWord("this is the test");

            //ReverseString
            ReverseString reverseString = new ReverseString();
            reverseString.ReverseStringMethod("peeyush anand");

            //FindDuplicateCharactersInString
            FindDuplicateCharactersInString fd = new FindDuplicateCharactersInString();
            string ss = "googlee";
            Tuple<StringBuilder, StringBuilder, Dictionary<char, int>> d = fd.DuplicateCharacterInString(ss);
            Console.WriteLine("Given String={0}", ss);
            Console.WriteLine("Unique Record={0}", d.Item1);
            Console.WriteLine("duplicate  character={0}", d.Item2);

            foreach (var item in d.Item3)
            {
                Console.WriteLine("---------------");
                Console.WriteLine(string.Format("{0} Count: {1}", item.Key, item.Value));
                Console.WriteLine("---------------");
            }


            CopyConstructor copyConstructor = new CopyConstructor(1, 2);
            CopyConstructor g = new CopyConstructor(copyConstructor);
            Console.WriteLine("x={0} y={1}", g.x, g.y);
            // Invoking 3rd Constructor 
            // here Constructor chaining 
            // came into existence 
            ConstructorChaining constructor = new ConstructorChaining(10, 20.5, 30);

            // calling the 'Volume' Method 
            Console.WriteLine("Volume is : {0}", constructor.Volume());
            //ExtentionMethod
            ExtentionMethod em = new ExtentionMethod();
            int result = em.Sum(1, 2);
            Console.WriteLine("Sum={0}", result);
            //Extended Extention class
            string stringResult = em.getString("peeyush");
            Console.WriteLine("Extended with string={0}", stringResult);

            //B dd = new B();
            //dd.Add(1, 1);

            //Console.WriteLine(dd.Add(1, 1));
            Console.ReadKey();
        }
    }

    public static class ExtendingExtentionClass
    {
        public static string getString(this ExtentionMethod extention, string a)
        {
            return a;

        }
    }
    public class A
    {
        public int Add(int i, int j)
        {

            return i + j;
        }
        //string Add(int i, int j) {
        //    return "";
        //}
    }
    public class B : A
    {

        public string Add(int i, int j)
        {
            return "hello" + (i + j);
        }
    }

}
