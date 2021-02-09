using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Car> GetAll()
        {
            return _productDal.GetAll();
        }

        public void GetById(int id)
        {
          _productDal.GetById(id);
        }
        public void Add(Car car)
        {
           _productDal.Add(car);
        }

        public void Update(Car car)
        {
            _productDal.Update(car);
        }
        public void Delete(Car car)
        {
            _productDal.Delete(car);
        }
      

    }
}
