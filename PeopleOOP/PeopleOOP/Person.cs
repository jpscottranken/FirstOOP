using System;

namespace PeopleOOP
{
    public class Person
    {
        //  Declaring class variables
        public string FirstName;
        public string LastName;
        public string Department;
        public decimal Salary;
        public bool Married;

        //  Constructor #1
        public Person() { }

        //  Constructor #2
        public Person(string fn, string ln, string dept,
                      decimal sal, bool mar)
        {
            FirstName = fn;
            LastName = ln;
            Department = dept;
            Salary = sal;
            Married = mar;
        }

        public override string ToString()
        {
            string outputStr = "";
            outputStr += $"Name: {FirstName} {LastName}\n";
            outputStr += $"Dept: {Department}\n";
            outputStr += $"Salary: {Salary:c}\n";
            outputStr += $"Married: {Married}";

            return outputStr;
        }
    }
}
