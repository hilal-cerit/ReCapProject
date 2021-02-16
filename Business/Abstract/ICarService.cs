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

        IDataResult<List<CarDetailDto>> GetCarDetailDtos();
        IDataResult<List<Car>> GetAll();
       
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IDataResult<Car> GetById(int id);

        IResult Update(Car car);
        IResult Delete(Car car);
        IResult Add(Car car);
    }
}
