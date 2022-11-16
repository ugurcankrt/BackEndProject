using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BusManager : IBusService
    {
        private readonly IBusDal _busDal;

        public BusManager(IBusDal busDal)
        {
            _busDal = busDal;
        }

        public IDataResult<Bus> GetBusByColorId(int? colorId)
        {
            if (colorId == null)
            {
                return new ErrorDataResult<Bus>("Renk id boş olamaz");
            }

            var result = _busDal.Get(x => x.ColorId == colorId);

            if (result == null)
            {
                return new ErrorDataResult<Bus>("Araç bulunamadı");
            }

            return new SuccessDataResult<Bus>(result, "Araç renk id ile getirildi.");
        }
    }
}
