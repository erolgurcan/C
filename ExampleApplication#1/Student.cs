using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erolAssignment1_1175

{
    class  Student
    {
        public string studentName;
        public string studentAdress;
        public string studentMajor;
        public double studentGPA;
    

        public Student()
        {
            studentName = "Erol";
            studentAdress = "xxxx";
            studentMajor = "CSIS";
            studentGPA = 2.00;
        }

        public Student(string name)
        {
            studentName = name;
        }

        public Student(string adress, string major)
        {
            studentAdress = adress;
            studentMajor = major;
        }


        public Student(double GPA)
        {
            studentGPA = GPA;
        }

        public string GetStudentName()
        {
            return studentName;
        }

        public string GetStudentAdress()
        {
            return studentAdress;
        }

        public string GetStudentMajor()
        {
            return studentMajor;
        }

        public double GetStudentGPA()
        {
            return studentGPA;
        }

        public override string ToString()
        {
            string str = "Student Name: " + studentName +
                " Student Adress" + studentAdress +
                "Student Major" + studentMajor + "studentGPA" + studentGPA;
            return str;
        }
    }
}
