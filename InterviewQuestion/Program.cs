using System;

namespace InterviewQuestion
{
    public class Program
    {
        static void Main(string[] args)
        {
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
