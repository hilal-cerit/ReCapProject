using Business.Concrete;
using DataAccess.Concrete;
using Entities;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            ProductManager productManager = new ProductManager(new InMemoryProductDal());



            Console.WriteLine("-------GetAll()------");
            foreach (var car in productManager.GetAll())
            {
                Console.WriteLine(car);
            }
            Console.WriteLine("-------GetById()------");
            foreach (var car in productManager.GetById(1))
            {
                Console.WriteLine("Araba : " + car.Description + " Marka Id : " + car.ColorId + " Model Yılı : " + car.ModelYear);

                Console.WriteLine("-------Add()------");

                Car car1 = new Car()
                {
                    Id = 5,
                    BrandId = 8,
                    ColorId = 456,
                    DailyPrice = 14000,
                    ModelYear = "2010",
                    Description = "789 hp"
                };

                productManager.Add(car1);

                foreach (var product in productManager.GetAll())
                {
                    Console.WriteLine("Araba : " + product.Description);
                }

                Console.WriteLine("-------Delete()------");
                productManager.Delete(car1);

                foreach (var product in productManager.GetAll())
                {
                    Console.WriteLine("Araba : " + product.Description);
                }






            }
        }
    }
}
