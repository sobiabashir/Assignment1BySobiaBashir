using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment1BySobiaBashir
{
    internal class Employe
    {
        public string firstName;
        public string lastName;
        public string email;

        public int numberOfHoursWorked;
        public double wage;
        public double hourlyRate;

        const int minimalHoursWorkedUnit = 40;
        public void DisplayPattern()
        {
            Console.WriteLine();
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine();
        }

        public  void ReadEmployeInfo()  
        {

            Console.WriteLine("What is the your first name ?");
            firstName = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("What is the your last name ?");
            lastName = Console.ReadLine();
            
            Console.WriteLine("What is the your email?");
            email = Console.ReadLine();
            
            Console.WriteLine("What is the rate of wages per hour?");
            string textRead= Console.ReadLine();
            hourlyRate = double.Parse(textRead);

            Console.WriteLine("How many hour you have worked?");
            string textReadWork = Console.ReadLine();
            numberOfHoursWorked =int.Parse(textReadWork);

            Console.WriteLine("");

                       
        }

              
        public double ReceiveWage()
        {
            wage = numberOfHoursWorked * hourlyRate;
            return wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: \t{firstName}\nLast name: \t{lastName}\nEmail: \t\t{email}\n");
            Console.WriteLine("");
            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hour(s) of work.");
        }


        public void Start()
        {
            Console.Clear();
            Console.WriteLine();
            DisplayPattern();
            Console.WriteLine("***** Greeting from Employee class *******");
            Console.WriteLine("***** Todays Date is :" + DateTime.Today + "   *******");

            Console.WriteLine();
            DisplayPattern();

            ReadEmployeInfo();
            ReceiveWage();

            DisplayEmployeeDetails();
            
        }

    }
}
