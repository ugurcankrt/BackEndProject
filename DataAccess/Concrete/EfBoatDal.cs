using DataAccess.Abstract;
using DataAccess.EntityFrameWork;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfBoatDal : EfEntityRepositoryBase<Boat, DbContextProject>, IBoatDal
    {
    }
}
