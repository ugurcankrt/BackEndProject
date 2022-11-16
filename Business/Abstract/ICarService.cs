using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<Car> GetCarByColorId(int? colorId);
        IResult UpdateHeadlight(UpdateHeadlightDto dto);
        IResult DeleteCar(DeleteForCarDto dto);
    }
}
