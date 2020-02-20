using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class EmployeeClass1
    {
        
        public EmployeeClass1(int id)
        {
            Id = id;
        }

        public EmployeeClass1(string name,int id,string title)
        {
            Name = name;
            Id = id;
            Jobtitle = title;
        }

        //properties
        public string Name
        {
            get; set;
        }

        public int Id
        {
            get; set;
        }

        public string Jobtitle
        {
            get; set;
        }

        //methods

        public string JobLocation()
        {
            if (Jobtitle == "Manager")
            {
                return "Boston";
            }

            else if (Jobtitle == "Staff")
            {
                return "Philadelphia";
            }

            else
            {
                return "NewYork";
            }
                
        }

        //ToString - Manufactures a human-readable text string that describes an instance of the class.
        public override string ToString()
        {
            return Id + " " + Name + "  Job Title : " + Jobtitle; 
        }

        public string PayType(string title)
        {
            if (title == "Manager")
            {
                return "Monthly";
            }

            else if (title == "Staff")
            {
                return "BiWeekly";
            }

            else
            {
                return "Hourly";
            }

        }

        public string PayType(int id)
        {
            if (id == 12345)
            {
                return "Monthly";
            }

            else if (id == 54321)
            {
                return "BiWeekly";
            }

            else
            {
                return "Hourly";
            }

        }

        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj);
        //}

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}
    }
}
