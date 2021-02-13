using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq.Expressions;
using System.Text;
using Entities.Concrete;
using System.Linq;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, CarRentalContext>, IColorDal
    {
       





    }
}
