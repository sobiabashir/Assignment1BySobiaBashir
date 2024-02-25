using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1BySobiaBashir
{
    internal class TicketSeller
    {
        private string name;
        private double priceTotal;
        private int ageOfChild;
        private int numberOfAdults;
        private int numberOfChild;
        private double totalAmountToPay;

        
        public DateTime visitFair = DateTime.Today;
        private const int priceOfTicketAdult = 150;
        private const int priceOfTicketChild = 100;

        private void ReadInformationOfFair()
        {
            
            Console.WriteLine("What is the your name ?");
            name = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("How many adults are with you ?");
            string textRead= Console.ReadLine();
            numberOfAdults = int.Parse(textRead);

            Console.WriteLine("How many children are with you ?");
            string textRead1 = Console.ReadLine();
            numberOfChild=int.Parse(textRead1);

            Console.WriteLine("");

        }


        public void DisplayPattern()
        {
            Console.WriteLine();
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine();
        }


        private void DisplayDetailInfo()
        {
            
            int discountAmount;
                      
            if (numberOfChild >= 2)
            {
                Console.WriteLine( "Here is 20% discount for you on children tickets :");
                discountAmount = (priceOfTicketChild - (priceOfTicketChild * (25 / 100)));
                totalAmountToPay = (numberOfChild * discountAmount) + (numberOfAdults * priceOfTicketAdult);

            }
            else
            {
                Console.WriteLine("You have to pay full price :");
                discountAmount = 0;
                totalAmountToPay = (numberOfChild * priceOfTicketChild) + (numberOfAdults * priceOfTicketAdult);
            }

            DisplayPattern();
            string stringToDisplayInfo = " Name: " + name + " \n Date of visit :" + visitFair + " \n Number_of_Adults :" + numberOfAdults
               + " \n Number_of_Child :" + numberOfChild + " \n Total amount :" + totalAmountToPay;
            Console.WriteLine(stringToDisplayInfo);

        }

        public void Start()
        {
            Console.Clear();
            Console.WriteLine();
            DisplayPattern();
            Console.WriteLine("***** Greeting from TicketSeller class *******");
            Console.WriteLine("***** Todays Date is :" + visitFair + "   *******");


            Console.WriteLine();
            DisplayPattern();
            ReadInformationOfFair();
            DisplayDetailInfo();
        }


    }
}
