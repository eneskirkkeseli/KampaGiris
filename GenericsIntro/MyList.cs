using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        T[] items; //T parametresi listedeki ürünlerin, elemanların, nesnelerin türünü belirtir.
        public MyList()  //ctor kalıbıyla tab+tab direkt public metodu kurulur. Burası constructor bölümüdür ve otomatik çalışır. Constructor = yapıcı/kurucu methoddur.
        {
            items = new T[0]; 
        }
        public void Add(T item) //item = eleman olarak kullanılıyor.
        {
            T[] tempArray = items; //ilk olarak geçici olarak bu elemana referans numaramızı verdik. Nedeni biz bu metodu newlediğimiz zaman eleman kaybına uğramamak için.
            items = new T[items.Length+1]; //artık elemanımızı tutan tempArray olduğu için items.Lenght+1 yaparak eleman eklemeye alt satırlarda başlayabilirim.
            for (int i = 0; i < tempArray.Length; i++) //for döngüsüyle ise o tampArray elemanları tekrardan geri alınıyor.
            {
                items[i] = tempArray[i];
            }
            items[items.Length-1] = item;
        }
    }   
}
