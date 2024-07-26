using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class data
    {
        public int empId;
        public abstract void show();
    }
    public class Absraction : data
    {
        public override void show()
        {
            Console.WriteLine("abstraction");
        }
    }
    class @mains
    {
        static void main(string[] args)
        {
            Absraction u = new ();
            u.show();
        }
    }
}
