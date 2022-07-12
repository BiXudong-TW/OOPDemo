using System;

namespace OOPDemo.Class_Diagram.Aggregation
{
    public class Employee
    {
        public int Id;

        public string Name;

        public Address EmployeeAddress;

        public Employee(int id, string name, Address employeeAddress)
        {
            Id = id;
            Name = name;
            EmployeeAddress = employeeAddress;
        }

        public void Display()
        {
            Console.WriteLine(Id + " " + Name + " " + EmployeeAddress.City + " ");
        }
    }

    public class Address
    {
        public string  City, State;
        public Address( string city, string state)
        {
            City = city;
            State = state;
        }
    }

    public class AggregationDemo
    {
        public static void Main(string[] args)
        {
            Address a1=new Address("city","state");
            Employee e1 = new Employee(1,"Employee Name",a1);
            e1.Display();
        }
    }
}