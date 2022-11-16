using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult DeleteCar(DeleteForCarDto dto)
        {
            var car = _carDal.Get(x => x.VehicleId == dto.CarId);

            if (car==null)
            {
                return new ErrorResult("Silinecek araç bulunamadı.");
            }

            _carDal.Delete(car);
            return new SuccessResult("Araç silindi.");
        }

        public IDataResult<Car> GetCarByColorId(int? colorId)
        {
            if (colorId == null)
            {
                return new ErrorDataResult<Car>("Renk id boş olamaz");
            }

            var result = _carDal.Get(x => x.ColorId == colorId);

            if (result == null)
            {
                return new ErrorDataResult<Car>("Araç bulunamadı");
            }

            return new SuccessDataResult<Car>(result,"Araç renk id ile getirildi.");
        }

        public IResult UpdateHeadlight(UpdateHeadlightDto dto)
        {
            var car = _carDal.Get(x => x.VehicleId == dto.CarId);

            if (car == null)
            {
                return new ErrorResult("Araç bulunamadı");
            }

            car.HeadlightIsOpen = dto.Status;

            _carDal.Update(car);

            return new SuccessResult("Far durumu güncellendi.");
        }
    }
}
