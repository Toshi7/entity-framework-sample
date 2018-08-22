using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace TestingDb
{
    class TestingDb
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.ReadLine();
            // create new Student entity object in disconnected scenario (out of the scope of DbContext)


//            var newkeihi = new Testing_KeihiDetail();

            ////set newkeihi name
            //newkeihi.Id = 1;
            //newkeihi.Amount = 108;
            //newkeihi.Payee = "TOMOYOSE";
            ////Console.ReadLine();

            //create DBContext object
            using (var dbCtx = new KeihiContext()) 
            {
                // To update
                var newkeihi = dbCtx.KeihiMeisais.SingleOrDefault(e => e.Id == 1);
                newkeihi.Amount = 115;
                //dbCtx.Entry(newkeihi).State = EntityState.Modified;


                //Add KeihiMeisais object into Students DBset
                dbCtx.Database.EnsureCreated();
                //dbCtx.KeihiMeisais.Add(newkeihi);
                // call SaveChanges method to save student into database
                dbCtx.SaveChanges();
                Console.WriteLine("updated data!");
                Console.ReadLine();
            }

        }
    }
}