using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Student_InterfaceExample : Person_InterfaceExample, ITraveller
    {
        private string StudentID;
        private string Major;


        public Student_InterfaceExample(string id, string fname, string lname, int anAge, DateTime dob, string sID, string maj)
            : base(id, fname, lname, anAge, dob)
        {
            StudentID = sID;
            Major = maj;
        }

        public string GetStarting_Location()
        {
            return "WashingTon D.C";
        }

        public string GetDestination()
        {
            return "Villanova University";
        }

        public double DetermineMiles()
        {
            return 200.0;
        }

        public override string ToString()
        {
            return base.ToString() + " " + "\n Student ID: " + StudentID + " " + "\n Student Major : " + Major;
        }
    }
}
