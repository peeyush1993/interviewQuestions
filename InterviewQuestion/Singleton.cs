using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace InterviewQuestion
{
   public sealed class Singleton
    {
        private Singleton()
        {
        }
        private static Singleton _instance = null;
        private static readonly Object obj = new object();
        public static Singleton GetSingletonInstance()
        {
            //thread safe singleton
            lock (obj)
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
            }
            return _instance;
        }

        public void MethodInSingletonClass()
        { 
        Console.WriteLine("this method will call from singleton object");
        }

    }
}
