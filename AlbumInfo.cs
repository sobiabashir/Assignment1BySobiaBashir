using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment1BySobiaBashir
{
    internal class AlbumInfo
    {
        private string nameOfAlbum;
        private string albumType;
        private string singerName;
        private double priceOfAlbum;
        private int noOfCopies;

        private void ReadInformationOfAlbum()
        {

            Console.WriteLine("What is the name of album ?");
            nameOfAlbum = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("What is the type of album ?");
            albumType = Console.ReadLine();

            Console.WriteLine("What is the name of singer name ?");
            singerName= Console.ReadLine();

            Console.WriteLine("What is the price of album ?");
            string textReadAlbum=Console.ReadLine();
            priceOfAlbum = double.Parse(textReadAlbum);

            Console.WriteLine("What are the number of copies sold ?");
            string textReadCopies = Console.ReadLine();
            priceOfAlbum = int.Parse(textReadCopies);

            Console.WriteLine("");

        }



        public void DisplayPattern()
        {
            Console.WriteLine();
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine();
        }


        private void DisplayDetailInfoAlbum()
        {

            DisplayPattern();
            string stringToDisplayInfoAlbum = "Name of album:\t" + nameOfAlbum + "\nType of album:\t" + albumType + "\nName of singer:\t" + singerName + 
                " \nPrice of album is:\t" + priceOfAlbum + "\nNumber of copies sold:\t" + noOfCopies;
            Console.WriteLine(stringToDisplayInfoAlbum);

        }


        public void Start()
        {
            Console.Clear();
            Console.WriteLine();
            DisplayPattern();
            Console.WriteLine("***** Greeting from Album class *******");
            Console.WriteLine();
            DisplayPattern();
            ReadInformationOfAlbum();
            DisplayDetailInfoAlbum();
        }


    }
}
