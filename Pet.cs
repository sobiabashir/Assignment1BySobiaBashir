using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1BySobiaBashir
{
    internal class Pet
    {
        private string petName;
        private int ageOfPet;
        private bool genderIsFemale;
        public DateTime datOftoday = DateTime.Today;
        private void ReadPetName()
        {
            Console.WriteLine("What is the name of your pet ?");
            petName = Console.ReadLine();
        }
        private void ReadPetAge()
        {
            Console.WriteLine("What is " + petName + " age ?");
            string textAge = Console.ReadLine();
            ageOfPet = int.Parse(textAge);
        }
        private void ReadPetGender()
        {
            Console.WriteLine("Is your pet female y/n");
            string genderOfPet = Console.ReadLine();
            char responce = genderOfPet[0];
            if ((responce == 'y') || (responce == 'Y'))
                genderIsFemale = true;
            if ((responce == 'n') || (responce == 'N'))
                genderIsFemale = false;
        }

        public void DisplayPattern()
        {
            Console.WriteLine();
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine();
        }

        private void ReadSavePetInfo()
        {
            ReadPetName();            
            ReadPetAge();
            ReadPetGender();
        }
        private void DisplayPetInfo()
        {
            DisplayPattern();
            string stringToDisplayInfo = " Name: " + petName + "  Age :" + ageOfPet;
            Console.WriteLine(stringToDisplayInfo);

            if (genderIsFemale == true)
                Console.WriteLine(petName + " : She is wonderful pet");
            else
                Console.WriteLine(petName + " : He is wonderful pet");
            DisplayPattern();
        }

        public void Start()
        {
            Console.Clear();
            Console.WriteLine();
            DisplayPattern();
            Console.WriteLine("***** Greeting from Pet class *******");
            Console.WriteLine("***** Todays Date is :" + datOftoday + "   *******");
            Console.WriteLine();

            ReadSavePetInfo();
            DisplayPetInfo();


        }

    }
}
