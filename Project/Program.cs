using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Validatedetails();
           // var trainee = new Trainee();
            employee.getEmployeeId();
            employee.getEmployeeName();
            
            employee.getEmployeePhoneNumber();
            employee.getEmployeeEmail();
            employee.getDateOfBirth();
            employee.getprojectDetails();
            employee.getModeOfWork();
            employee.getExperienceDetails();
            var trainee = new Trainee();  
            trainee.getEmployeeName();
            //ainee.SetQualification("BTECH");
            //trainee.getQualificationDetails = "BTECH";//we can't access the private data from an object instance
           // Console.WriteLine("Qualification: " + trainee.getQualificationDetails);
            trainee.getprojectDetails();
            trainee.getModeOfWork();
            
            employee.getEmployeeprintdetails();
            Console.ReadLine();
            employee.connectToServer();
        }
    }
}
