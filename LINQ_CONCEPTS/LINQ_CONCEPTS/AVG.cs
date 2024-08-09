using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CONCEPTS
{
    public class AVG
    {
        public static void Solution()
        {
            List<Studen> Values = new List<Studen>()
            {
                new Studen() { StudenID = 1, StudenName = "John", Age = 13} ,
                new Studen() { StudenID = 2, StudenName = "Moin",  Age = 21 } ,
                new Studen() { StudenID = 3, StudenName = "Bill",  Age = 18 } ,
                new Studen() { StudenID = 4, StudenName = "Ram" , Age = 20} ,
                new Studen() { StudenID = 5, StudenName = "Ron" , Age = 15 }
            };

            var Query = Values.Average(obj => obj.StudenID);

            Console.WriteLine(Query);
        }
    }

        public class Studen
        {
            public int StudenID
            {
                get;
                set;
            }

            public string? StudenName
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

