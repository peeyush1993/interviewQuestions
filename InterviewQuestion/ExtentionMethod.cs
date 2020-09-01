using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestion
{
    public class ExtentionMethod
    {
        //Advantages:
        //The main advantage of the extension method is to add new methods in the existing class without using inheritance.
        //You can add new methods in the existing class without modifying the source code of the existing class.
        //It can also work with sealed class.
        public ExtentionMethod()
        {
            Singleton singleton = Singleton.GetSingletonInstance();
            singleton.MethodInSingletonClass();
           // Logger logger = Logger.GetLoggerInstance();
            //logger.ExceptionLogwriter("logging exception", 1);
            //will retrun existing singleton object;
            Singleton singleton2 = Singleton.GetSingletonInstance();


        }
        public int Sum(int a, int b)
        {
            return a + b;
        }
    }


}
