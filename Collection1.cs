using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsNonGeneric
{
    class Collection1
    {
        public static void ArrList()
        {
            ArrayList ar = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                ar.Add(a);
            }
            ar.Sort();

            Console.WriteLine("Values arranged in order");

            foreach (object o in ar)
                Console.Write($"{o} ");
        }
        
        public static void Main()
        {
            Collection1.ArrList();
            Students.Student();
            EmployeeDetails.Employee();
            BookStore.Books();
            studentDetails.Student();
            
        }
    }
}
