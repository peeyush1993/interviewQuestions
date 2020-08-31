using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestion
{
    //We can call an overloaded constructor from another constructor using this keyword but the constructor must be belong 
    //to the same class, because this keyword is pointing the members of same class in which this is used.
    //This type of calling the overloaded constructor also termed as Constructor Chaining.

    public class ConstructorChaining
    {

        // Private data members 
        private int Length, Height;
        private double Width;

        public ConstructorChaining()
        {
            Console.WriteLine("Default Constructor Invoked");
        }
        public ConstructorChaining(int i, double d) : this()
        {
            Console.WriteLine("Parameterized Constructor in 2nd Constructor");
            Length = i;
            Width = d;
        }
        public ConstructorChaining(int i, double w, int h) : this(i, w)
        {
            Console.WriteLine("Parameterized Constructor in 3rd Constructor");
            Height = h;
        }

        public double Volume()
        {
            return Length * Height * Width;
        }
    }
}
