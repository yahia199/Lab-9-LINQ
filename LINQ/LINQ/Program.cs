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
            int counter = 0;
            foreach (var item in Filter)
            {
                counter++;

                Console.WriteLine($"{counter}. {item}");
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");

            var FilterTwo = from item in featureCollection.features
                            where item.properties.neighborhood!= ""
                            select item.properties.neighborhood;
            int counter2 = 0;
            foreach (var item in FilterTwo)
            {
                   counter2++;

                Console.WriteLine($"{counter2}. {item}");
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");

            var FilterThree = from item in featureCollection.features
                            where item.properties.neighborhood != ""
                            select item.properties.neighborhood;
            var Doubly = FilterThree.Distinct();
            int counter3 = 0;
            foreach (var item in Doubly)
            {
                counter3++;
                Console.WriteLine($"{counter3}. {item}");
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");

            var FilterFourth = (from item in featureCollection.features
                              where item.properties.neighborhood != ""
                              select item.properties.neighborhood).Distinct();
           
            int counter4 = 0;
            foreach (var item in FilterFourth)
            {
                counter4++;
                Console.WriteLine($"{counter4}. {item}");
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");

            var Filter5 = featureCollection.features.Select(x => x.properties.neighborhood);
            int counter5 = 0;
            foreach (var item in Filter5)
            {
                counter5++;
                Console.WriteLine($"{counter5}. {item}");
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
