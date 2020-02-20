using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OO_Topics
{
    class Student : Person
    {
        private string StudentID;
        private string Major;


        public Student(string id,string fname,string lname,int anAge,DateTime dob,string sID,string maj) 
            :base(id,fname,lname,anAge,dob)
        {
            StudentID = sID;
            Major = maj;
        }

        public override string GetExerciseHabits()
        {
            return "Students have no time for exercise";

        }

        public DateTime dob()
        {
            DateTime dOFb = base.dateOfBirth;
            return dOFb;
        }
    }
}
