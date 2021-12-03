using System;
using static System.Console;

namespace erolAssigment2_1175
{

    class Employee
    {
        //fields for employee number, employee full name (should be an array), date of
        //birth (string format: mm/dd/yyyy) and annual salary

        private int employeeNumber;
        private string dateOfBirth;
        private int annualSalary;
        private string[] employeeName;

        //one default constructor
        public Employee()
        {
        }
        //consturtor for each field
        public Employee(int eNumber, string df, int ans, string[] eName)
        {
            employeeNumber = eNumber;
            dateOfBirth = df;
            annualSalary = ans;

            employeeName = new string[15];
            
            for(int i=0; i<eName.Length; i++)
            {
                employeeName[i] = eName[i];
            }
        }

        //Properities for each field
        public int EmployeeNumber
        {
            get { return employeeNumber; }
            set { employeeNumber = value; }
        }

        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public int AnnualSalary
        {
            get { return annualSalary; }
            set { annualSalary = value; }
        }

        public string [] EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value;}
        }
        //GetLastName() method to extract last name from the full name
        public string GetLastName()
        {
            string eLastName = "";
            foreach (string emp in employeeName) { 
                eLastName += emp;
            }

            string[] lastName = eLastName.Split(' ');
            eLastName = lastName[1];
            return eLastName;
        }
        //Gets the birth year fromt the date of birth
        public string GetBirthYear()
        {
            string birthYear;
            string[] birthDateSplit = dateOfBirth.Split('/');
            birthYear = birthDateSplit[2];
            return birthYear;
        }
        //ToString( ) method that display employee information
        public override string ToString()
        {
            return "Employee Number: " + employeeNumber + "\n" +
                    "Employee Name: " + employeeName[0] + "\n" +
                    "Employee Salary: " + annualSalary + "\n" +
                    "Employee Date of Birth: " + dateOfBirth;
        }
    }
}
