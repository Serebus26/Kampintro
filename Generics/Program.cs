using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> city = new List<string>();
            city.Add("Eskişehir");
            city.Add("Eskişehir");
            city.Add("Eskişehir");
            city.Add("Eskişehir");
            city.Add("Eskişehir");
            Console.WriteLine(city.Count);

            Mylist<string> city2 = new Mylist<string>();
            city2.Add("Eskişehir");
            city2.Add("Eskişehir");
            city2.Add("Eskişehir");
            city2.Add("Eskişehir");
            city2.Add("Eskişehir");
            city2.Add("Eskişehir");
            Console.WriteLine(city2.Count);
        }
    }

    class Mylist<T>
    {
        T[] _array;
        T[] _tempArray;
        public Mylist()
        {            
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }

        public int Count
        {
            get { return _array.Length; }
        }

    }

}
