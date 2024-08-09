using System;
using System.Collections;
using System.Linq;

namespace LINQ_QURIESS
{
    public class OfType
    {
        public static void Solution()
        {
            IList ListName = new ArrayList();
            ListName.Add(0);
            ListName.Add("One");
            ListName.Add("TWO");
            ListName.Add(3);

            ListName.Add(new Student(){ nID=1,strName="leodas"});

            var QuerySyntax = from obj in ListName.OfType<int>()
                              select obj;
            var Query = from obj in ListName.OfType<string>()
                        select obj;

            foreach(var inds in QuerySyntax)
            {
                Console.WriteLine(inds);
            }

            foreach(var inn in Query)
            {
                Console.WriteLine(inn);
            }
        }
    }

    public class Student
    {
        public int nID
        {
            get;
            set;
        }
        public string strName
        {
            get;
            set;
        }
    }
}