using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amber_Cook___1
    //Program Developer:Amber Cook (Student_id:30010451)
    //Program for capturing information about New Zealand Bird of Prey that have been rescued and banded at Wingspan National Bird of Prey Center in Paradise Valley, Rotorua.
{
    class Program
    {
        //Main method of the program.
        static void Main(string[] args)
        {
            //Created object of the Bird class called "b1". And initialised object with the default data.
            Bird b1 = new Bird("Name unknown", " Species unknown", "Sex unknown", "Weight unknown", "Band Number unknown");

            //Prompt user to update birds data and updating the 'b1' objects properties.
            Console.WriteLine("\nPLEASE UPDATE BIRD DATA");
            Console.Write("\nEnter Bird Name: ");
            b1.Name = Console.ReadLine();
            Console.Write("Enter Bird Species: ");
            b1.Species = Console.ReadLine();
            Console.Write("Enter sex of Bird: ");
            b1.Sex = Console.ReadLine();
            Console.Write("Enter weight of Bird: ");
            b1.Weight = Console.ReadLine();
            Console.Write("Enter Band number of Bird: ");
            b1.BandNo = Console.ReadLine();

            //Using the displayBird() method to display all of 'b1' Bird information to the screen.
            Console.WriteLine(b1.displayBird());
            Console.ReadLine(); //Put a Console.ReadLine so info stays on screen for testing
            
        }
    }

    //Creating the Bird Class
    class Bird
    {
        //Creating properties for the Bird class
        public string name;
        public string species;
        public string sex;
        public string weight;
        public string bandNo;

        //Getters & Setters for properties
        public string Name { get { return name; } set{ name = value; } }
        public string Species { get { return species; } set { species = value; } }
        public string Sex { get { return sex; } set { sex = value; } }
        public string Weight { get { return weight; } set { weight = value; } }
        public string BandNo { get { return bandNo; } set { bandNo = value; } }

        //Constructor for initialising the Bird object.
        public Bird(string _name, string _species, string _sex, string _weight, string _bandNo)
        {
            Name = _name;
            Species = _species;
            Sex = _sex;
            Weight = _weight;
            BandNo = _bandNo;
            Console.WriteLine("Bird object created and default data loaded...");
        }

        //Created a displayBird() method that will display all of the birds information to the console screen.
        public string displayBird()
        {
            return "\n\nBIRD OF PREY DATA OUTPUT \nBird name:" + Name +  "\nSpecies:" + Species + "\nSex:" + Sex + "\nWeight:" + Weight + "\nBand Number:" + BandNo;                   
        }
    }
}
