using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erolAssignment1_1175
{
    class Course
    {
        public string departmentName;
        public string courseNumber;       
        public double creditHours;
        public double courseFee;
        public double totalFee;

        public Course()
        {
            departmentName = "CSIS";
            courseNumber = "CSIS 1175";            
            creditHours = 3;
        }

        Course (string dName, string cNumber)
        {
            departmentName = dName;
            courseNumber = cNumber;
        }

        Course(double cHour)
        {
            creditHours = cHour;
        }

        public string GetDepartmentName ()
        {
            return departmentName;
        }

        public double CreditHours()
        {
            return creditHours;
        }

        public double CalculateFee()
        {
            if (departmentName == "CSIS")
            {
                courseFee = 350;
                totalFee = courseFee * creditHours;
            }
            else
            {
                courseFee = 300;
                totalFee = courseFee * creditHours;
            }
            return (totalFee);
        }

        public override string ToString()
        {
            string str = "Department Name" + departmentName + "courseNumber" + courseNumber +
                "Credit Hours" + creditHours;
            return str;
        }

    }
}
