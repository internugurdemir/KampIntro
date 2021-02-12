using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    /*Generic yapılar:  
                      object türü değildir boxing-unboxing yapılmaz
     List

    Stack
    
    Queue
    
    LinkedList
    
    Dictionar
    
    SortedDictionary
    
    SortedSet

    HashSet
     */
    class Program
    {
        
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);

            MyList1<string> sehirler2 = new MyList1<string>();
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);




            Console.ReadLine();

            //MyList<string> isimler = new MyList<string>();
            //isimler.Add("Demir");

            //List<string> liste = new List<string>();
            //Console.WriteLine(liste.Count);

            //Console.WriteLine("sa");
        }
    }
    class MyList1<T>//Generic class
    {
        T[] _array;
        T[] _temparray;
        public MyList1()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _temparray=_array;
            _array = new T[_array.Length+1];
            for (int i = 0; i < _temparray.Length; i++)
            {
                _array[i]=_temparray[i];


            }
            _array[_array.Length - 1] = item;
        }
        //private int _count;

        public int Count
        {
            //get { return _count; }
            get { return _array.Length; }
        
        }

    }
}
