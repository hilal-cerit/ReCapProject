using Core.Utilities;
using Core.Utilities.Result;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public  interface ICarService
    {

     
        IDataResult<List<Car>> GetAll();
        
        IDataResult<List<Car>> GetById(int carId);
        IDataResult<List<Car>> GetByUnitPrice(decimal min, decimal max);

        IDataResult<List<Car>> GetCarsByBrandId(int carId);
        IDataResult<List<Car>> GetCarsByColorId(int carId);

        IDataResult<List<CarDetailDto>> GetCarDetailDtos();
        IResult Update(Car car);
        IResult Delete(Car car);
        IResult Add(Car car);
    }
}
