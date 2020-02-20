using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpTopics
{
    public class LambdaExampleDogs_AnonymousMethods
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }

    public class demo
    {
        public static void Main()
        {
            List<LambdaExampleDogs_AnonymousMethods> dogs = new List<LambdaExampleDogs_AnonymousMethods>()
            {
                new LambdaExampleDogs_AnonymousMethods{Name = "Snoopy",Age=3},
                new LambdaExampleDogs_AnonymousMethods{Name = "Rex",  Age=4},
                new LambdaExampleDogs_AnonymousMethods{Name = "Molly", Age=6}
            };


            var DogNameList = dogs.Select(x => new { DogAge = x.Age, FirstLetter = x.Name[0] });
            foreach (var item in DogNameList)
            {
                Console.WriteLine(item);

            }


        }

    }


}
