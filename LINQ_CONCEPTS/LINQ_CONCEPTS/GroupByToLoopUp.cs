using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CONCEPTS
{
    public class GroupByToLoopUp
    {
        public static void Solution()
        {
            List<Student> ListName = new List<Student>()
            {
             new Student() {nStudentID = 1, strStudentName = "John", nAge = 18 } ,
             new Student() {nStudentID = 2, strStudentName = "Steve",  nAge = 21 } ,
             new Student() {nStudentID = 3, strStudentName = "Bill",  nAge = 18 } ,
             new Student() {nStudentID = 4, strStudentName = "Ram" , nAge = 20 } ,
             new Student() {nStudentID = 5, strStudentName = "Abram" , nAge = 21 }
            };

            //Group By()

            //var Query = from obj in ListName
            //            group obj by obj.nAge;

            //foreach(var obje in Query)
            //{
            //    Console.WriteLine(obje.Key);

            //    foreach(Student obj in obje)
            //    {
            //        Console.WriteLine(obj.strStudentName);
            //    }
            //}

            var query = ListName.GroupBy(obj => obj.nAge);

            foreach (var thinks in query)
            {
                Console.WriteLine(thinks.Key);

                foreach (Student obj in thinks)
                {
                    Console.WriteLine(obj.strStudentName);
                }
            }

            //ToLookUp()

                var querys = ListName.ToLookup(obj => obj.nAge);

                foreach (var thinke in query)
                {
                    Console.WriteLine(thinke.Key);

                    foreach (Student obj in thinke)
                    {
                        Console.WriteLine(obj.strStudentName);
                    }
                }
        }

        public class Student
        {
            public int nStudentID
            {
                get;
                set;
            }
            public string? strStudentName
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
}
