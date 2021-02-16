using Business.Abstract;
using Business.Constans;
using Core.Utilities;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IDataResult<List<Car>> GetAll()
        {   //iş kodları
            //yetkisi var mı?
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.List);
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.CarId == id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailDtos()
        {
            if (DateTime.Now.Hour == 13)
            {
                return new ErrorDataResult<List<CarDetailDto>>(_carDal.GetCarDetailDtos(),Messages.MaintenanceTime);
            }


            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailDtos());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p=>p.BrandId==id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == id));
        }


        public IResult Add(Car car)
        {
            if (car.CarName.Length >= 2 && car.DailyPrice > 0)
            {
                
                _carDal.Add(car);
                return new SuccessResult(Messages.CarAdd);
                
            }
         
            return new ErrorResult(Messages.CarAddingError);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdate);
   }
         public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDelete);

        }





    }
}
