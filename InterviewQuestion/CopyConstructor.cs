using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace InterviewQuestion
{
    //  A parameterized constructor that contains a parameter of same class type is called a copy constructor.Basically, copy constructor 
    //is a constructor which copies a data of one object into another object. Its main use is to initialize a new instance to the values 
    //of an existing instance.
    public class CopyConstructor
    {
        public int x, y;

        // 1st Constructor 
        public CopyConstructor(int a, int b)
        {
            x = a;
            y = b;
        }

        // Copy Constructor of 1st Constructor 
        public CopyConstructor(CopyConstructor obj)
        {
            x = obj.x;
            y = obj.y;
        }

        //Note:
        //Static Constructor cannot be overload, because Static Constructors are parameterless constructor, but for overloading, 
        //we must need parameterized constructor.
        //Private Constructor can be overloaded and we can use that by instance of this class inside the same class. 
        //Private members cannot be accessed from outside the class.
    }
}
