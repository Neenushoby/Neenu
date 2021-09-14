using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Trainee : Validatedetails,Interface1
    {
        public Trainee()
        {
            String employeeType;
            employeeType = "Trainee Details";
            Console.WriteLine(employeeType);
            Console.ReadLine();

        }
        // we are using  accessors which contains the get and set method to retrieve and set the values of private fields. 
        /*private String qualification;

        //We manipulate the data only using these two methods.
        //public String getQualificationDetails//Accessors are defined as public so that they can access in other class.
        {

            get
            {
                return qualification;
            }

            set
            {
                qualification = value;
            }
        }


        /*ivate string TraineeeQualification;
        // Accessor.  
        /*blic string GetQualification();
        {
            return TraineeQualification;
        }
        // Mutator.  
        public void SetQualification(string qualification)
        {
        TraineeQualification = qualification;
        }*/
        public override void getprojectDetails()
        {
            Console.WriteLine("If allocated to project Yes/no");
            Console.ReadLine();



        }
        public void getModeOfWork()
        {
            Console.WriteLine("enter the mode of work");
            Console.ReadLine();
        }
        public void getExperienceDetails()
        {
            Console.WriteLine("Total Experience at this organisation in years");
        }
    }
}
