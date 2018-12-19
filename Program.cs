using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>(10);
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            list.ArrayInfo("Add 10 elements");
            
            list.Insert(12, 4);
            list.ArrayInfo("Insert: Value - 12, Index - 4");
            
            list.Remove(12);
            list.ArrayInfo("Remove: Value - 12");
            
            list.Insert(12, 12);
            list.ArrayInfo("Insert: Value - 12, Index - 12");
            
            list.Insert(12, 4);
            list.ArrayInfo("Insert: Value - 12, Index - 4");
            
            list.RemoveAt(4);
            list.ArrayInfo("Remove: Index - 4");
            
            list.Clear();
            list.ArrayInfo("Clear");

            Console.ReadKey();
        }
    }
}
