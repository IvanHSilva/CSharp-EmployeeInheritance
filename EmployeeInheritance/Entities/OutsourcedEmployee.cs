namespace EmployeeInheritance.Entities {
    public class OutsourcedEmployee : Employee {
        // Attributes
        public double AdditionalCharge{ get; set; }

        // Constructors
        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) 
            : base(name, hours, valuePerHour) {
            AdditionalCharge = additionalCharge;
        }

        // Methods
        public override double Payment() {
            return base.Payment() + (AdditionalCharge * 1.1);
        }
    }
}
