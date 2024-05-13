using milliParkProje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilliPark
{
    class Stack2
    {
        private int maxSize;
        private milliPark[] stackArr;
        private int top;

        public Stack2(int sizeArr) // constructor
        {
            maxSize = sizeArr;
            stackArr = new milliPark[sizeArr];
            top = -1;
        }
        public void push(milliPark eklenecekPark) // Yığıtın sonuna eleman ekleme
        {
            stackArr[++top] = eklenecekPark;
        }

        public milliPark pop() // Yığıtın sonundaki elemanı silme
        {
            return stackArr[top--];
        }

        public milliPark peek() // Yığıtın başındaki elemana bakma
        {
            return stackArr[top];
        }

        public Boolean isEmpty() // Yığıt boşsa true döndürür
        {
            return (top == -1);
        }

        public Boolean isFull() // Yığıt tamamen doluysa true döndürür
        {
            return (top == maxSize - 1);
        }
    }

    class Queue2
    {

        private int maxSize;
        private milliPark[] queArray;
        private int front;
        private int rear;
        private int nItems;

        public Queue2(int arrSize) // constructor
        {
            maxSize = arrSize;
            queArray = new milliPark[maxSize];
            front = 0;
            rear = -1;
            nItems = 0;
        }

        public void insert(milliPark j) // Kuyruğun sonuna eleman ekleme
        {
            if (rear == maxSize - 1) // Wraparound
                rear = -1;
            queArray[++rear] = j;
            nItems++;
        }

        public milliPark remove() // Kuyruğun başından eleman silme
        {
            milliPark temp = queArray[front++];
            if (front == maxSize) // Wraparound
                front = 0;
            nItems--;
            return temp;
        }

        public milliPark peekFront() // Kuyruğun önündeki elemana bakma
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
   


}

