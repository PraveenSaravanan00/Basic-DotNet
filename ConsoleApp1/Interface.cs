using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface Idata
    {
        public void empname(string name);
        public void DOB(string dob);
    }
    public interface Idata2 { 
        public void mobileNo(int mobileNumber); 
    }

    public class Interface : Idata, Idata2
    {
        public void DOB(string dob)
        {
            Console.WriteLine(dob);
        }

        public void empname(string name)
        {
            Console.WriteLine(name);
        }

        public void mobileNo(int mobileNumber)
        {
            Console.WriteLine(mobileNumber);
        }
        static void main(string[] args)
        {
            Interface IF= new Interface();
            IF.empname("sandy");
            IF.DOB("28/03/2002");
            IF.mobileNo(63741485);
        }
    }
}
