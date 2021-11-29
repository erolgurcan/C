using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erolAssignment1_1175
{
    public class Employee
    {
        public int employeeID;
        public string employeeName;
        public double hourlyPaymentRate;

        public Employee()
        {
            employeeID = 123;
            employeeName = "David";
            hourlyPaymentRate = 100;
        }

        public Employee(int eid, string eName, double hPay)
        {
            employeeID = eid;
            employeeName = eName;
            hourlyPaymentRate = hPay;
        }

        public Employee(int eid)
        {
            employeeID = eid;
        }

        public Employee(string eName)
        {
            employeeName = eName;
        }

        public Employee(double hPay)
        {
            hourlyPaymentRate = hPay;
        }

        public double CalculateGrossPay(double hoursWorked)
        {
            return (hoursWorked * hourlyPaymentRate);
        }

        public override string ToString()
        {
            string str = "employee ID: " + employeeID +
                " employee Name" + employeeName +
                "hourly payment rate" + hourlyPaymentRate;
            return str;
        }

        public int GetEmployeeID()
        {
            return employeeID;
        }

        public string GetEmployeeName()
        {
            return employeeName;
        }


        public double GetEmployeeHourRate()
        {
            return hourlyPaymentRate;
        }
    }
}
