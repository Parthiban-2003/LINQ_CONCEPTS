using System;
using System.Collections.Generic;
using System.Reflection;

namespace LINQ_CONCEPTS
{
    public class IEnumerable
    {
        public static void Solution()
        {
            List<Program> ListsName = new List<Program>()
            {
              new Program(){nID=1,strName="leodas",strGender="Male"},
              new Program(){nID=2,strName="Smirthi",strGender="Female"}             
            };

            IEnumerable<Program> QuarySyntax = from obj in ListsName
                                        where obj.nID == 1
                                        select obj;

            foreach(var student in QuarySyntax)
            {
                Console.WriteLine($"ID : {student.nID}  Name : {student.strName}");
            }
            Console.ReadKey();
        }
    }

    public class Program
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
        public string strGender
        {
            get;
            set;
        }
    }
}
