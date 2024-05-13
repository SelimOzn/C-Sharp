using MilliPark;
using System.Collections.Generic;

namespace milliParkProje;
public class milliPark
{
    private string milliParkAdi;
    private List<string> bulunduguYerler;
    private int kurulduguYil;
    private double yuzOlcumu;

    public milliPark(string ad, List<string> yerler, int yil, double yuzOlcumu) // constructor
    {
        this.milliParkAdi = ad;
        this.bulunduguYerler = yerler;
        this.kurulduguYil = yil;
        this.yuzOlcumu = yuzOlcumu;
    }

    public double getYuzOlcumu() // Yüz ölçümü için get metodu
    {
        return yuzOlcumu;
    }

    public void toString() // Nesnenin tüm özelliklerini yazdıran metot
    {
        Console.WriteLine(milliParkAdi + ", " + String.Join(",", bulunduguYerler) + ", " + kurulduguYil + ", " + yuzOlcumu.ToString());
    }

}

internal class Program
{
    static void Main(string[] args)
    {
        List<milliPark>[] dizi = new List<milliPark>[2];
        dizi[0] = new List<milliPark>();
        dizi[1] = new List<milliPark>();

        milliPark eklenecekPark;
        string line;
        string[] veriler;
        string[] sehirlerGecici;
        List<string> sehirler;
        double toplamYuzOlcumu;
        
        Stack2 stack = new Stack2(48);
        Queue2 queue = new Queue2(48);

        try
        {
            //Dosyanın yolunu StreamReadera iletme
            StreamReader sr = new StreamReader("C:\\Users\\Selim\\source\\repos\\MilliPark\\MilliPark\\milli_parklar.txt");
            //Read the first line of text
            line = sr.ReadLine();
            //Dosyanın sonuna kadar okuma
            while (line != null)
            {
                veriler = line.Split(";");
                sehirler = new List<string>();
                sehirlerGecici = veriler[1].Split(",");
                foreach(string s in sehirlerGecici) // Parkın bulunduğu şehirleri generic liste aktarma
                {
                    sehirler.Add(s);
                }

                eklenecekPark = new milliPark(veriler[0], sehirler, int.Parse(veriler[2]), double.Parse(veriler[3])); // Dosyadan okunan parkı oluşturma
                if (double.Parse(veriler[3]) < 15000) // Yüz ölçümü 15000 hektardan küçükse dizinin 1.elemanına ekleme
                {
                    dizi[0].Add(eklenecekPark);
                }
                else // Yüz ölçümü 15000 hektardan küçükse dizinin 2.elemanına ekleme
                {
                    dizi[1].Add(eklenecekPark);
                }

                stack.push(eklenecekPark); // Parkı yığıta ekleme
                queue.insert(eklenecekPark); // Parkı kuyruğa ekleme

                // Sonraki satırı okuma
                line = sr.ReadLine();
            }

            // Dosyayı kapatma
            sr.Close();
            Console.ReadLine();
            toplamYuzOlcumu = 0;

            //1.c madde
            foreach (milliPark park in dizi[0])
            {
                park.toString();
                toplamYuzOlcumu += park.getYuzOlcumu();
            }
            Console.WriteLine("1.listedeki parkların toplam yüz ölçümü: " + toplamYuzOlcumu);
            Console.WriteLine();

            toplamYuzOlcumu = 0;
            foreach (milliPark park in dizi[1])
            {
                park.toString();
                toplamYuzOlcumu += park.getYuzOlcumu();

            }
            Console.WriteLine("2.listedeki parkların toplam yüz ölçümü: " + toplamYuzOlcumu);
            Console.WriteLine();

        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }

 
        // 2.a madde
            while (!(stack.isEmpty()))
            {
                stack.pop().toString();
            }

        Console.WriteLine();
        // 2.b madde
            while (!(queue.isEmpty()))
            {
                queue.remove().toString();
            }

        Console.WriteLine();

        PriorityQueue priQue = new PriorityQueue();


        //3. madde
        foreach(milliPark park in dizi[0])
        {
            priQue.insert(park);
        }

        foreach(milliPark park in dizi[1])
        {
            priQue.insert(park);
        }

        while (!(priQue.isEmpty()))
        {
            priQue.remove().toString();
        }

        //4.madde
        Console.WriteLine();

        int[] urunSayilari = {8, 9, 6, 7, 10, 1, 11, 5, 3, 4, 2};
        IntQueue urunQue = new IntQueue(11);
        IntPriorityQueue urunPriQue = new IntPriorityQueue();

        foreach (int urunSayisi in urunSayilari) //Ürün sayılarını kuyruk ve öncelikli kuyruğa ekleme
        {
            urunQue.insert(urunSayisi);
            urunPriQue.insert(urunSayisi);
        }

        List<int> queMusteriSureleri = new List<int>();
        List<int> priMusteriSureleri = new List<int>();
        int queGecenToplamSure = 0;
        int priGecenToplamSure = 0;

        while (!urunQue.isEmpty()) // Kuyrukta her bir müşteri için geçen süre
        {
            queGecenToplamSure += urunQue.remove() * 3;
            queMusteriSureleri.Add(queGecenToplamSure);
        }

        Console.WriteLine();

        while (!urunPriQue.isEmpty()) // Öncelikli kuyrukta her bir müşteri için geçen süre
        {
            priGecenToplamSure += urunPriQue.remove() * 3;
            priMusteriSureleri.Add(priGecenToplamSure);
        }
        int ortIslemSuresi = 0;
        for (int i=0; i<queMusteriSureleri.Count; i++)
        {
            Console.WriteLine("Kuyrukta " + (i+1) + ". sıradaki müşterinin işlem tamamlanma süresi: " + queMusteriSureleri[i]);
            ortIslemSuresi += queMusteriSureleri[i];
        }
        Console.WriteLine("Kuyrukta müşterilerin ortalama işlem tamamlama süresi: " + (ortIslemSuresi/11));
        Console.WriteLine();
        ortIslemSuresi = 0;
        for (int i=0; i<priMusteriSureleri.Count; i++)
        {
            Console.WriteLine("Öncelikli kuyrukta " + (i+1) + ". sıradaki müşterinin işlem tamamlanma süresi: " + priMusteriSureleri[i]);
            ortIslemSuresi += priMusteriSureleri[i];
        }
        Console.WriteLine("Öncelikli kuyrukta müşterilerin ortalama işlem tamamlama süresi: " + (ortIslemSuresi / 11));
    }

}