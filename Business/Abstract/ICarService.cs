using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public  interface ICarService
    {

        List<CarDetailDto> GetCarDetailDtos();

        void Update(Car car);
        void Delete(Car car);
        void Add(Car car);
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        List<Car> GetById(int id);


    }
}
