using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsNonGeneric
{
    internal class Students
    {
        public static void Student()
        {
            string[] stu = new string[] { "navya", "kavya", "ramya", "lowkya" };
            Array.Sort(stu);
            Array.Reverse(stu);

            Console.WriteLine("Students in Descending order");
            foreach (string s in stu)
                Console.WriteLine(s);
        }
    }
}
