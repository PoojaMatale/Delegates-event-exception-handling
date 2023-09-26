using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_and_event.Exception_hadling
{
    internal class name
    {
        public class NameException : Exception
        {
            public NameException(string error) : base(error)
            {

            }
        }
        public class Student
        {
            public Student(string name)
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new NameException("name is required");
                }
            }
        }
        public class program
        {
            static void Main(string[] args)
            {
                try
                {
                    Student stu = new Student(null);
                }
                catch (NameException e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }

    }
}
