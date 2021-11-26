using System;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Service.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            InternManager internManager = new InternManager(new EfInternDal());
            foreach (var intern in internManager.GetAll())
            {
                Console.WriteLine(intern.FirstName);
            }
            Console.WriteLine("Hello World!");
        }
    }
}