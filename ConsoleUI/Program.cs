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
           // GetAll, GetById, Insert, Update, Delete.

    

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetCarDetailDtos())
            {
                Console.WriteLine("{0}/{1}",
                    item.CarName,item.BrandName);
            }
            Console.WriteLine("***********");
            Car car1 = new Car
            {
                CarId = 5,
                CarName = "Hello",
                BrandId = 2,
                ColorId = 3,
                Description = "merhaba",
                DailyPrice = 1590,
                ModelYear = 1998
            };

          

            carManager.Add(car1);
            Car car2 = new Car
            {
                CarId = 5,
                CarName = "whatt",
                BrandId = 2,
                ColorId = 3,
                Description = "merhaba",
                DailyPrice = 1590,
                ModelYear = 1998
            };

            foreach (var items in carManager.GetAll())
            {
                Console.WriteLine(items.CarName);
            }
  

            carManager.Update(car2);

            foreach (var items in carManager.GetAll())
            {
                Console.WriteLine(items.CarName);
            }




          
            foreach (var items in carManager.GetById(2))
            { Console.WriteLine(items.CarName); }


  
            carManager.Delete(car2);

            foreach (var items in carManager.GetAll())
            {
                Console.WriteLine(items.CarName);
            }

            foreach (var items in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine(items.Description);
            }

            foreach (var items in carManager.GetCarsByBrandId(3))
            {
                Console.WriteLine(items.CarName);
            }


             







        }
    }
}

