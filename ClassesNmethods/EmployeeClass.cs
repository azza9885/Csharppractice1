using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ClassesNmethods
{
    [TestClass]
    public class Testingsection
    {
        [TestMethod]
        public void employeefullName()
        {
            EmployeeClass myEmployee = new EmployeeClass("Peter", "Parker");
            string fullName = myEmployee.ReturnFullName();
            StringAssert.Equals(fullName, "Peter Parker");
        }

        [TestMethod]
        public void employee_fullName_Sorting()
        {
            EmployeeClass myEmployee = new EmployeeClass("Ganesh","Hegde");
            string fullName4Sorting = myEmployee.ReturnFullNameforSortingPurposes();
            StringAssert.Equals(fullName4Sorting, "Hegde, Ganesh");
        }

    }
    public class EmployeeClass
    {
        private string employeenumber;
        private string empfirstName;
        private string emplastName;
        private string dateOfHire;
        private string jobDescription;
        private string department;
        private double monthlySalary;
        public EmployeeClass(string empFN,string empLN)
        {
            EmpFirstName = empFN;
            EmpLastName = empLN;
        }

        public EmployeeClass(string eFN,string eLN,string eNUM,string dOFhire,string jobDesc,string DEP,double mSalary)
        {
            Employeenumber = eNUM;
            EmpLastName = eLN;
            EmpFirstName = eFN;
            DateofHire = dOFhire;
            JobDescription = jobDesc;
            Department = DEP;
            MonthlySalary = mSalary;
        }

        //properties
        public string Employeenumber
        {
            get { return employeenumber; }

            set { employeenumber = value; }
        }

        public string EmpFirstName
        {
            get { return empfirstName; }
            set { empfirstName = value; }
        }

        public string EmpLastName
        {
            get { return emplastName; }
            set { emplastName = value; }
        }

        public string DateofHire
        {
            get { return dateOfHire; }
            set { dateOfHire = value; }
        }

        public string JobDescription
        {
            get { return jobDescription; }
            set { jobDescription = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public double MonthlySalary
        {
            get { return monthlySalary; }

            set { monthlySalary = value; }
        }

        //methods

        public string ReturnFullName()
        {
            return EmpFirstName + "" + EmpLastName;
        }

        public string ReturnFullNameforSortingPurposes()
        {
            return EmpLastName + ", " + EmpFirstName;
        }
    }
}
