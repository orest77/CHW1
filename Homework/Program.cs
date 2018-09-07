using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //HW1.a
            #region
            //Console.Write("Enter digit: ");
            //int side = Int32.Parse(Console.ReadLine());


            //int asquare = side * side;
            //int perimetr = side * 4;
            //Console.WriteLine("Asquare is: {0}", asquare);
            //Console.WriteLine("Perimetr is: {0}", perimetr);

            //Console.ReadKey();
            #endregion

            //HW1.b
            #region
            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("How old are you,{0}?", name);
            //int age = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("{0} your age {1} ", name, age);

            //Console.ReadKey();
            #endregion

            //HW1.d
            #region
            Console.Write("Enter radius :");
            double circleRadius = double.Parse(Console.ReadLine());


            double circleLength = 2 * Math.PI * circleRadius;
            double circleArea = Math.PI * circleRadius * circleRadius;
            double circleVolume = 4 / 3 * Math.PI * circleRadius * circleRadius * circleRadius;
            Console.WriteLine("Circle length is: {0}", circleLength);
            Console.WriteLine("Circle area is: {0}", circleArea);
            Console.WriteLine("Circle volume is: {0}", circleVolume);

            Console.ReadKey();
            #endregion

        }
    }
}
