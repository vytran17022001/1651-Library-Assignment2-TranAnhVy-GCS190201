using System;
using System.Collections.Generic;
namespace _1651_Library
{
    public class ManagerStaff
    {
        private static List<Staff> staffList = new List<Staff>();
        static void Main(string[] args)
        {
            int option = 0;
            string name;
            while (option != -1)
            {
                Console.WriteLine("+---------------------------+");
                Console.WriteLine("|    EMPLOYEE MANAGEMENT    |");
                Console.WriteLine("+---------------------------+");
                Console.WriteLine("|1.Add Employee             |");
                Console.WriteLine("|2.Delete Employee          |");
                Console.WriteLine("|3.Search Employee          |");
                Console.WriteLine("|4.Show all Employee        |");
                Console.WriteLine("|5.Back                     |");
                Console.WriteLine("+---------------------------+");
                Console.Write("Enter your choice: ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Staff newStaff = new Staff();

                        Console.WriteLine("\n+------------------------------+");
                        Console.WriteLine("|Which position are you adding?|");
                        Console.WriteLine("|1. Staff                      |");
                        Console.WriteLine("|2. Manager                    |");
                        Console.WriteLine("+------------------------------+");
                        Console.Write("Enter your choice: ");
                        int chosen = Convert.ToInt32(Console.ReadLine());

                        // ----------------  polymorphism ------------------------------
                        if (chosen == 1) // Staff adding
                        {
                            newStaff.setStaffClass("Staff");

                        }
                        else if (chosen == 2) // Manager adding
                        {
                            newStaff.setStaffClass("Manager");
                        } else
                        {
                            Console.WriteLine("Invalid chosen !!!");
                        }

                        Console.WriteLine("\n+------------------------------------+");
                        Console.WriteLine("|Which staff's gender are you adding?|");
                        Console.WriteLine("|1. Male                             |");
                        Console.WriteLine("|2. Female                           |");
                        Console.WriteLine("|3. Other                            |");
                        Console.WriteLine("+------------------------------------+");
                        Console.Write("Enter your choice: ");
                        int chosenGender = Convert.ToInt32(Console.ReadLine());
                        if (chosenGender == 1)
                        {
                            newStaff.setGender("Male");

                        }
                        else if (chosenGender == 2)
                        {
                            newStaff.setGender("Female");
                        } else if (chosenGender == 3)
                        {
                            newStaff.setGender("Other");
                        } else
                        {
                            Console.WriteLine("Invalid chosen !!!");
                        }
                        // ----------------------------------------------

                        Console.Write("\nInput Staff Name: ");
                            newStaff.setName(Console.ReadLine());

                            Console.Write("Input Staff Age: ");
                            newStaff.setAge(Convert.ToInt32(Console.ReadLine()));
                            Console.Write("Input Staff Phone Number: ");
                            newStaff.setPhone(Console.ReadLine());

                            Console.Write("Input Staff Salary: ");
                            newStaff.setSalary(Convert.ToInt64(Console.ReadLine()));

                            newStaff.setId(staffList.Count + 1);

                            Console.Clear();
                            staffList.Add(newStaff);
                            Console.WriteLine("!!Add Successfully!!\n");
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Input Staff Name to delete: ");
                        name = Console.ReadLine();
                        bool flag = false;

                        for (int i = 0; i < staffList.Count; i++)
                        {
                            if (staffList[i].getName().ToLower() == name.ToLower())
                            {
                                staffList.RemoveAt(i);
                                flag = true;
                                Console.Clear();
                                Console.WriteLine("!!Delete Successfully!!\n");
                                break;
                            }
                        }
                        if (!flag)
                        {
                            Console.WriteLine("This staff does not exit");
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Input Staff Name to search: ");
                        name = Console.ReadLine();
                        bool flagA = false;

                        for (int i = 0; i < staffList.Count; i++)
                        {
                            if (staffList[i].getName().ToLower() == name.ToLower())
                            {
                                Console.Clear();
                                Console.WriteLine("\n~~~~Search Result~~~~");
                                staffList[i].ShowStaffInfo();
                                flagA = true;
                                break;
                            }
                        }
                        if (!flagA)
                        {
                            Console.WriteLine("This");
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("\n~~~~All Staff~~~~");
                        foreach (Staff staff in staffList)
                        {
                            staff.ShowStaffInfo();
                        }
                        Console.WriteLine("\n");
                        break;
                    case 5:
                        option = -1;
                        Console.WriteLine("\n See you again !");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
