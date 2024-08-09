using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CONCEPTS
{
    public class OrderBy
    {
        public static void Solution()
        {
            List<Student> ListName = new List<Student>()
            {
                new Student(){nStdId=1,strName="leodas",nAge=18},
                new Student(){nStdId=2,strName="elisa",nAge=28},
                new Student(){nStdId=3,strName="rayyan",nAge=17},
                new Student(){nStdId=4,strName="velu",nAge=67},
            };

            //var Query = from obj in ListName
            //            orderby obj.strName descending
            //            select obj;

            //foreach(var coll in Query)
            //{
            //    Console.WriteLine(coll.strName);
            //}

            //var query = from obj in ListName
            //            orderby obj.nAge ascending
            //            select obj;

            //foreach (var poi in query)
            //{
            //    Console.WriteLine(poi.nAge);
            //}
            Console.WriteLine("Ascending Order:");
            var query = ListName.OrderBy(obj => obj.nAge);
            
            foreach(var i in query)
            {
                Console.WriteLine(i.nAge);
            }

            var Query = ListName.OrderByDescending(obj => obj.nAge);
            Console.WriteLine("Descending Order:");
            foreach (var i in Query)
            {
                
                Console.WriteLine(i.nAge);
            }
        }
    }

    public class Student
    {
        public int nStdId
        {
            get;
            set;
        }

        public string strName
        {
            get;
            set;
        }

        public int nAge
        {
            get;
            set;
        }
    }
}
