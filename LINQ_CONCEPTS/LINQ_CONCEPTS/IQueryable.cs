using System;
using System.Collections.Generic;
using System.Linq;


namespace LINQ_CONCEPTS
{
    public class IQueryable
    {
        public static void Solutions()
        {
            List<Program> ListNames = new List<Program>()
            {
              new Program()
              {
                  nID=1,
                  strName="Virat",
                  strGender="Male"
              },

              new Program()
              {
                  nID=2,
                  strName="smrthi",
                  strGender="Female"
              },
              new Program()
              {
                  nID=3,
                  strName="Mraj",
                  strGender="Female"
              },
              new Program()
              {
                  nID=4,
                  strName="DK",
                  strGender="Male"
              },
            };

            IQueryable<Program> QuerySyntax = ListNames.AsQueryable().Where(obj => obj.strGender == "Male" && obj.strName=="Virat").Where(obj=>obj.strGender=="Female" && obj.strName=="Mraj");

            foreach(var item in QuerySyntax)
            {
                Console.WriteLine($"ID:{ item.nID}, Name: { item.strName}");
            }

            Console.ReadKey();
        }
    }
}
