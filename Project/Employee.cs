using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Project
{
    public class Employee
    {
        public String EmployeeId;
        public String EmployeeName;
        public String EmployeeEmail;
        public String EmployeePhoneNumber;
        public int EmployeeAge;
        public String projectName;
        public string employeeType;
        /*public virtual void getprojectDetails()
        {
            Console.WriteLine("enter project name");
            Console.ReadLine();
        }*/


    }
    public class Validatedetails : Employee,Interface1
    {
        public void getEmployeeId()
        {
            String employeeId;
            var checkVariable = 0;
            
            Console.WriteLine("Enter Employee ID : ");
            employeeId = Console.ReadLine();
            var str1 = "0000";
            while (checkVariable == 0)
            {
                var length = employeeId.Length;
                var str2 = employeeId.Substring(3);
                if (length == 7 && (employeeId.StartsWith("ace") || employeeId.StartsWith("ACE") == true))
                {
                    checkVariable = 1;
                    EmployeeId = employeeId;
                    for (var i = 3; i < 7; i++)
                    {
                        if (!char.IsDigit(employeeId[i]))
                        {
                            checkVariable = 1;
                            break;
                        }
                    }
                    Console.WriteLine("Employee Id :" + EmployeeId);
                }
                else

                if (checkVariable == 0 || str1.Equals(str2) == true)
                {
                    Console.WriteLine("INVALID Employee ID - Employee Id should start with ACE followed by digits");
                    Console.WriteLine("Enter Employee ID : ");
                    employeeId = Console.ReadLine();
                }
            }
        }
        public void getModeOfWork()

        {
            Console.WriteLine("enter the mode of work");
            Console.ReadLine();
        }
        public void getExperienceDetails()
        {
            Console.WriteLine("enter the total experience in this organization in years excluding training period");
            Console.ReadLine();
        }
        public void getEmployeeName()
        {
            String EmployeeName1;
            var checkVariable_1 = 0;
            while (checkVariable_1 == 0)
            {
                Console.WriteLine("Enter Employee Name :");
                EmployeeName1 = Console.ReadLine();
                var length = EmployeeName1.Length;
                String nameasuppercase = EmployeeName1.ToUpper();
                char[] data = nameasuppercase.ToCharArray();
                for (int k = 0; k < length; k++)
                {
                    int asciinum = (int)data[k];
                    if (asciinum != 32)
                    {
                        if (asciinum < 65 || asciinum > 90)
                        {
                            checkVariable_1 = 0;
                            Console.WriteLine("INVALID Name ");
                            break;
                        }
                        else
                            checkVariable_1 = 1;

                    }

                }
                if (checkVariable_1 == 1)
                {
                    EmployeeName = EmployeeName1;
                    break;
                }

            }
        }
        public void getEmployeeEmail()
        {
            String Email;
            var checkVariable_2 = 1;
            while (checkVariable_2 == 1)
            {
                Console.WriteLine("Enter Email ID:");
                Email = Console.ReadLine();
                Regex regex = new Regex(@"^[a-zA-Z0-9+_.-]+@[a-zA-Z]+(.com|.COM)$");
                
                bool isValidEmail = regex.IsMatch(Email);
               
                if (isValidEmail)
                {

                    checkVariable_2 = 0;
                    EmployeeEmail = Email;
                    break;
                }
                else
                {
                    checkVariable_2 = 1;
                    Console.WriteLine("INVALID MAIL Id");
                }
            }
        }
        public void getEmployeePhoneNumber()
        {
            String PhoneNumber;
            var checkVariable_3 = 0;
            while (checkVariable_3==0)
            {
                Console.WriteLine("Enter Mobile Number:");
                PhoneNumber = Console.ReadLine();
                Regex regex = new Regex("(91)?[5-9][0-9]{9}$");
                bool isValidPhoneNumber = regex.IsMatch(PhoneNumber);
                if ((isValidPhoneNumber) && (PhoneNumber.Length == 10))
                {
                    checkVariable_3 = 1;
                    EmployeePhoneNumber = PhoneNumber;
                    break;
                }
                else
                {
                    checkVariable_3 = 0;
                    Console.WriteLine("INVALID Number--Please enter a 10 digit number  ");
                }
            }

        }
        public void getDateOfBirth()
        {
            var variable = 0;

            while (variable != 1)
            {
                Console.Write("Enter date of birth :");
                DateTime birthday = DateTime.Parse(Console.ReadLine());
                //Console.WriteLine("BirthDay: {0:yyy-MM-dd}", birthday.Date);
                TimeSpan diff = DateTime.Now.Date - birthday.Date;
                DateTime zeroDate = new DateTime(1, 1, 1);
                //Console.WriteLine("zero date: {0:yyy-MM-dd}", zeroDate.Date );
                int age = (zeroDate + diff).Year - 1;
                if (age < 18 || age > 60)
                {
                    Console.WriteLine("Invalid age--Age must be between 18-60");
                }
                else
                {
                    Console.WriteLine("Age: {0}", age);
                    EmployeeAge = age;
                    variable = 1;
                    break;
                }
            }
        }
        /*public void ValidateDateOfBirth() 
        {
            var checkVariable = 0;

            while (checkVariable!=1)
            {
                Console.Write("Enter date of birth -- YYYY-MM-DD format: ");
                DateTime birthdate = DateTime.Parse(Console.ReadLine());
                TimeSpan diff = DateTime.Now.Date - birthdate.Date;
                DateTime Date = new DateTime(1, 1, 1);
                int age = (Date + diff).Year - 1;
                if (age < 18 || age > 60)
                {
                    Console.WriteLine("Invalid Age - Age must be between 18-60");
                }
                else
                {
                    Console.WriteLine("Age - ", age);
                    EmployeeAge = age;
                    checkVariable = 1;
                    break;
                }
            }
        }*/

        public virtual  void getprojectDetails()
        {
            Console.WriteLine("enter project name");
            Console.ReadLine();
        }
        public void getEmployeeprintdetails()
        {
            Console.WriteLine(" Displaying the details of employee " + EmployeeName);
            Console.WriteLine("Employee Name :" + EmployeeName);
            Console.WriteLine("Employee Id :" + EmployeeId);
            Console.WriteLine("Employee PhoneNumber :" + EmployeePhoneNumber);
            Console.WriteLine("Employee Email :" + EmployeeEmail);
            Console.WriteLine("Employee Age :" + EmployeeAge);
            //Console.WriteLine("Project Name:" + projectName);
 
            String[] DetailsInArray = { "Employee ID :" + EmployeeId, "Employee Name : " + EmployeeName, "Employee Contact No. : " + EmployeePhoneNumber, "Employee MailID  : " + EmployeeEmail, "Employee Age : " + EmployeeAge };
            Console.WriteLine("\n\nDETAILS ADDED TO ARRAY");
            foreach (var details in DetailsInArray)
                Console.WriteLine(details);
            ArrayList list;
            list = new ArrayList();
            list.Add(EmployeeId);
            list.Add(EmployeeName);
            list.Add(EmployeeEmail);
            list.Add(EmployeePhoneNumber);
            list.Add(EmployeeAge);
            list.Add(projectName);
            foreach (var details in list)
                Console.WriteLine(details);
        }
        
        public void connectToServer()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=RVSKCH576LT;Database=Project;Trusted_Connection=true";
                conn.Open();
                Console.WriteLine("INSERT INTO command");

                SqlCommand insertCommand = new SqlCommand("INSERT INTO connection (employeeId,employeeName,Email,Phonenumber) VALUES (@0,@1,@2,@3)", conn);
                insertCommand.Parameters.Add(new SqlParameter("0", EmployeeId));
                insertCommand.Parameters.Add(new SqlParameter("1", EmployeeName));
                insertCommand.Parameters.Add(new SqlParameter("2", EmployeeEmail));
                insertCommand.Parameters.Add(new SqlParameter("3", EmployeePhoneNumber));

                Console.WriteLine("Commands executed  - Total rows affected are " + insertCommand.ExecuteNonQuery());
                Console.WriteLine("Data added to database");
                Console.ReadLine();
                Console.Clear();
            }


        
        /*public class Trainee : Validatedetails
        {
            public override void getprojectDetails()
            {
            Console.WriteLine("If allocated to project Yes/no");
                Console.ReadLine();

            }*/


        }
    }
}
