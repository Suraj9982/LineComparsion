using System;

namespace LineComparsionComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Line Comaprsion Computation");
            LineComparsion length = new LineComparsion(2.0,3.0,1.0,2.0);
            length.checklength();
        }
    }
}
