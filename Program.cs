using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Serialization;

namespace EmployeeDesignation
{
    internal class Program
    {
        public class Employee
        {
            public int ID;
            public int Salary;
            public int DEPT_ID;
            public string Name;
        }

        public class Department
        {
            public int DEPT_ID;
            public string DEPT_Name;
        }

        public class JoinDemo
        {
            static void Main()
            {

                List<Employee> employees = new List<Employee>()
        {
             new Employee {ID=101,   Name="kavya "  ,DEPT_ID=101},
             new Employee {ID=102,   Name="ramya "    ,DEPT_ID=102},
             new Employee {ID=103,   Name="pravalika"    , DEPT_ID=103},
             new Employee {ID=104,   Name="Ram"    ,DEPT_ID=104},
             new Employee {ID=105,   Name="shamu",DEPT_ID=105},
        };

                List<Department> departments = new List<Department>()
        {
             new Department {DEPT_ID=101,   DEPT_Name=" Program Manager"},
             new Department {DEPT_ID=102,   DEPT_Name="Project Manager"},
             new Department {DEPT_ID=103,   DEPT_Name="Team  Lead"},
             new Department {DEPT_ID=104,   DEPT_Name="Senior Programmer"},
              new Department {DEPT_ID=105,   DEPT_Name="Junior Programmer"},
        };

                var Result = employees.Join(departments,
                                   emp => emp.DEPT_ID,
                                   dept => dept.DEPT_ID,
                                   (emp, dept) => new
                                   {
                                       ID = emp.ID,
                                       Name = emp.Name,
                                       DeptName = dept.DEPT_Name

                                   }).ToList();
                Console.WriteLine("Employee Details: ");
                foreach (var e in Result)
                {
                    Console.WriteLine("\tID: " + e.ID + ", Name: " + e.Name + ",Department: " + e.DeptName);
                }
            }
        }
    }
}