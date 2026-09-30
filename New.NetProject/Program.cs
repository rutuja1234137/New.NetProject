using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace New.NetProject
{
    internal class Program
    {


        void swapping()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("before swapping a is=" + a);
            Console.WriteLine("before swapping b is=" + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("after swapping a is=" + a);
            Console.WriteLine("after swapping b is=" + b);
        }
    
   
        
static void Main(string[] args)
        {
            Program p = new Program();
            p.swapping();
        }
    }
}
