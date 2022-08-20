using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsNonGeneric
{
    internal class studentDetails
    {
        public static void Student()
        {
            var stu = new System.Collections.ArrayList();

            stu.Add("Sangeetha");
            stu.Add("CMRCET");
            stu.Add("19H55A0418");
            stu.Add("Tr3");
            stu.Add("9515532131");
            stu.Add("panner");
            stu.Add("Hyderabad");

            Console.WriteLine("\"studentdetails\"");
            foreach (var details in stu)
                Console.WriteLine("  "+details);
        }
    }
}
