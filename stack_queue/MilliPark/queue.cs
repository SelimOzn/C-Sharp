using milliParkProje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilliPark
{
    internal class IntQueue
    {
        private int maxSize;
        private int[] queArray;
        private int front;
        private int rear;
        private int nItems;

        public IntQueue(int arrSize) // constructor
        {
            maxSize = arrSize;
            queArray = new int[maxSize];
            front = 0;
            rear = -1;
            nItems = 0;
        }

        public void insert(int j) // Kuyruğun sonuna eleman ekleme
        {
            if (rear == maxSize - 1) // Wraparound
                rear = -1;
            queArray[++rear] = j; 
            nItems++; 
        }

        public int remove() // Kuyruğun başından eleman silme
        {
            int temp = queArray[front++];
            if (front == maxSize) // Wraparound
                front = 0;
            nItems--;
            return temp;
        }

        public int peekFront() // Kuyruğun en önündekini elemana bakma
        {
            return queArray[front];
        }
        public Boolean isEmpty() // Kuyruk boşsa true döndürür
        {
            return (nItems == 0);
        }
        public Boolean isFull() // Kuyruk tamamen doluysa true döndürür
        {
            return (nItems == maxSize);
        }
        public int size() // Kuyruktaki eleman sayısı
        {
            return nItems;
        }
    }

    internal class IntPriorityQueue
    {
        private List<int> queArr;
        private int nItems;

        public IntPriorityQueue() // constructor
        {
            queArr = new List<int>();
            nItems = 0;
        }

        public void insert(int item) //Kuyruğun sonuna eleman ekleme
        {
            nItems++;
            queArr.Add(item);
        }

        public int remove()
        {

            if (nItems == 0)// Kuyruk tamamen boşsa
            {
                Console.WriteLine("Kuyrukta eleman yok.");
                return -1;
            }

            else // Kuyruktaki en düşük değere sahip integerı silme
            {
                int minInt = queArr[0];
                foreach (int j in queArr)
                {
                    if (minInt > j)
                    {
                        minInt = j;
                    }
                }
                queArr.Remove(minInt);
                nItems--;
                return minInt;
            }
        }
        public Boolean isEmpty() // Kuyruk boşsa true döndürür
        {
            return (nItems == 0);
        }
    }
}
