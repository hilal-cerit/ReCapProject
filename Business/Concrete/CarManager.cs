using Business.Abstract;
using Business.Constans;
using Business.ValidatorRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public IDataResult<List<Car>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max));
        }
        public IDataResult<List<Car>> GetAll()
        {   
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.List);
        }

        public IDataResult<List<Car>> GetById(int carId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.CarId == carId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailDtos()
        {
            //if (DateTime.Now.Hour == 13)
            //{
           //     return new ErrorDataResult<List<CarDetailDto>>(_carDal.GetCarDetailDtos(),Messages.MaintenanceTime);
          //  }


            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailDtos());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int carId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p=>p.BrandId == carId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int carId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == carId));
        }

        [ValidationAspect(typeof(CarValidator))]

        public IResult Add(Car car)
        {
            //ValidationTool.Validate(new CarValidator(), car);


            //if (CheckIfCarCountOfIdCorrect(car.CarId).Success&&CheckIfCarNameExists(car.CarName).Success) { 

            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdd);


            //}
            //return new ErrorResult();





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
         private IResult CheckIfCarCountOfIdCorrect(int id)
        {
            //var result = _carDal.GetAll(p => p.CarId == id).Count;
            //if (result>10)
            //{
            //    return new ErrorResult();
            //}
            return new SuccessResult();
        }
        private IResult CheckIfCarNameExists(string carName)
        {
            var result = _carDal.GetAll(p => p.CarName == carName).Any();

            if (result)
            {
                return new ErrorResult();
            }
            return new SuccessResult();

        }
      
        }



    }

