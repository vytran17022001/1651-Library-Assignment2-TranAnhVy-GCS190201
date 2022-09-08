using System;
using System.Linq;
using System.Text;

namespace _1651_Library
{

    public class Person
    {
        private string name;
        private int id;
        private string gender;
        private int age;
        private string phone;
        private string company = "FPT Greenwich";

        public Person()
        {
        }

        public Person(string name, int id, string gender, int age, string phone, string company)
        {
            this.name = name;
            this.id = id;
            this.gender = gender;
            this.age = age;
            this.phone = phone;
            this.company = company;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return this.id;
        }

        public void setGender(string gender)

        {
            this.gender = gender;
        }

        public string getGender()
        {
            return this.gender;
        }

        public void setAge(int age)
        {
            this.age = age;
        }
        public int getAge()
        {
            return this.age;
        }

        public void setPhone(string phone)

        {
            this.phone = phone;
        }

        public string getPhone()
        {
            return this.phone;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Id: " + this.id);
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Age: " + this.age);
            Console.WriteLine("Gender: " + this.gender);
            Console.WriteLine("Phone Number: " + this.phone);
            Console.WriteLine("Company: " + this.company);
        }
    }
}

