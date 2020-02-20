using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpTopics
{
    class LambdaExample_Dogs
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class DogName_Demo
    {
        public static void Main()
        {
            List<LambdaExample_Dogs> dogs = new List<LambdaExample_Dogs>() 
            { 
                new LambdaExample_Dogs{Name = "Tiger",Age = 3},
                new LambdaExample_Dogs{Name = "Scooby",Age = 4},
                new LambdaExample_Dogs{Name = "Rambo",Age = 5}
            };

            var DogNames = dogs.Select(x => x.Name);

            foreach(var dogName in dogs)
            {
                Console.WriteLine("Dog Name is : " + dogName.Name + "Dog Age is : " + dogName.Age);
            }
                
        }
    }

}
