using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje3
{
    internal class MaxHeapNode
    {

        private milliPark iData;
        public MaxHeapNode(milliPark park)
        {
            this.iData = park;
        }
        public milliPark getKey()
        { return iData; }
        public void setKey(double yuzOlcumu)
        { iData.setYuzOlcumu(yuzOlcumu); }
    }
    internal class MaxHeap
    {
        private MaxHeapNode[] heapArr;
        private int maxSize;
        private int currentSize;

        public MaxHeap(int size)
        {
            currentSize = 0;
            maxSize = size;
            heapArr = new MaxHeapNode[maxSize];
        }

        public Boolean isEmpty()
        {
            return currentSize == 0;
        }
        public Boolean insert(milliPark newData)
        {
            if (currentSize == maxSize) //Heap doluysa ekleme yapılmıyor.
            {
                return false;
            }
            MaxHeapNode newNode = new MaxHeapNode(newData);
            heapArr[currentSize] = newNode;//Eklenecek düğümü en sona ekliyoruz.
            trickleUp(currentSize++);
            return true;
        }
        public void trickleUp(int index)
        {
            int parent = (index - 1) / 2; //Eklediğimiz düğümü yukarı kaydırabilmek için parentı ile karşılaştırma yapmamız gerekiyor. Bu yüzden parentını alıyoruz.
            MaxHeapNode bottom = heapArr[index];

            while (index > 0 && heapArr[parent].getKey().getYuzOlcumu() < bottom.getKey().getYuzOlcumu())//Eklenen düğümdeki parkın yüzölçümü, parentınkinden küçük olana kadar yukarı kaydırıyoruz.
            {
                heapArr[index] = heapArr[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArr[index] = bottom;
        }
        public MaxHeapNode remove()//İlk düğümü siler ve yeni heapi, max heapi uygun olacak şekilde düzenler.
        {
            MaxHeapNode root = heapArr[0];
            heapArr[0] = heapArr[--currentSize];
            trickleDown(0);
            return root;
        }
        public void trickleDown(int index)
        {
            int largerChild;
            MaxHeapNode top = heapArr[index];
            while (index < currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rigtChild = leftChild + 1;
                //Root silindikten sonra en büyük olan düğümü yeni root yapmamız lazım.
                if (rigtChild < currentSize && heapArr[rigtChild].getKey().getYuzOlcumu() > heapArr[leftChild].getKey().getYuzOlcumu())
                //Sağ çocuk varsa ve sol çocuktan büyükse büyük çocuk olarak onu alıyoruz.
                {
                    largerChild = rigtChild;
                }
                else
                //Sol çocuk daha büyükse onu alıyoruz. 
                {
                    largerChild = leftChild;
                }
                if (top.getKey().getYuzOlcumu() >= heapArr[largerChild].getKey().getYuzOlcumu())
                {
                    break;
                }

                heapArr[index] = heapArr[largerChild];
                index = largerChild;
            }
            heapArr[index] = top;
        }
        public Boolean change(int index, double newValue)//Bir düğümdeki parkın yüz ölçümünü değiştiren metot.
        {
            if (index < 0 || index >= currentSize)
                return false;
            double oldValue = heapArr[index].getKey().getYuzOlcumu();
            heapArr[index].setKey(newValue); //Yeni değer atıyoruz.
            if (oldValue < newValue) //Yeni değer eski değerden yüksekse max heape göre düğümü yukarı kaydırıyoruz.
                trickleUp(index); 
            else //Yeni değer eski değerden düşükse aşağı kaydırıyoruz.
                trickleDown(index);
            return true;
        }
        public void displayHeap()
        {

            //Array şeklinde yazdırma.
            Console.WriteLine("Heap Array: ");
            for (int i = 0; i < currentSize; i++)
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
            //Heap şeklinde yazdırma.
            int nBlanks = 32;
            int itemsPerRow = 1;
            int column = 0;
            int j = 0;
            string dots = "...............................";
            Console.WriteLine(dots + dots);

            while (currentSize > 0)//Heapteki her item için
            {
                if (column == 0) //Boşluk bırakma
                    for (int k = 0; k < nBlanks; k++)
                        Console.Write(" ");
                //İtemi yazdırma
                Console.Write(heapArr[j].getKey());
                if (++j == currentSize)
                    break;
                if (++column == itemsPerRow) //Satır bittiyse
                {
                    nBlanks /= 2;
                    itemsPerRow *= 2; 
                    column = 0;
                    Console.WriteLine();
                }
                else //Satırdaki sıradaki item
                    for (int k = 0; k < nBlanks * 2 - 2; k++)
                        Console.Write(" "); //İtemler arası boşluk
            }
            Console.WriteLine("\n" + dots + dots);
        }

    }
}
