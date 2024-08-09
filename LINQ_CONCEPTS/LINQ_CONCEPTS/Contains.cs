using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CONCEPTS
{
    public class Contains
    {
          public static void Solution()
          {
                List<int> NameList = new List<int>()
                {
                    1,2,3,4,5,6,7,8
                };
            bool Query = NameList.Contains(10);

            Console.WriteLine($"Contains: {Query}");

            List<int> NameLists = new List<int>()
                {
                    1,2,3,4,5,6,7,8
                };
            bool Querys = NameLists.Contains(6);
            Console.WriteLine($"Contains: {Querys}");
          }

       
    }
}
