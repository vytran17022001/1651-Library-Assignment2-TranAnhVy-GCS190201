using System;
namespace _1651_Library
{

    public class Staff : Person
    {

        private string staffClass;
        public void setStaffClass(string staffClass)
        {
            this.staffClass = staffClass;
        }
        public string getStaffchucvu()
        {
            return this.staffClass;
        }

        private long salary;
        public void setSalary(long salary)
        {
            this.salary = salary;
        }
        public long getSalary()
        {
            return this.salary;
        }

        public void ShowStaffInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Position: " + this.staffClass);
            Console.WriteLine("Salary: " + this.salary);
        }
    }
}