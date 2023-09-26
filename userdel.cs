using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_and_event
{
    internal class userdel
    {
        public delegate string UserdelDelegate(string name);


        public class name
        {
            public string Acceptname(string name)
            {
                return name;

            }
            public string ToLowercase()
            {
                return Lowercase
            }

            private static string ToUpper()
            {
                throw new NotImplementedException();
            }

            public String Accept(string p)
            {
                return name.ToLower();
            }


        }
    }
    public class user
    {
        static void Main(string[] args)
        {
            user user = new user();
            myDelegate myDelegate = new myDelegate(user.Accept);
            myDelegate += new myDelegate(user.Toupper);
            myDelegate += new myDelegate(user.Toupper);


        }
    }
}
    

