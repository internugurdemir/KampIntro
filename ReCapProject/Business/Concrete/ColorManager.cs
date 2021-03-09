using Business.Abstract;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    //Managerlar Somut sınıftır Classtır
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll().ToList();
        }

        public Color GetById(int colorId)
        {
            return _colorDal.Get(p => p.ColorId == colorId);
        }

        public List<Color> GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
        }
    }
}