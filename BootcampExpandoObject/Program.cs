using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampExpandoObject
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic sampleFootballLegenObject = new ExpandoObject();

            sampleFootballLegenObject.FirstName = "Joro";
            sampleFootballLegenObject.LastName = "Beckham-a";
            sampleFootballLegenObject.Team = "Loko Mezdra";
            sampleFootballLegenObject.Salary = 380.5m;
            sampleFootballLegenObject.AsString = new Action(() =>
                            Console.WriteLine("{0} {1} {2} {3}",
                            sampleFootballLegenObject.FirstName,
                            sampleFootballLegenObject.LastName,
                            sampleFootballLegenObject.Team,
                            sampleFootballLegenObject.Salary
                            ));

            sampleFootballLegenObject.AsString();

            Console.ReadLine();

            // use the IDictionary interface implementation of ExpandoObject() to get a list of its members
            // INotifyPropertyChanged is also implemented by ExpandoObject()
            foreach (var property in (IDictionary<String, object>)sampleFootballLegenObject)
                Console.WriteLine(property.Key + ": " + property.Value);
            Console.ReadKey();
        }
    }
}
