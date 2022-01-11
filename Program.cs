using System;
using System.Collections.Generic;
using System.Globalization;
using Course03.Entities;

namespace Course03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int numberEmployees = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberEmployees; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n): ");
                char isOutsourced = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (isOutsourced.ToString().ToUpper() == "Y")
                {
                    Console.Write("Additional charge: ");
                    double valueCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    OutSourceEmployee emp = new OutSourceEmployee(name, hours, valuePerHour, valueCharge);
                    employee.Add(emp);
                } else
                {
                    employee.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS");

            foreach (Employee list in employee)
            {
                Console.WriteLine(list.Name
                    + " - $ "
                    + list.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine("--------------------");
        }
    }
}
