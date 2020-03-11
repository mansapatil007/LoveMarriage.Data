using LoveMarriage.Data;
using System;

namespace DAL.TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using (var unitofwork = new UnitOfWork(new LoveMarriage.Data.Models.LoveMarriageDBContext()))
            {
                //Example 1
                unitofwork.XBloodGroup.Get(1);

                //Example 2
                var bloodGroups = unitofwork.XBloodGroup.GetAll();

                //Example 3
                var test = unitofwork.XBloodGroup.GetUniversalDonorBloodGroup();

                //this will end unit of work
                unitofwork.Complete();
                Console.ReadLine();
            }
        }
    }
}
