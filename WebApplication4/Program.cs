using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OSSN.Models;

namespace OSSN
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // BuildWebHost(args).Run();


            //using (var db = new OpenSSNDBContext())
            //{
            //    // Creating a new Person and saving it to the DB
            //    var newPerson = new Person();
            //    newPerson.Firstname = "Axel";
            //    newPerson.Lastname = "Kvistad";
            //    db.Person.Add(newPerson);
            //    var count = db.SaveChanges();
            //    Console.WriteLine("{0} records saved to database", count);

            //    Console.WriteLine("\nAll persons in the database:");
            //    foreach (var person in db.Person)
            //    {
            //        Console.WriteLine("{0} {1}", person.Firstname, person.Lastname);
            //    }
            //} 
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
