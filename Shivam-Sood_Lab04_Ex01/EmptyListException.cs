using System;

namespace Shivam_Sood_Lab04_Ex01
{
    public class EmptyListException : Exception
    {
        // parameterless constructor
        public EmptyListException() : base("The list is empty") { }

        // one-parameter constructor
        public EmptyListException(string name)
           : base($"The {name} is empty") { }

        // two-parameter constructor
        public EmptyListException(string exception, Exception inner)
           : base(exception, inner) { }
    }
}
