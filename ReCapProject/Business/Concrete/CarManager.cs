using Business.Abstract;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    //Managerlar Somut sınıftır Classtır
    public class CarManager : ICarService
    {
        ICarDal _carDal; // Veri erişim yöntemlerinin her birini tutabilecek referans

        public void Add(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Tanım(Description) 2 karakterder fazla olmalıdır\n" +
                    "Günlük fiyat bilgisi 0(sıfır)'dan büyük olmalıdır.");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByBrandId(int brandID)
        {
            return _carDal.GetAllByBrandID(brandID);
        }

        public List<Car> GetCarsByColorId(int colorID)
        {
            return _carDal.GetCarsByColorId(colorID);

        }

        public List<Car> GetCarsByDailyPrice(int dailyPrice)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Update(car);
            }
            else
            {
                Console.WriteLine("Tanım(Description) 2 karakterder fazla olmalıdır\n" +
                     "Günlük fiyat bilgisi 0(sıfır)'dan büyük olmalıdır.");
            }
        }
    }
}