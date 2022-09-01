using System.Globalization;

namespace EmployeeInheritance.Entities {
    public class Employee {
        // Attributes
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        // Constructors
        public Employee() { }

        public Employee(string name, int hours, double valuePerHour) {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        // Methods
        public virtual double Payment() {
            return Hours * ValuePerHour;
        }

        public override string ToString() {
            return $"{Name} - $ {Payment().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
