using System;

namespace LINQ_CONCEPTS
{
    public class LinqMethods
    {
        public static void Solution()
        {

            //1.Data Source

            List<int> ListName = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };

            //2.Query

            var QuerySyntax = ListName.Where(obj=>obj>5).ToList();

            //3.Execution
            foreach(var item in QuerySyntax)
            {
                Console.WriteLine(item + " ");
            }
            Console.ReadKey();
        }
    }
}
