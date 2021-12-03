using System;
using static System.Console;

namespace erolAssigment2_1175
{
    class EmployeeApp
    {
        static void Main()
        {
            int eNumber, aSalary;
            string[] eName= new string[15];
            string dateBirth;
            bool program_on = true;
            string choice;
            int searchNumber;

            int numOfEmployees = 15;
            int counter = 0;

            Employee[] employeeMember = new Employee[numOfEmployees];

            WriteLine("Welcome to the employee database program");
            WriteLine("Options:");

            while (program_on == true)
            {
                choice = GetMenuChoise();
                //User Adds New Employee
                if (choice == "A")
                {
                    WriteLine("Enter employee number: ");
                    eNumber = GetIntegerValue();
                    //Returns True if entered employee number is already in database and take backs to previous menu;
                    if (CheckEmployeeNumber(employeeMember, eNumber))
                    {
                        continue;
                    }

                    else {
                        //Checks if the database is full.
                        if (counter == numOfEmployees)
                        {
                            program_on = false;
                            WriteLine("Sorry - the array/database is full -- cannot add a record");
                        }
                        else {
                            //prompt the user for salary, full name (format: first_name2
                            //last_name, with a space in between first name and last name) and data of birth
                            //(format: mm / dd / yyyy).//

                            WriteLine("Enter full name in firstname space lastname format: ");
                            eName = GetEmployeeFullName();                           
                            
                            WriteLine("Enter date of birth in mm/dd/yyyy format: ");
                            dateBirth = ReadLine();
                            WriteLine("Enter salary: ");
                            aSalary = GetIntegerValue();

                            Employee e = new Employee(eNumber, dateBirth, aSalary, eName);

                            employeeMember[counter] = e;
      
                            WriteLine("A new employee is added");
                            WriteLine();
                            counter++;
                            WriteLine("---Number of employees are {0}", counter);
                            WriteLine("");
                            WriteLine("Added Employe: ");
                            WriteLine(e);
                            WriteLine("");
                        }
                    }
                }
                //Search employee number in database
                else if (choice == "S")
                {
                    if(counter == 0)
                    {
                        WriteLine("Database is empty");                        
                    }
                    else
                    {
                        WriteLine("Enter the employee number to search");
                        searchNumber = GetIntegerValue();

                        foreach(Employee emp in employeeMember)
                        {
                            
                            //excetion handling for null values in database
                            try 
                            { 
                                //Prompts if the employee id found in database
                                if (searchNumber == emp.EmployeeNumber)
                                {
                                    WriteLine("---------");
                                    WriteLine("--Employe number: {0}" + "\n--Employe Last Name: {1}" +
                                    "\n--Employee BirthDate: {2}" + "\n--Employee Salary: {3:C0}", emp.EmployeeNumber,
                                    emp.GetLastName(), emp.GetBirthYear(), emp.AnnualSalary);
                                    WriteLine("---------");
                                    
                                }                      
                                else if (searchNumber != emp.EmployeeNumber)
                                {
                                    WriteLine("Employee with number {0} is not found in database", searchNumber);
                                    break;
                                }
                            }
                            catch
                            {
                            }
                        }
                    }

                }
                else if (choice == "D")
                {
                    //Prompts if the database is empty
                    if(counter == 0)
                    {
                        WriteLine("--Database is empty");
                    }
                    else
                    {
                        //Prompts all employees in database
                        WriteLine("Displaying All Employees....");
                        try { 
                                foreach(Employee emp in employeeMember)
                                 {
                                WriteLine("---------");
                                WriteLine("--Employe number: {0}" + "\n--Employe Last Name: {1}" +
                                "\n--Employee BirthDate: {2}" + "\n--Employee Salary: {3:C0}", emp.EmployeeNumber,
                                emp.GetLastName(), emp.GetBirthYear(), emp.AnnualSalary);
                                WriteLine("---------");                                
                                 }
                            }
                        catch
                        {

                        }
                    }

                }
                else if (choice == "E")
                {
                    program_on = false;
                    WriteLine("Good Bye!!!");
                }
            }
            ReadKey();
        }
        //Gets A S D or E from user to navigate between menus
        public static string GetMenuChoise()
        {
            string vValue;
            WriteLine();
            WriteLine("Choose an option from the menu");
            WriteLine("--Add to the database.......enter 'A' \n--Search the database.......enter 'S' \n" +
                        "--Display all the records in the database....enter 'D' \n" + "--Exit.....enter 'E')");
            vValue = ReadLine();

            while (vValue != "A" && vValue != "S" && vValue != "D" && vValue != "E")
            {
                WriteLine("...Please enter A, S, D or E...");
                vValue = ReadLine();
            }
            return vValue;
        }
        // Gets integer value and prevents if any value entered expect from an integer. 
        public static int GetIntegerValue()
        {
            string vValue;
            int Number;
           
            vValue = ReadLine();
            
            while(int.TryParse(vValue, out Number) == false)
            {
                WriteLine("...Please enter an integer value...");
                vValue = ReadLine();
            }
            return Number;
        }

        // Gets the employee Full Name 
        public static string[] GetEmployeeFullName()
        {
            string[] employeeFullName = new string[15];
            string input;

            input = ReadLine();
            string[] inputCheck = input.Split(' ');

            while (SurnameCheck(input) == false)
            {
                WriteLine("---Surname should be entered");
                input = ReadLine();
                SurnameCheck(input);
            }

            employeeFullName[0] = input;
            return employeeFullName;
        }
        //Check if the name and surname are entered with a white space in between or the surname is entered.
        public static bool SurnameCheck(string input)
        {
            try { 
                string[] inputCheck = input.Split(' ');
                string temp = inputCheck[1];
                return true;
            }
            catch(System.IndexOutOfRangeException)
            {
                return false;
            }
  
        }

        //display an error message if the employee number already exists in the database
        public static bool CheckEmployeeNumber(Employee[] employeeMember, int eNumber)
        {
            bool condition = false;
            foreach (Employee emp in employeeMember)
            {
                
                try
                {
                    if (eNumber == emp.EmployeeNumber)
                    {
                        WriteLine();
                        WriteLine("---Employee with ID {0} and name: {1} is already in the database",
                            emp.EmployeeNumber, emp.EmployeeName[0]);
                        WriteLine();
                        condition  = true;
                    }
                }
                catch
                {
                }
                
            }
            return condition;
        }

    }
}
