using ReCapProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Entities.Concrete
{
    public class CarCategory:IEntity
    {
        public int CarCategoryId { get; set; }
        public string CarCategoryName { get; set; }
    }
}
