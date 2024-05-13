using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje3
{
    class BubbleSort
    {
        private long[] a;
        private int nElems;
                            
        public BubbleSort(int max)
        {
            a = new long[max]; 
            nElems = 0; 
        }
        public void insert(long value) //Diziye eleman ekleme
        {
            a[nElems] = value; 
            nElems++;//Dizinin boyutunu arttırma
        }
        public void display() //Diziyi yazdırma
        {
            for (int j = 0; j < nElems; j++)
            {
                Console.Write(a[j] + " ");
            }
            Console.WriteLine("");
        }
        public void bubbleSort()
        {

            int outs;
            int ins;
            for (outs = nElems - 1; outs >= 1; outs--)
            {
                for (ins = 0; ins < outs; ins++)
                {
                    if (a[ins] > a[ins + 1])
                    {  //Dizideki eleman bir sonrakinden büyükse yerlerini değiştir
                        swap(ins, ins + 1);
                    }
                }
            }
        }
        private void swap(int one, int two)//Dizideki 2 elemanın yerini değiştirme
        {
            long temp = a[one];
            a[one] = a[two];
            a[two] = temp;
        }
    }
}
