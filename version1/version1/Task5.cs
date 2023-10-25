using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version1
{
    public class Task5
    {

        class MyList<T>
        {
            private List<T> items = new List<T>();

            public void Add(T item)
            {
                items.Add(item);
            }

            public T Get(int index)
            {
                if (index >= 0 && index < items.Count)
                {
                    return items[index];
                }
                throw new IndexOutOfRangeException("Index is out of range");
            }
        }



        public void task5()
        {

            MyList<int> myList = new MyList<int>();

            
            myList.Add(10);
            myList.Add(20);
            myList.Add(30);

           
            int item1 = myList.Get(0);
            int item2 = myList.Get(1);
            int item3 = myList.Get(2);

            Console.WriteLine("Item 1: " + item1);
            Console.WriteLine("Item 2: " + item2);
            Console.WriteLine("Item 3: " + item3);


        }









    }
}
