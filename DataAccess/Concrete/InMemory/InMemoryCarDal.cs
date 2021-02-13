using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal 

    {
        
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {  
           new Car{ CarId=1,ColorId=123,BrandId=2,Description="270 hp",ModelYear=2020,DailyPrice=90000},
           new Car{ CarId=2,ColorId=125,BrandId=7,Description="641 hp",ModelYear=2015,DailyPrice=25000},
           new Car{ CarId=3,ColorId=165,BrandId=1,Description="755 hp",ModelYear=2019,DailyPrice=65000}
                       };

        }
        public List<Car> GetAll()
        {
            return _cars;
        }
    

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
           Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);


        }

          public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
