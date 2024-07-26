using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class polymorphismOverriding
    {
            public virtual void GetInfo()
            {
                Console.WriteLine("DotNet");
            }
        }

        public class emponame : polymorphismOverriding
    {
            public override void GetInfo()
            {
                Console.WriteLine("Ms SQL");
            }
        }
        class cmpData
        {
            static void Main(string[] args)
            {
            emponame d = new emponame();
                d.GetInfo();
            polymorphismOverriding b = new polymorphismOverriding();
                b.GetInfo();
            }
        }
    }

