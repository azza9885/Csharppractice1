using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpTopics
{
    public class LambdaExample_BabyNames
    {
        public string BabyName { get; set; }
        public string MotherName { get; set; }

        public int BabyAge { get; set; }
    }

    public class demo1
    {
        public static void Main()
        {
            List<LambdaExample_BabyNames> Babies = new List<LambdaExample_BabyNames>()
            {
                new LambdaExample_BabyNames{BabyName = "Aaira Nisa",MotherName = "Sadia Jabeen",BabyAge=6},
                new LambdaExample_BabyNames{BabyName = "Aanya Kakani",MotherName = "Divya Kakani",BabyAge=2},
                new LambdaExample_BabyNames{BabyName = "Vajra Veduru",MotherName ="Tina Vedururu",BabyAge=50},
                new LambdaExample_BabyNames{BabyName = "Anagha Mayreddy",MotherName="Preeti Reddy",BabyAge=15}
            };

            //var BabyGirlName = Babies.Select(x => x.BabyName);
            //var BabyGirlMotherName = Babies.Select(x => x.MotherName);
            //foreach(var item in BabyGirlName)
            //{

            //    foreach(var item1 in BabyGirlMotherName)
            //    {
            //        Console.WriteLine("\n Baby Name is : " + item);
            //        Console.WriteLine("\n Baby's Mother Name is :" + item1);
            //    }
            //}

            //var BabyGirlDetails = Babies.Select(x => new { BabyGirlName = x.BabyName, BabyGirlMotherName = x.MotherName });
            //foreach(var item in BabyGirlDetails)
            //{
            //    Console.WriteLine(item);
            //}

            var Babysort_by_Age = Babies.OrderByDescending(x => x.BabyAge);
            foreach(var item1 in Babysort_by_Age)
            {
                Console.WriteLine("Baby Name is : " + item1.BabyName + " \t Baby Age is : " + item1.BabyAge + " \t Baby Mother Name is : "
                    + item1.MotherName);
            }
        }

        
    }
}
