using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparsionComputation
{
    class LineComparsion
    {
        double xOne, xTwo, yOne, yTwo;
        public LineComparsion(double xOne,double xTwo,double yOne,double yTwo)
        {
            this.xOne = xOne;
            this.xTwo = xTwo;
            this.yOne = yOne;
            this.yTwo = yTwo;
        }
        public void checklength()
        {
            Console.WriteLine("length of a line is " + Math.Sqrt(Math.Pow(this.xTwo - this.xOne, 2) + (Math.Pow(this.yTwo - this.yOne, 2))));
        }
    }
}
