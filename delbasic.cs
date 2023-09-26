using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Delegates_and_event.delbasic;

namespace Delegates_and_event
{
    internal class delbasic
    {
        public delegate int mydelegate(int x, int y);

        public delegate double delegate1(double x, double y);
        public class calculation
        {
            public int addition(int a, int b)
            {
                return a + b;
            }
            public double division(double a, double b)
            {
                return a / b;
            }

        }
    }
    public class demo
    {
        static void Main(string[] args)
        {
            Calculation c1 = new Calculation();
            MyDelegates = myDelegate = new delegate (c1.addition);

            int result = mydelegate.Invoked(45, 55);
            Console.WriteLine(result);
        }
    }
}
