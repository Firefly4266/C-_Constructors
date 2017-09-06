using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            Console.WriteLine("The area of the rectangle is {0}", r.GetArea());
            Rectangle r2 = new Rectangle(5, 10);
            Console.WriteLine("The area of the r2 rectangle is {0}.", r2.GetArea());
        }
    }
}
