using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CONCEPTS
{
    public class ElementOperators
    {
        public static void Solution()
        {

            //ElementAt & ElementAtOrDefault 

            //List<int> ListOfOrders = new List<int>()
            //{
            //    23,33,11,23,76,56,89,34
            //};

            //var Query = ListOfOrders.ElementAt(1);
            //Console.WriteLine(Query);

            //var quer = ListOfOrders.ElementAtOrDefault(9);
            //Console.WriteLine(quer);

            //List<string> NameOfList = new List<string>()
            //{
            //    "One","Two","Three","Four","Five"
            //};

            //var query = NameOfList.ElementAt(0);
            //Console.WriteLine(query);

            //var quere = NameOfList.ElementAtOrDefault(9);
            //Console.WriteLine(quere);


            //2.First,last & FirstOrDefault,lastOrDefault

            List<int> ListOfOrders = new List<int>()
            {
                23,33,11,23,76,56,89,34
            };

            var lst = ListOfOrders.First();
            Console.WriteLine(lst);

            var last = ListOfOrders.Last();
            Console.WriteLine(last);

            var lasts = ListOfOrders.LastOrDefault();
            Console.WriteLine(lasts);

            var lsts = ListOfOrders.FirstOrDefault();
            Console.WriteLine(lsts);


            List<string> NameOfList = new List<string>()
            {
               null,"One","Two","Three","Four","Five"
            };

            var strs = NameOfList.First();
            Console.WriteLine(strs);

            var str = NameOfList.FirstOrDefault();
            Console.WriteLine(str);

            var ls = NameOfList.Last();
            Console.WriteLine(ls);

            var lss = NameOfList.LastOrDefault();
            Console.WriteLine(lss);

        }
    }
}
