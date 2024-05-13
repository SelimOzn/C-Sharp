using milliParkProje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilliPark
{
    internal class PriorityQueue
    {
        private List<milliPark> queArr;
        private int nItems;
        
        public PriorityQueue() // constructor
        {
            queArr = new List<milliPark>();
            nItems = 0;
        }

        public void insert(milliPark item) //Öncelikli kuyruğun sonuna eleman ekleme.
        {
            nItems++;
            queArr.Add(item);
        }

        public milliPark remove() //Öncelikli kuyruktan yüz ölçümü en az olan parkın silinmesi. 
        {

            if (nItems == 0)// if no items,
            {
                Console.WriteLine("Kuyrukta eleman yok.");
                return null;
            }

            else
            {
                milliPark minPark = queArr[0];
                foreach (milliPark park in queArr)
                {
                    if (minPark.getYuzOlcumu() > park.getYuzOlcumu())
                    {
                        minPark = park;
                    }
                }
                queArr.Remove(minPark);
                nItems --;
                return minPark;
            }
        }
        public Boolean isEmpty() // true if queue is empty
        {
            return (nItems == 0);
        }
    }
}
