using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    class Program
    {
        public void perimeter()//p=2(l+b)
        {
            Console.WriteLine("Enter length and breadth of the rectangle:");
            int l= Convert.ToInt32(Console.ReadLine()); 
            int b = Convert.ToInt32(Console.ReadLine());
            double p = 2 * (l + b);
            Console.WriteLine("Expected Output:"+p); 

        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.perimeter();
            Console.ReadLine();
        }
    }
}
