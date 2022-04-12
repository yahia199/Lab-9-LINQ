using System;
using System.IO;
using Newtonsoft.Json;
using System.Linq;


namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = "../../../json1.json";
            string Read = File.ReadAllText(Path);
            FeatureCollection featureCollection = JsonConvert.DeserializeObject<FeatureCollection>(Read);


              var Filter = from item in featureCollection.features select item.properties.neighborhood;
            int counter = 1;
            foreach (var item in Filter)
            {
                Console.WriteLine($"{counter}. {item}");
                counter++;
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");

            var FilterTwo = from item in featureCollection.features
                            where item.properties.neighborhood!= ""
                            select item.properties.neighborhood;
            int counter2 = 1;
            foreach (var item in FilterTwo)
            {
                Console.WriteLine($"{counter2}. {item}");
                counter2++;
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");

            var FilterThree = from item in featureCollection.features
                            where item.properties.neighborhood != ""
                            select item.properties.neighborhood;
            var Doubly = FilterThree.Distinct();
            int counter3 = 1;
            foreach (var item in Doubly)
            {
                Console.WriteLine($"{counter3}. {item}");
                counter3++;
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");

            var FilterFourth = (from item in featureCollection.features
                              where item.properties.neighborhood != ""
                              select item.properties.neighborhood).Distinct();
           
            int counter4 = 1;
            foreach (var item in FilterFourth)
            {
                Console.WriteLine($"{counter4}. {item}");
                counter4++;
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");

            var Filter5 = featureCollection.features.Select(x => x.properties.neighborhood);
            int counter5 = 1;
            foreach (var item in Filter5)
            {
                Console.WriteLine($"{counter5}. {item}");
                counter5++;
            }
            Console.WriteLine("+++++++++kjkjh+++++++++++++++++++++++++++++++++++++++++");


        }


    }
    
}
//Output all of the neighborhoods in this data list (Final Total: 147 neighborhoods)
//Filter out all the neighborhoods that do not have any names (Final Total: 143)
//Remove the duplicates (Final Total: 39 neighborhoods)
//Rewrite the queries from above and consolidate all into one single query.
//Rewrite at least one of these questions only using the opposing method(example: Use LINQ Query statements instead of LINQ method calls and vice versa.)
//You should have a total of 5 outputs.
