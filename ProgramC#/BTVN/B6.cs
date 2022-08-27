using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    class Employees
    {
        private string? name;
        private string? birth;
        private string? address;
        private int salary;
        private double index;
        private int subSalary;
        private double sumSalary { get; set; }

        public Employees()
        {
        }
        public void inputEmployees()
        {
            Console.Write("Enter name: ");
            this.name = Console.ReadLine();
            Console.Write("Enter birth: ");
            this.birth = Console.ReadLine();
            Console.Write("Enter address: ");
            this.address = Console.ReadLine();
            Console.Write("Enter salary basic: ");
            this.salary = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter index: ");
            this.index = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter subSalary: ");
            this.subSalary = Convert.ToInt32(Console.ReadLine());
        }

        public void RollSalary()
        {
            this.sumSalary = (double)(salary * index) + subSalary;
        }

        public void showEmployees()
        {
            Console.WriteLine("\nName: {0} - Birth: {1} - address: {2} - Salary: {3}", this.name, this.birth, this.address, this.sumSalary);
        }
    }
}
