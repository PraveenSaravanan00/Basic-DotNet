using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class encapsulation
    {
        private string location;
        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }
 
    }
    class Program
    {
        static void main(string[] args)
        {
            encapsulation u = new ();
            u.Location = "TamilNadu";
            Console.WriteLine("Location: " + u.Location);
        }
    }
}

