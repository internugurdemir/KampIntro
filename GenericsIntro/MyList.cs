using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>//Program.cs te oluşturduk
    {
        T[] items;
        public MyList() //constructor-->    //ctor yazıp tab tab yaptık
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;//bir sonraki adımda yenilediğimiz için öncesinde içinde bulunan veriler kaybolmasın diye tutmak için
            items = new T[items.Length+1];//new adresi değiştirdi +1 elemanlı yen bir item oluşturdu 6 eleman kapasite index 5 son elemanı verir
            
            
            for (int i = 0; i < tempArray.Length; i++)//Yeniden yükleme
            {                items[i] = tempArray[i];            }

            items[items.Length - 1] = item;//items.Length bize eleman sayısını verir 5 elemanlı ise indexi4 6 elemanlı ise 5 yazıp son elemanı buluruz  -1 diyoruz çünkü eleman sayısından 1 çıkartıp indexe ekliyoruz

        }
    }
}
