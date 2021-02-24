using Business.Abstract;
using Business.Constans;
using Core.Utilities;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {//validatora ekledim bunları
            //if (DateTime.Now==rental.RentBeginDate)
            //{
                return new SuccessResult(Messages.RentalAdded);
            //}
            //else
            //{
            //    return new ErrorResult();
            //}

        }

        public IResult Delete(Rental rental)
        {
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return  new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

    

        public IResult Update(Rental rental)
        {
            return new SuccessResult(Messages.RentalUpdated);
        }



        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(c => c.RentalId == rentalId));
        }


















    }
}
