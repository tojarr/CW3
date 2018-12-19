using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW3
{
    class MyList<T> : IEnumerable
    {
        readonly int _l;
        int lenght;
        T[] arr;
        public int count { get; private set; }

        public MyList()
        {
            lenght = 100;
            _l = lenght;
            arr = new T[lenght];
        }
        public MyList(int l)
        {
            lenght = l;
            _l = lenght;
            arr = new T[lenght];
        }

        public void Add(T t)
        {
            if(count >= lenght)
            {
                MultArr();
            }
            arr[count] = t;
            count++;
        }

        public void Clear()
        {
            lenght = _l;
            T[] arr1 = new T[lenght];
            arr = arr1;
            count = 0;
        }

        public void Insert(T t, uint index)
        {
            if (count >= lenght)
            {
                MultArr();
            }
            if (index < count)
            {
                T[] arr1 = new T[lenght];
                for (var i = index; i < arr.Length; i++)
                {
                    arr1[i] = arr[i];
                }
                arr[index] = t;
                count++;
                for (var i = index + 1; i < arr.Length; i++)
                {
                    arr[i] = arr1[i - 1];
                }
            }
            else
            {
                try
                {
                    arr[index + lenght] = t;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void Remove(T t)
        {
            if(count != 0)
            {
                T[] arr1 = new T[lenght];
                for (int i = 0, j = 0; i < arr.Length; i++, j++)
                {
                    if (t.Equals(arr[i]))
                    {
                        j--;
                        count--;
                    }
                    else
                    {
                        arr1[j] = arr[i];
                    }
                }
                arr = arr1;
            }
        }

        public void RemoveAt(uint index)
        {
            if(index < count)
            {
                T[] arr1 = new T[lenght];
                for (uint i = 0, j = 0; i < arr.Length; i++, j++)
                {
                    if (index.Equals(i))
                    {
                        j--;
                        count--;
                    }
                    else
                    {
                        arr1[j] = arr[i];
                    }
                }
                arr = arr1;
            }
            else
            {
                Console.WriteLine("Index out of range.");
            }
        }



        public void MultArr()
        {
            lenght *= 2; 
            T[] arr1 = new T[lenght];
            for (int i = 0; i < arr.Length; i++)
            {
                arr1[i] = arr[i];
            }
            arr = arr1;
        }

        public IEnumerator GetEnumerator()
        {
            return arr.GetEnumerator();
        }

        public void ArrayInfo(string str)
        {
            Console.WriteLine(str);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Index: {0} - Value: {1}", i, arr[i]);
            }
            Console.WriteLine();
        }
    }
}
