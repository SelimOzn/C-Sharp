using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Proje3
{
    internal class HeapNode
    {

        private int iData;
        public HeapNode(int key)
        {
            this.iData = key;
        }
        public int getKey()
        { return iData; }
        public void setKey(int id)
        { iData = id; }
    }


    internal class Heap
    {
        private HeapNode[] heapArr;
        private int maxSize;
        private int currentSize;

        public Heap(int size)
        {
            currentSize = 0;
            maxSize = size;
            heapArr = new HeapNode[maxSize];
        }

        public Boolean isEmpty()
        {
            return currentSize == 0;
        }

        public Boolean insert(int newData)
        {
            if (currentSize == maxSize)//Heap doluysa ekleme yapılmıyor.
            {
                return false;
            }
            HeapNode newNode = new HeapNode(newData);
            heapArr[currentSize] = newNode;//Eklenecek düğümü en sona ekliyoruz.
            trickleUp(currentSize++);
            return true;
        }

        public void trickleUp(int index)
        {
            int parent = (currentSize - 1) / 2;//Eklediğimiz düğümü yukarı kaydırabilmek için parentı ile karşılaştırma yapmamız gerekiyor. Bu yüzden parentını alıyoruz.
            HeapNode bottom = heapArr[index];

            while (index != 0 && heapArr[parent].getKey() < bottom.getKey())//Eklenen düğüm, parentdan küçük olana kadar yukarı kaydırıyoruz.
            {
                heapArr[index] = heapArr[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArr[index] = bottom;
        }

        public HeapNode remove()//İlk düğümü siler ve yeni heapi, max heapi uygun olacak şekilde düzenler.
        {
            HeapNode root = heapArr[0];
            heapArr[0] = heapArr[--currentSize];
            trickleDown(0);
            return root;
        }

        public void trickleDown(int index)
        {
            int largerChild;
            HeapNode top = heapArr[index];
            while (index < currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rigtChild = leftChild + 1;
                //Root silindikten sonra en büyük olan düğümü yeni root yapmamız lazım.

                if (rigtChild < currentSize && heapArr[rigtChild].getKey() > heapArr[leftChild].getKey())
                //Sağ çocuk varsa ve sol çocuktan büyükse büyük çocuk olarak onu alıyoruz.
                {
                    largerChild = rigtChild;
                }
                else
                //Sol çocuk daha büyükse onu alıyoruz. 
                {
                    largerChild = leftChild;
                }
                if (top.getKey() >= heapArr[largerChild].getKey())
                {
                    break;
                }

                heapArr[index] = heapArr[largerChild];
                index = largerChild;
            }
            heapArr[index] = top;
        }

        public Boolean change(int index, int newValue)//Bir düğümün değerini değiştiren metot.
        {
            if (index < 0 || index >= currentSize)
                return false;
            int oldValue = heapArr[index].getKey();
            heapArr[index].setKey(newValue); //Yeni değer atıyoruz.
            if (oldValue < newValue) //Yeni değer eski değerden yüksekse max heape göre düğümü yukarı kaydırıyoruz.
                trickleUp(index);
            else //Yeni değer eski değerden düşükse aşağı kaydırıyoruz.
                trickleDown(index);
            return true;
        }

        public void displayHeap()
        {
            //Array şeklinde yazdırma
            Console.WriteLine("Heap Array: ");
            for(int i=0; i < currentSize; i++)
            {
                if (heapArr[i] != null)
                {
                    Console.Write(" " + heapArr[i].getKey() + " ");
                }
                else
                {
                    Console.Write("--");
                }
            }
            Console.WriteLine();

            //Heap şeklinde yazdırma
            int nBlanks = 32;
            int itemsPerRow = 1;
            int column = 0;
            int j = 0;
            string dots = "...............................";
            Console.WriteLine(dots + dots);

            while (currentSize > 0) //Heapteki her item için
            {
                if (column == 0) 
                    for (int k = 0; k < nBlanks; k++) //Boşluk bırakma
                        Console.Write(" ");
                //İtemi yazdırma
                Console.Write(heapArr[j].getKey());
                if (++j == currentSize)
                        break;
                if (++column == itemsPerRow) //Satır bittiyse
                {
                    nBlanks /= 2; // half the blanks
                    itemsPerRow *= 2; // twice the items
                    column = 0; // start over on
                    Console.WriteLine(); // new row
                }
                else //Satırdaki sıradaki item
                    for (int k = 0; k < nBlanks * 2 - 2; k++)
                        Console.Write(" "); //İtemler arası boşluk
            } 
            Console.WriteLine("\n" +dots + dots);
        }
    }
}