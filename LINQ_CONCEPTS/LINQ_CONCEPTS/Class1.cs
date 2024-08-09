using System;
using System.Linq;
namespace LINQDemo
{
    public class Class1
    {
        public static void Solution()
        {
            int[] intNumbers = new int[] { 10, 30, 50, 40, 60, 20, 70, 90, 80, 100 };
 
                      //Using Method Syntax
            int MSTotal = intNumbers.Where(num => num > 50).Sum();

                     //Using Query Syntax
            int QSTotal = (from num in intNumbers
                           where num > 50
                           select num).Sum();

            Console.WriteLine("Sum = " + QSTotal);

            Console.ReadKey();
        }
    }
}
