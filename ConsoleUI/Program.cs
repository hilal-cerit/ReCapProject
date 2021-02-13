using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {


            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var items in colorManager.GetAll())
            {
                Console.WriteLine(items.ColorName);
            }
         

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var items in carManager.GetAll())
            {
                Console.WriteLine(items.CarName);
            }



        }
    }
}

