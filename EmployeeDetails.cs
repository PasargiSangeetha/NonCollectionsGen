using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsNonGeneric
{
    internal class EmployeeDetails
    {
        public static void Employee()
        {
            Hashtable hs = new ();
           
            hs.Add(1000, "Rohan");
            hs.Add(1020, "Karan");
            hs.Add(1230, "John");
            hs.Add(2222, "Sachin");
            hs.Add(1111, "Rajan");

            Console.WriteLine("Employee details");
            foreach (var k in hs.Keys)
            {  
                Console.WriteLine("Id:{0} Name:{1}", k, hs[k]);
            }           
        }
    }           
}
