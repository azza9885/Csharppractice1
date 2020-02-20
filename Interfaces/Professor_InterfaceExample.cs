using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Professor_InterfaceExample : Person_InterfaceExample,ITraveller
    {
        private string empID;
        private string subject;

        public Professor_InterfaceExample(string id, string fname, string lname, int anAge, DateTime dob, string employeeID, string SpecializedSubjectTopic)
             : base(id, fname, lname, anAge, dob)
        {
            empID = employeeID;
            subject = SpecializedSubjectTopic;
        }

        public string GetStarting_Location()
        {
            return "East Windsor,NJ";
        }

        public string GetDestination()
        {
            return "MIT,Boston";
        }

        public double DetermineMiles()
        {
            return 350.45;
        }

        public override string ToString()
        {
            return base.ToString() + " " + "\n Employee ID : " + empID + " " + "\n Subject Expertise : " + subject;
        }
    }
}
