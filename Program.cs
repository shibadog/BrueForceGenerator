using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace BrueForceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            using(TextReader input = Console.In)
            {
                string json = input.ReadToEnd();
                var elements = JsonConvert.DeserializeObject<List<Element>>(json);

                var petterns = Mulutiple(elements.Select(v => v.Attributes).ToList(), new List<string>(), new List<List<string>>());

                //petterns.ForEach(p => Console.WriteLine(String.Join(",", p)));

                var results = petterns.Select(
                        v => v.Zip(elements.Select(elm => elm.Name), (first, second) => new Dictionary<string, string>() {{second, first}})
                                .Aggregate(new Dictionary<string, string>(), (r, next) => r.Concat(next).ToDictionary(x => x.Key, x => x.Value))
                    );

                Console.WriteLine(JsonConvert.SerializeObject(results));
            }
        }

        static List<List<string>> Mulutiple(List<List<string>> attributesList, List<string> a, List<List<string>> c)
        {
            if (attributesList.Count > 1) {
                var attrs = attributesList[0];
                foreach(string val in attrs)
                {
                    var b = new List<string>(a);
                    b.Add(val);
                    Mulutiple(attributesList.GetRange(1, attributesList.Count - 1), b, c);
                }
            } else {
                var attrs = attributesList[0];
                foreach(string val in attrs)
                {
                    var b = new List<string>(a);
                    b.Add(val);
                    c.Add(b);
                }
            }
            return c;
        }
    }
}