using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CONCEPTS
{
    public class Aggregate
    {
        public static void Solution()
        {
            List<string> Names = new List<string>()
            {
                "One","Two","Three","Four"
            };

            IEnumerable<char> Query = Names.Aggregate((s1, s2) => s1 + "," + s2);

            Console.WriteLine(Query);
        }
    }
}
