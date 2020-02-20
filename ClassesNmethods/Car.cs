using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesNmethods
{
    public class Car
    {
        //private variables that help us define properties
        //of a car ( or class)
        string color;
        int numberOfDoors;
        bool isConvertible;

        public Car(string carColor,int doors,bool convertible)
        {
            //not assigning the values being passed directly to variables instead assigning them to the properties first
            Color = carColor;
            NumberofDoors = doors;
            IsConvertible = convertible;

        }

        //Constructor - factory for creating objects of the class

        //Get and Set accessors(allow us to control the access to the private variables in the class to make sure we are
        // not going to set things that should not be set)
        //Get and Set accessors - Properties that define noun like attributes of the class
        public string Color // property names are generally upper case corresponding to their variables
        {
            get { return color; }
            set { color = value; }
        }

        public bool IsConvertible { get; set; }

        public int NumberofDoors
        {
            get { return numberOfDoors; }

            set
            {
                if(value <= 4)
                {
                    numberOfDoors = value;
                }

                else
                {
                    //show the user some appropriate error message
                }
            }
        }

        

        //Methods - Verb attributes that tell us what a class can do
        public void Accelerate()
        {
            Console.WriteLine("I am Accelerating..");
        }

        public bool FamilyCar()
        {
            if(NumberofDoors >= 4)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
