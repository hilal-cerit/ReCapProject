
using Business.Abstract;
using Business.ValidatorRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities;
using Core.Utilities.Business;
using Core.Utilities.FileHelper;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(IFormFile file, CarImage carImage)
        { 
            IResult result = BusinessRules.Run(CheckCarImageLimit(carImage.CarId));


            if (result != null)
            {
                return result;
            }

            carImage.ImagePath = FileHelper.Add(file);
            carImage.ImageDate = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult();
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Delete(CarImage carImage)
        {
            FileHelper.Delete(carImage.ImagePath);
            _carImageDal.Delete(carImage);
            return new SuccessResult();
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Update(IFormFile file, CarImage carImage)
        {
            carImage.ImagePath = FileHelper.Update(_carImageDal.Get(c => c.CarImageId == carImage.CarImageId).ImagePath, file);
            carImage.ImageDate = DateTime.Now;
            _carImageDal.Update(carImage);
            return new SuccessResult();
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.CarImageId== id));
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IDataResult<List<CarImage>> GetByCarId(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId);
            ShowDefaultImage(result, carId);
            return new SuccessDataResult<List<CarImage>>(result);
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        private IResult CheckCarImageLimit(int carId)
        {
            var CarImages = _carImageDal.GetAll(c => c.CarId == carId).Count;
            if (CarImages >= 5)
            {
                return new ErrorResult();
            }

            return new SuccessResult();
        }
        private IResult ShowDefaultImage(List<CarImage> result, int carId)
        {
            if (!result.Any())
            {
                var DefaultCarImage = new CarImage
                {
                    CarId = carId,
                    ImagePath = Environment.CurrentDirectory + @"\Images\DefaultCar.jpg",
                    ImageDate = DateTime.Now
                };
                result.Add(DefaultCarImage);
            }
            return new SuccessResult();
        }
    }
}