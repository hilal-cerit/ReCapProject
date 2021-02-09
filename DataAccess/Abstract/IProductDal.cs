using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal
    { //     GetById, GetAll, Add, Update, Delete
        List<Car> GetAll();
        void GetById(int id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
       
    }
}
