using System;

namespace CarClass
{
    // Create car class
    public class Car
    {
        // fields
        public string make;
        public string model;
        public string reg;
        public int year;
        public int value;

        // methods
        public void returnValue()
        {
            Console.WriteLine(this.value);
        }

        public void returnYear()
        {
            Console.WriteLine(this.year);
        }

        // class constructor
        public Car(string make, string model, string reg, int year, int value)
        {
            this.make = make;
            this.model = model;
            this.reg = reg;
            this.year = year;
            this.value = value;
        }

        // override tostring
        public override string ToString()
        {
            return "Car details: (Make: " + make + " Model: " + model + " Registration: " + reg + " Year of registration: " + year + " Current value: £" + value + ")";
        }  
    }
    class Test
    {
        static void Main(string[] args) 
        {
            Car newCar = new Car("Kia", "Sorento", "ABCDEF", 2015, 15000);

            Console.WriteLine(newCar.ToString());
        }
    }
}
