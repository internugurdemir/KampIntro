
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        //Entityframeworkile gerçek veriye bağlıyoruz
        //burada veri varmış gibi davranacağız
        List<Car> _cars;
        public InMemoryCarDal()//constructor block bellekte ref aldığında çalışır
        {
            _cars = new List<Car>
            {
                new Car{Id=100, BrandId=1, ColorId=1, DailyPrice=174, ModelYear=2015, Description="Fiyat Performans arabasıdır, Sakin ve huzurlu yolculuk"},
                new Car{Id=101, BrandId=2, ColorId=1, DailyPrice=180, ModelYear=2007, Description="Fiyat Performans arabasıdır, Sakin ve huzurlu yolculuk"},
                new Car{Id=102, BrandId=2, ColorId=2, DailyPrice=284, ModelYear=1985, Description="Nostalji sevenlere."},
                new Car{Id=103, BrandId=3, ColorId=1, DailyPrice=454, ModelYear=2021, Description="Son model. En hızlısı ve en güçlüsü"},
                new Car{Id=104, BrandId=3, ColorId=2, DailyPrice=300, ModelYear=2014, Description="Sessiz çalışır"},

            };
        }

 
        List<Car> ICarDal.GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car cartToDelete;

            cartToDelete = _cars.SingleOrDefault(c => c.Id==car.Id);



            _cars.Remove(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public List<Car> GetAllByBrandID(int brandID)
        {
            return _cars.Where(c=> c.BrandId== brandID).ToList();
        }
    }
}
