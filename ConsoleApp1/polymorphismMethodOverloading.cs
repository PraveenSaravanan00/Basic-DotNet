using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class polymorphismMethodOverloading
    {
        
            public void AddNumbers(int a, int b)
            {
                Console.WriteLine( a + b);
            }
            public void AddNumbers(int a, int b, int c)
            {
                Console.WriteLine( a + b + c);
            }
        class numbers
        {
            static void main(string[] args)
            {
            polymorphismMethodOverloading c = new polymorphismMethodOverloading();
                c.AddNumbers(1, 2);
                c.AddNumbers(1, 2, 3);
            }
        }
    }
}
