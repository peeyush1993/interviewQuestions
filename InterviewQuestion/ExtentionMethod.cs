using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestion
{
   public class ExtentionMethod
    {
        public ExtentionMethod()
        {
            Singleton singleton = Singleton.GetSingletonInstance();
            singleton.MethodInSingletonClass();
            Logger logger = Logger.GetLoggerInstance();
            logger.ExceptionLogwriter("logging exception", 1);
            //will retrun existing singleton object;
            Singleton singleton2 = Singleton.GetSingletonInstance();

      
        }
        public int  Sum(int a, int b)
        {
            return a + b;
        }
    }


}
