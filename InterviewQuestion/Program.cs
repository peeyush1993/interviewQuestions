using System;

namespace InterviewQuestion
{
   public class Program
    {
        static void Main(string[] args)
        {
            B dd = new B();
            dd.Add(1, 1);

            Console.WriteLine(dd.Add(1, 1));
            Console.ReadKey();
        }
    }

    public class A
    {
      public  int Add(int i, int j)
        {

            return i + j;
        }
        //string Add(int i, int j) {
        //    return "";
        //}
    }
    public class B:A {

     public string Add(int i, int j)
        {
            return "hello"+(i+j);
        }
    }

}
