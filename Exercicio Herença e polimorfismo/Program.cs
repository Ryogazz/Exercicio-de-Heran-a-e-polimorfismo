using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio_Herença_e_polimorfismo.Entities;
using Exercicio_Herença_e_polimorfismo.objetcs;

namespace Exercicio_Herença_e_polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employess: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i + " Data:");
                Console.Write("Outsourced (y/n)?");
                char x = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hours: ");
                double ValuePerhours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               
                if(x == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(nome, hours, ValuePerhours, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(nome, hours, ValuePerhours));
                }

            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS");
            foreach (Employee employee in list)
            {
                Console.WriteLine(employee.Name + " - $ " + employee.Payment().ToString("f2",CultureInfo.InvariantCulture));
            }

        }
    }
}
