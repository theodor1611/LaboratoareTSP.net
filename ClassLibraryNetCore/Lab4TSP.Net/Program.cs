using System;
using System.Linq;
using ClassLibraryNetCore;
namespace Lab4TSP.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            PeopleContext pctx = new PeopleContext();

            var myList = pctx.Persons.ToList();
            foreach (var person in myList)
            {
                Console.WriteLine($"{person.Id} {person.FirstName} {person.MiddleName} {person.LastName} {person.TelephonNumber}");
            }
            Console.ReadLine();
        }
    }
}
