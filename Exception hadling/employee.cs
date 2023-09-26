using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_and_event.Exception_hadling
{
    internal class employee
    {
        public int salary;
        public string Name;

        public Employee(int salary, string name)
        {
            this.salary = salary;
            this.Name = name;
        }
        public string Tostring()
        {
            return $"{salary},{Name}";
        }
        public class employee
        {
            static void Main(string[] args)
            {
                try
                {
                    string str = null;
                    if (string.IsNullOrEmpty(str))
                    {
                        throw new Exception("name is requirde");
                    }
                    Console.WriteLine(str);

                }
                catch
                {
                    Console.WriteLine(ex.message);
                }
                finally
                {
                    Console.WriteLine("inside the finally block");
                }
            }
        }
    }
}
