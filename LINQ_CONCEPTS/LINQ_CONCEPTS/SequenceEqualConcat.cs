using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CONCEPTS
{
    public class SequenceEqualConcat
    {
        public static void Solution()
        {
            List<int> equals1 = new List<int>()
            {
                1,34,65,44,67,98
            };

            List<int> equals2 = new List<int>()
            {
                1,34,65,44,67,98
            };

            bool Quary = equals1.SequenceEqual(equals2);
            Console.WriteLine(Quary);

            var quing = equals1.Concat(equals2);

            foreach(var obj in quing)
            {
                Console.WriteLine(obj);
            }



            List<string> equals3 = new List<string>()
            {
                "One","Two","Three"
            };

            List<string> equals4 = new List<string>()
            {
                "One","Two","Three"
            };

            //DefaultIfEmpty

            List<string> equals5 = new List<string>();

            var equale = equals5.DefaultIfEmpty("LEODAS");

            foreach(var obj in equale)
            {
                Console.WriteLine($"OBJECT VALUES : {obj}");
            }
            Console.WriteLine(equale.ElementAt(0));

            var que = equals3.SequenceEqual(equals4);
            Console.WriteLine(que);

            var concat = equals3.Concat(equals4);

            foreach(var obj in concat)
            {
                Console.WriteLine(obj);
            }
            
        }
    }
}
