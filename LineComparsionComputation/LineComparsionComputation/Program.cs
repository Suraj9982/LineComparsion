using System;

namespace LineComparsionComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Line Comaprsion Computation");
            LineComparsion lineone = new LineComparsion(2.0,3.0,1.0,3.0);
            double lengthOne = lineone.checklength();
            LineComparsion lineTwo = new LineComparsion(2.0, 3.0, 1.0, 3.0);
            double lengthtwo = lineTwo.checklength();
            lineTwo.checkcomparsion(lengthOne, lengthtwo);
        }
    }
}
