using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OSSN.Models;

namespace OSSN.Data
{
    public static class DbInitializer
    {
        public static void Initialize(OpenSSNDBContext context)
        {
            context.Database.EnsureCreated();

            if (context.Ship.Any())
            {
                return;
            }

            //var ships = new Ship[]
            //{
            //    new Ship{}
            //}
        }
    }
}
