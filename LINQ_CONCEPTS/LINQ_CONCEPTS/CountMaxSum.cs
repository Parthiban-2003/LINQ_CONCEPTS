using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CONCEPTS
{
    public class CountMaxSum
    {
        public static void Solution()
        {
            //List<int> Names = new List<int>()
            //{
            //    10, 21, 30, 45, 50,90,2222,45,31,12,1
            //};

            //1.COUNT:

            //var Query = Names.Count();

            //Console.WriteLine($"COUNT:{Query}");

            //var Quer = Names.Count(obj => obj % 2 == 0);
            //Console.WriteLine(Quer);

            //var Quer = (from obj in Names
            //            select obj).Count();

            //Console.WriteLine($"COUNT:{Quer}");

            //2.MAX

            //var Query = Names.Max();
            //Console.WriteLine($"MAX: {Query}");

            //var Quer = Names.Max(obj =>
            //                            {
            //                                if (obj % 2 == 0)
            //                                { 
            //                                    return obj;
            //                                } 
            //                                    return 0;
            //                              });
            //Console.WriteLine(Quer);


            //3.SUM

            //var Query = Names.Sum();
            //Console.WriteLine(Query);

            //var query = Names.Sum(obj =>
            //{
            //    if (obj % 2 == 0)
            //    {
            //        return obj;
            //    }
            //    return 0;
            //});

            //Console.WriteLine(query);

            List<Studente> studentList = new List<Studente>()
                {
                   new Studente() { StudentID = 1, StudentName = "John", Age = 13 } ,
                    new Studente() { StudentID = 2, StudentName = "Moin", Age = 21 } ,
                    new Studente() { StudentID = 3, StudentName = "Bill", Age = 18 } ,
                    new Studente() { StudentID = 4, StudentName = "Ram", Age = 20 } ,
                    new Studente() { StudentID = 5, StudentName = "Ron", Age = 15 }
                };

            var Query = studentList.Sum(obj => obj.Age);
            Console.WriteLine(Query);

            var Querys = studentList.Sum(obj =>
            {
                if (obj.Age % 2 == 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            });
            Console.WriteLine(Querys);
        }
        public class Studente
        {
            public int StudentID
            {
                get;
                set;
            }

            public string? StudentName
            {
                get;
                set;
            }

            public int Age
            {
                get;
                set;
            }
        }
    }
}


