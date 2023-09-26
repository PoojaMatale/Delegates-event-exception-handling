using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_and_event
{
    internal class studentdemo
    {
        public delegate void myDelegate();

        public class Student
        {
            public event myDelegate fail;
            public event myDelegate pass;

            public void Acceptpercentage(double percentage)
            {
                if (percentage > 40)
                {
                    fail();
                }
                else
                {
                    pass();
                }
            }
        }
        public class message
        {
            public void SuccessMessage()
            {
                Console.WriteLine("you are pass in exam");
            }
            public void FailMessage()
            {
                Console.WriteLine("you are fail in exam");
            }
        }
        public class program
        {
            static void Main(string[] args)
            {
                try
                {
                    Student stud1 = new Student();
                    message msg = new message();
                    stud1.fail += delegate () { Console.WriteLine("you are fail"); };
                    stud1.pass += delegate () { Console.WriteLine("you are pass"); };



                    //stud1.fail += new myDelegate(msg.FailMessage);
                    //stud1.pass += new myDelegate(msg.SuccessMessage);

                    stud1.Acceptpercentage(65);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }


    }
    
}
