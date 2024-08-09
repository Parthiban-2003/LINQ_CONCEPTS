using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CONCEPTS
{
    public class AllAny
    {
        public static void Solution()
        {
            List<Students> studentList = new List<Students>() 
            {
                new Students() { StudentID = 1, StudentName = "John", Age = 13 } ,
                new Students() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Students() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Students() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Students() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };
            //ALl
            bool ListNames = studentList.All(obj => obj.Age > 12 && obj.Age < 22);

            Console.WriteLine($"LISTS: {ListNames}");

            //Any
            bool ListName = studentList.Any(obj => obj.Age > 12 && obj.Age < 18);

            Console.WriteLine($"LIST: {ListName}");
        }
    }

    public class Students
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


