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

            // CarManagerGetCarDetailsDto(carManager);

            //     CrudOperations(carManager);




            //CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            //var result2 = customerManager.GetAll();
            //if (result2.Success == true)
            //{
            //    foreach (var item in result2.Data)
            //    {
            //        Console.WriteLine(item.CompanyName);

            //    }
            //    Console.WriteLine(result2.Message);



            //RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //var result = rentalManager.GetAll();
            //if (result.Success == true)
            //{
            //    foreach (var item in result.Data)
            //    {
            //        Console.WriteLine("Customer Id: {0} ///Car Id: {1} //  RentBeginDate : {2}", item.CustomerId, item.CarId, item.RentBeginDate);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

            //UserManager userManager = new UserManager(new EfUserDal());
            // var result4 = userManager.GetAll();
            // if (result4.Success == true)
            // {
            //     foreach (var item in result4.Data)
            //     {
            //         Console.WriteLine("User Email: {0} ///User Name {1} //  User SName : {2}",item.Email,item.FirstName,item.LastName);
            //     }
            // }
            // else
            // {
            //     Console.WriteLine(result4.Message);
            // }



            //    CarManager carManager = new CarManager(new EfCarDal());
            //    var result1 = carManager.GetAll();
            //        if (result1.Success == true)
            //        {
            //            foreach (var item in result1.Data)
            //            {
            //                Console.WriteLine("Car Name: " + item.CarName);

            //            }
            //            Console.WriteLine(result1.Message);
            //        }






            //}




            //private static void CrudOperations(CarManager carManager)
            //{
            //    Console.WriteLine("***********");
            //    Car car1 = new Car
            //    {
            //        CarId = 5,
            //        CarName = "Hello",
            //        BrandId = 2,
            //        ColorId = 3,
            //        Description = "merhaba",
            //        DailyPrice = 1590,
            //        ModelYear = 1998
            //    };



            //    carManager.Add(car1);
            //    Car car2 = new Car
            //    {
            //        CarId = 5,
            //        CarName = "whatt",
            //        BrandId = 2,
            //        ColorId = 3,
            //        Description = "merhaba",
            //        DailyPrice = 1590,
            //        ModelYear = 1998
            //    };

            //    foreach (var items in carManager.GetAll())
            //    {
            //        Console.WriteLine(items.CarName);
            //    }


            //    carManager.Update(car2);

            //    foreach (var items in carManager.GetAll())
            //    {
            //        Console.WriteLine(items.CarName);
            //    }





            //    foreach (var items in carManager.GetById(2))
            //    { Console.WriteLine(items.CarName); }



            //    carManager.Delete(car2);

            //    foreach (var items in carManager.GetAll())
            //    {
            //        Console.WriteLine(items.CarName);
            //    }

            //    foreach (var items in carManager.GetCarsByColorId(2))
            //    {
            //        Console.WriteLine(items.Description);
            //    }

            //    foreach (var items in carManager.GetCarsByBrandId(3))
            //    {
            //        Console.WriteLine(items.CarName);
            //    }
            //}
            //------------------------------------------------------------------------------------------//
            //private static void CarManagerGetCarDetailsDto(CarManager carManager)
            //{
            //    var result = carManager.GetCarDetailDtos();
            //    if (result.Success == true)
            //    {
            //        foreach (var item in result.Data)
            //        {
            //            Console.WriteLine("Car Name: {0} ///Brand Name: {1}  ", item.CarName, item.BrandName);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine(result.Message);
            //    }
            //}



        }
    }
}
