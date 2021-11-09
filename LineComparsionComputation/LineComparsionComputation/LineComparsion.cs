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
        public double checklength()
        {
            double result = Math.Sqrt(Math.Pow(this.xTwo - this.xOne, 2) + (Math.Pow(this.yTwo - this.yOne, 2)));
            Console.WriteLine("length of a line is " + result);
            return result;
        }
        public void checkcomparsion(double lengthOne,double lengthTwo)
        {
            if (lengthOne.CompareTo(lengthTwo) == 0)
            {
                Console.WriteLine("lines are equal");
            }
            if (lengthOne.CompareTo(lengthTwo) < 0)
            {
                Console.WriteLine("the second line is greater than the first line");            
            }
            if(lengthOne.CompareTo(lengthTwo) > 0)
            {
                Console.WriteLine("the first line is greater than the second line");
            }
        }
    }
}
