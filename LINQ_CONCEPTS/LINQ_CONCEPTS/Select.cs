using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CONCEPTS
{
    public class Select
    {
        public static void Solution()
        {
            List<Program> ListName = new List<Program>()
            {
                new Program(){nStudent_ID=1,strName="Dhoni",nAge=45},
                new Program(){nStudent_ID=2,strName="Hurmanpreeth",nAge=35},
                new Program(){nStudent_ID=3,strName="Pandiya",nAge=32},
                new Program(){nStudent_ID=4,strName="Poojavasthakar",nAge=24},
                new Program(){nStudent_ID=5,strName="jadu",nAge=34},
                new Program(){nStudent_ID=6,strName="Spatel",nAge=22}
            };

            var Lists = from obj in ListName
                        select obj.nAge;

            foreach (var inn in Lists)
            {
                Console.WriteLine($"AGE: {inn}");
            }

           
            //var sss = ListName.Select(obj => new 
            //{
            //   obj.nAge,
            //   obj.nStudent_ID
            //});
            //foreach (var inns in sss)
            //{
            //    Console.WriteLine($"{inns.nAge}-{inns.nStudent_ID}");
            //}
        }
        
        public class Program
        { 
            public int nStudent_ID
            {
                get;
                set;
            }

            public string? strName
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

    public class Human
    {
        public int Id { get; set; }
        public int Age { get; set; }
    }
}
