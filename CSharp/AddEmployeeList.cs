using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateExCon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>();
            //Employee Emp1 = new Employee();
            //Emp1.id = 1;
            //Emp1.Name = "Dheeraj";
            //Emp1.PhoneNo = "909090909090";
            //Emp1.Salary = 200000;
            //emp.Add(Emp1);
            //OR
            emp.Add(new Employee() { id = 1, Name = "Dheeraj", PhoneNo = "90909090", Salary = 000 });
            emp.Add(new Employee() { id = 2, Name = "Raja", PhoneNo = "7878787878", Salary = 100000 });
            emp.Add(new Employee() { id = 3, Name = "Gopal", PhoneNo = "110191911", Salary = 20001 });
            Employee empData = new Employee();
            empData.getDetails(emp);
        }
    }
    public class Employee
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public decimal Salary { get; set; }
        public void getDetails(List<Employee> EmpList)
        {
            foreach (Employee employee in EmpList)
            {
                if (employee.Salary > 4000)
                {
                    Console.WriteLine("Promoted");
                }
            
            }
            Console.ReadKey();
        
        
        
        }
    
    }
}
