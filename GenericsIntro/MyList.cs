using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //Mylistemde T ile çlışıcam T = tip
    class MyList<T>
    {
        T[] items;
        //constructor
        // classı newlersem otomatik çalışır.
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            //dizinin eleman sayısıbir artırıcam
            T[] tempArray = items;
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
