using System;

namespace LINQ_CONCEPTS
{
    public class MixedLinq
    {
        public static void Solution()
        {
            //1.Data Source

            List<int> ListNumber = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };

            //2.Query
            var Methods = (from obj in ListNumber
                           where obj <= 5
                           select obj).Average();

            //3.Execution

            Console.WriteLine(Methods);
            Console.ReadKey();
        }
    }
}
