using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CONCEPTS
{
    public class ThenByThenByDescending
    {
        public static void Solution()
        {
            List<Programs> ListNames = new List<Programs>()
            {
                new Programs(){Student_ID=1,strName="Dhoni",nAge=45},
                new Programs(){Student_ID=2,strName="Hurmanpreeth",nAge=35},
                new Programs(){Student_ID=3,strName="Pandiya",nAge=32},
                new Programs(){Student_ID=4,strName="Poojavasthakar",nAge=24},
                new Programs(){Student_ID=5,strName="jadu",nAge=34},
                new Programs(){Student_ID=6,strName="Spatel",nAge=22}
            };

            var QuerySyntax = from obj in ListNames
                              orderby obj.strName
                              select obj;

            foreach (var INN in QuerySyntax)
            {
                Console.WriteLine(INN.strName);
            }

            var query = ListNames.OrderBy(obj => obj.strName).ThenBy(obj => obj.nAge);
            foreach (var INN in query)
            {
                Console.WriteLine($"NAME:{INN.strName},AGE:{INN.nAge}");
            }

            var QueryBy = ListNames.OrderByDescending(obj => obj.Student_ID).ThenByDescending(obj => obj.strName);

            foreach(var it in QueryBy)
            {
                Console.WriteLine($"Studentt_ID:{it.Student_ID},Name:{it.strName}");
            }
        }
    }

    public class Programs
    {
        public int Student_ID
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
