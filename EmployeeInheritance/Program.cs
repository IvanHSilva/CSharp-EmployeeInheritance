using EmployeeInheritance.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace EmployeeInheritance {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Número de funcionários: ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();
            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Funcionário #{i}");
                Console.Write("Terceirizado (s/n)?: ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Horas trabalhadas: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Valor/Hora: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (resp == 's' || resp == 'S') {
                    Console.Write("Taxa adicional: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee( name, hours, valuePerHour, additionalCharge));
                } else {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAGAMENTOS:");
            foreach (Employee emp in list) {
                Console.WriteLine(emp);
            }
        }
    }
}
