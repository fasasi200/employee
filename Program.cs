using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empo1 = new Employee("fasasi", "wasiu", (decimal)800000.50);
            Employee empo2 = new Employee("burry", "flakes", (decimal)500000.25);

            Console.WriteLine("Employee 1 First Name: {0}", empo1.FirstName);
            Console.WriteLine("Employee 1 Last Name: {0}", empo1.LastName);
            Console.WriteLine("Employee 1 Salary: {0:C}", empo1.Salary);

            Console.WriteLine("Employee 2 First Name: {0}", empo2.FirstName);
            Console.WriteLine("Employee 2 Last Name: {0}", empo2.LastName);
            Console.WriteLine("Employee 2 Salary: {0:C}", empo2.Salary);

            Console.WriteLine();
            Console.WriteLine("After 10% raise");

            empo1.Salary = empo1.Salary * (decimal)1.1;
            empo2.Salary = empo2.Salary * (decimal)1.1;
            Console.WriteLine("Employee 1 new salary: {0:C}", empo1.Salary);
            Console.WriteLine("Employee 2 new salary: {0:C}", empo2.Salary);


            Console.ReadLine();


        }
    }
}