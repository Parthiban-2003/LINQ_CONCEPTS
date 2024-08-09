
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_QURIESS
{
    public class LinqQuery
    {
        public static void Solution()
        {
            //1.Data Source

            List<int> IntegerList = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };

            //2.Query

            IEnumerable<int> QuerySyntax = from par in IntegerList
                              where par > 5
                              select par;

            //3.Execution

            foreach (var item in QuerySyntax)
            {
                Console.WriteLine(item + " ");
            }
            Console.ReadKey();
        }
    }
}
