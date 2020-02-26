using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack<T>
    {
        // https://www.freecodecamp.org/news/tdd-explanation-hands-on-practice-with-c-a0124338be44/

        // Members
        private T[] stackArray;
        private int maximumLength;

        // Properties
        public int Size { get; private set; }

        // Constructor
        public Stack (int length)
        {
            maximumLength = length;
            stackArray = new T[length];
        }
    }
}
