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
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("-------GetById()------");
            productManager.GetById(1);
            
              
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

