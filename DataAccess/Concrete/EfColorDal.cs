using DataAccess.Abstract;
using DataAccess.EntityFrameWork;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfColorDal : EfEntityRepositoryBase<Color,DbContextProject>, IColorDal
    {
    }
}
