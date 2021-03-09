using ReCapProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ReCapProject.Core.DataAccess
{
    //BU vereceğimiz T yi sınırlandırmamız yani filtrelememiz lazım.
    //class demek referans tipi olabilir demektir.
    //newlenebilir olduğu için Ientities olmaz artık.
    public interface IEntityReposityory<T> where T : class, IEntity, new()
    {// burada Tnin alabileceği değerleri kısıtladık where koşulu ile
        List<T> GetAll(Expression<Func<T, bool>> filter = null);//expression ile filtreleme şartlarına gerek kalmadı
        T Get(Expression<Func<T, bool>> filter);//filtreler yazabilmemizi sağlıyor.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
