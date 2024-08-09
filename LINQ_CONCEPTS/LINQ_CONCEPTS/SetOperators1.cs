using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CONCEPTS
{
    public class SetOperators1
    {
        public static void Solution()
        {

                                         //1.Distinct

            List<int> NumberOfValues = new List<int>()
            {
                1,45,67,78,6,67,1,45,78,45,33,72
            };

            var Query = NumberOfValues.Distinct();

            foreach(var obj in Query)
            {
                Console.WriteLine(obj);
            }



            List<string> NamesOfPeoples = new List<string>()
            {
                "Leodas","elisadas","velu","vijay","pandi","leodas","ajith","dhanush","vijay","pandi"
            };

            var query = NamesOfPeoples.Distinct();

            foreach(var obj in query)
            {
                Console.WriteLine(obj);
            }

                                           //2.Except
 
            List<string> strList1 = new List<string>()
            {
             "One", "Two", "Three", "Four", "Five"
            };

            List<string> strList2 = new List<string>()
            {
             "Four", "Five", "Six", "Seven", "Eight"
            };

            var queries = strList1.Except(strList2);

            foreach(var obj in queries)
            {
                Console.WriteLine(obj);
            }

            //3.Insert

            List<int> LISTOFNUMBER = new List<int>()
            {
                23,2,11,23,56,78,64,77,67,33,34
            };

            List<int> LISTOFNUMBERS = new List<int>()
            {
                12,45,67,54,33,21,64,2,23,23,77
            };

            var syntaxs = LISTOFNUMBER.Intersect(LISTOFNUMBERS);

            foreach(var obj in syntaxs.Distinct())
            {
                Console.WriteLine(obj);
            }

            //4.UNION()

            List<string> strList0 = new List<string>() 
            { 
                "One", "Two", "three", "Four" ,"Five"
            };

            IList<string> strList = new List<string>() 
            { 
                "One","Two", "THREE", "Five","Six"
            };

            var quing = strList0.Union(strList);

            foreach(var obj in quing)
            {
                Console.WriteLine(obj.ToUpper());
            }

        }

    }
}     
@{ var name = "leodas"; } => razor
    @code dim  myname="leodas"
    endcode; 