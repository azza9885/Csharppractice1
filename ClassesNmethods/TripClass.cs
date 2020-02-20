using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesNmethods
{
    public class TripClass
    {
        string destination;
        double distance_travelled;
        double gasolinecost_total;
        double numberOfGallons_consumed;

        public TripClass(string tripDestination,double distanceTravelled,double gasolineExpense,double fuelConsumed)
        {
            Destination = tripDestination;
            Distance_travelled = distanceTravelled;
            Gasolinecost_total = gasolineExpense;
            NumberofGallons_consumed = fuelConsumed;
        }

        public string Destination
        {
            get { return destination; }

            set { destination = value; }
        }

        public double Distance_travelled 
        { 
         get { return distance_travelled; } 
            
         set { distance_travelled = value; }
        }

        public double Gasolinecost_total
        {
            get { return gasolinecost_total; }
            set { gasolinecost_total = value; }
        }

        public double NumberofGallons_consumed
        {
            get { return numberOfGallons_consumed; }
            set { numberOfGallons_consumed = value; }
        }

        public double Calculate_Miles_perGallon()
        {
            double MilesperG = Distance_travelled / NumberofGallons_consumed;

            //Console.WriteLine("the miles per gallon for the trip to : " + Destination + " is " + MilesperG);

            return MilesperG;
        }

        public double Cost_per_Mile()
        {
            double PerMileCost = Gasolinecost_total / Distance_travelled;

            //Console.WriteLine("The cost per mile for trip to : " + Destination + " is " + PerMileCost);

            return PerMileCost;
        }

        public override string ToString()
        {
            string GasolinecostinCurrency = String.Format("{0:C}",Gasolinecost_total);
            return "The trip to : " + Destination + "  is " + Distance_travelled + " miles and the total Gas expenses are estimated to be "
                    + GasolinecostinCurrency + " with " + NumberofGallons_consumed + " gallons of gas consumed ";
                 
        }
    }
}
