using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        List<Car> GetAllByBrandID(int brandID);
        List<Car> GetCarsByColorId(int colorID);

    }
}
