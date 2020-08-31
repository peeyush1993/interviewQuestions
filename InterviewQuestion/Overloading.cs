using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestion
{
    public class Overloading
    {
        // Method overloading can be done by changing:

        //The number of parameters in two methods.
        //The data types of the parameters of methods.
        //The Order of the parameters of methods.

        //type of parameter
        public string Sum(double i, int j)
        {
            return "test" + i + j;
        }
        
        //order of parameter 
        public string Sum(int i, double j)
        {
            return "test" + i + j;
        }

        //number of parameter
        public double Sum(int w, double d, string s)
        {
            double dddd = w + d + Convert.ToDouble(s);
            return dddd;
        }
    }
}
