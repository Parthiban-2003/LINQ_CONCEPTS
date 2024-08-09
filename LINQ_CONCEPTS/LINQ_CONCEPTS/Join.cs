using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CONCEPTS
{
    public class Join
    {
        public static void Solution()
        {
            List<Students> StudentListName = new List<Students>()
            {
             new Students() { nStudentID = 1, strStudentName = "John", nAge = 18, nStandardID = 1 } ,
                new Students() { nStudentID = 2, strStudentName = "Steve",  nAge = 21, nStandardID = 1 } ,
                new Students() { nStudentID = 3, strStudentName = "Bill",  nAge = 18, nStandardID = 2 } ,
                new Students() { nStudentID = 4, strStudentName = "Ram" , nAge = 20, nStandardID = 2 } ,
                new Students() { nStudentID = 5, strStudentName = "Ron" , nAge = 21, nStandardID=3}
            };

            List<Standard> StandardListName = new List<Standard>()
            {
                new Standard(){ nStandardID = 1, strStandardName="Standard 1"},
                new Standard(){ nStandardID = 2, strStandardName="Standard 2"},
                new Standard(){ nStandardID = 3, strStandardName="Standard 3"}
            };

            var InnerJoinQuery = StudentListName.Join(
                                    StandardListName,
                                    Student => Student.nStandardID,
                                    Standard => Standard.nStandardID,
                                    (Student, Standards) => new
                                    {
                                        StudentName = Student.strStudentName,
                                        StandardName = Standards.strStandardName
                                    });

            foreach (var items in InnerJoinQuery)
            {
                Console.WriteLine($"{items.StudentName} - {items.StandardName}");
            }

            //var QuerySyntax = from S in StudentListName
            //                  join St in StandardListName
            //                  on S.nStudentID equals St.nStandardID
            //                  select new
            //                  {
            //                      student = S.nStudentID,
            //                      standard = St.nStandardID
            //                  };

            //foreach (var onn in QuerySyntax)
            //{
            //    Console.WriteLine($"{onn.student}-{onn.standard}");
            //}
        }

        public class Students
        {
            public int nStudentID
            {
                get;
                set;
            }
            public string strStudentName
            {
                get;
                set;
            }

            public int nAge
            {
                set;
                get;
            }

            public int nStandardID
            {
                get;
                set;
            }
        }


        public class Standard
        {
            public int nStandardID
            {
                get;
                set;
            }

            public string strStandardName
            {
                set;
                get;
            }
        }

    }
}
