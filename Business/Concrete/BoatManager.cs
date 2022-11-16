using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BoatManager : IBoatService
    {
        private readonly IBoatDal _boatDal;

        public BoatManager(IBoatDal boatDal)
        {
            _boatDal = boatDal;
        }

        public IDataResult<Boat> GetBoatByColorId(int? colorId)
        {
            if (colorId == null)
            {
                return new ErrorDataResult<Boat>("Renk id boş olamaz");
            }

            var result = _boatDal.Get(x => x.ColorId == colorId);

            if (result == null)
            {
                return new ErrorDataResult<Boat>("Araç bulunamadı");
            }

            return new SuccessDataResult<Boat>(result, "Araç renk id ile getirildi.");
        }

    }
}
