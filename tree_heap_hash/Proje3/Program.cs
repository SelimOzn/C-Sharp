using System.Collections;
using System.Globalization;

namespace Proje3;
public class milliPark
{
    private string milliParkAdi;
    private string bulunduguYerler;
    private DateTime kurulduguYil;
    private double yuzOlcumu;
    private List<string> paragraf;

    public milliPark()
    {
        milliParkAdi = " ";
        bulunduguYerler = " ";
        yuzOlcumu = 0;
        paragraf = new List<string>();
        kurulduguYil = new DateTime();

    }
    public milliPark(string ad, string yerler, double yuzOlcumu, DateTime zaman, List<string> paragraf) // constructor
    {
        this.milliParkAdi = ad;
        this.bulunduguYerler = yerler;
        this.kurulduguYil = zaman;
        this.yuzOlcumu = yuzOlcumu;
        this.paragraf = paragraf;
    }

    public void paragrafEkle(List<String> parag)
    {
        this.paragraf = parag;
    }

    public string getAd() // Yüz ölçümü için get metodu
    {
        return milliParkAdi;
    }
    public string getSehir() // Yüz ölçümü için get metodu
    {
        return bulunduguYerler;
    }
    public double getYuzOlcumu()
    {
        return yuzOlcumu;
    }
    public void setYuzOlcumu(double yuzOlcumu)
    {
        this.yuzOlcumu = yuzOlcumu;
    }
    public List<string> getParag()
    {
        return paragraf;
    }
    public void setKurulduguYil(DateTime yeniTarih)
    {
        this.kurulduguYil = yeniTarih;
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
        string[] paragArr = { "Yozgat Çamlığı Millî Parkı, İç Anadolu Bölgesi'nde insan etkisi ile meydana gelen step içerisinde yer alan sayılı kalıntı ormanlardan biridir. Türkiye'nin ilk millî parkı olma özelliğine sahip olan parkın ortalama yüksekliği 1350 metredir. Sahadaki arazinin morfolojik özelliklerini tepeler, sırtlar ve vadilerde parçalanmış dalgalı düzlükler meydana getirmektedir.", "Karatepe-Aslantaş Millî Parkı, 1958 yılında Akdeniz Bölgesi’nde, Osmaniye İlinin Kadirli İlçesine 22 km uzaklıkta ve Ceyhan Nehrinin kenarında kurulmuştur.", "Soğuksu Millî Parkı, Ankara'nın Kızılcahamam ilçesinde yer alan ve 19 Şubat 1959'da kurulan bir millî parktır. Ankara şehir merkezine 80 kilometre uzaklıktadır. Parkın volkanik bölge olmasından dolayı, çevresindeki sıcak ve soğuk su kaynakları kaplıca olarak değerlendirilmektedir. Parkın yüksekliği 1.030-1.800 m (3.380-5.910 ft) arasında değişmektedir. Arhut Tepesi 1.789 m (5.869 ft) ve Tolubelen Tepesi 1.776 m (5.827 ft) ile parkın en yüksek zirveleridir.", "Kuşcenneti Millî Parkı; Marmara Bölgesi’nde, Balıkesir ili içerisindeki Manyas Kuşgölü’nün kuzeydoğusunda yer alır. Manyas, Gönen, Bandırma arasındadır.", "Uludağ Millî Parkı 1961 yılında Millî Park olarak ilan edildi. 1961 yılında koruma altına alınan alanı 12.762 hektar'dır. Daha sonra millî park alanı 27.300 hektara çıkarılmıştır. Millî parkta ulaşım karayolu, teleferik ve telesiyej ile yapılabilmektedir. Dağın Kuzey ve Güney yamaçlarında çok sayıda patika ile vadiler ve tepeler arasında ulaşım mümkündür.", "Millî parkta hakim bitki örtüsü kayın ağaçlarıdır. Ayrıca meşe, gürgen, kızılağaç, karaçam, sarıçam, köknar, karaağaç, ıhlamur ve porsuk gibi değişik tür ağaçlar da görülmektedir. Etkili koruma ile parkın içerisinde ve yakın çevresindeki sahalarda sayıları artan geyik, karaca, ayı, yabani domuz, kurt, tilki ve sincap türleri bulunmaktadır.", "Dilek Yarımadası - Büyük Menderes Deltası Millî Parkı, Aydın il sınırları içinde Dilek Dağı'nın Ege Denizi'ne uzandığı son noktada yer alan millî park. 27.675 hektarlık bir alana sahiptir. Bu alanın 10.985 hektarı 19.05.1966 yılında Millî Park ilan edilen Dilek Yarımadasına, 16.690 hektarı 1994 yılında Millî Park ilan edilen Büyük Menderes Deltasına aittir.", "Spil Dağı Millî Parkı, Türkiye'nin Manisa ve İzmir il sınırları içerisinde yer alan bir millî parktır. Spil Dağı'nı ve çevresini kapsayan park, 22 Nisan 1968'de ilan edildi.[1] Manisa İl Çevre ve Orman Müdürlüğü'ne bağlıdır. Ayrıca, zirveye yakın \"Atalanı\" mevkisi de bu park içinde yer almaktadır. Osmanlı Devleti'nden beri var olan atların mevsimlik olarak veya ihtiyarlamaları nedeniyle burada yılkıya bırakılmasıyla atların doğal yaşam sahası hâline gelmiştir.", "Kızıldağ Millî Parkı, öncelikle bir dağdır. Karaçamıyla, sedir ağaçlarıyla, meşe ve ardıç ağaçlarıyla örtülüdür. Mavi yapraklı sedir ormanının bulunduğu tek bölgedir.", "Alan tarihi, arkeolojik, botanik, jeolojik ve jeomorfolojik değerleri barındırır. Güllük Dağı (Solymos Dağı) yamaçlarında Anadolu'nun yerli halkı Solimlerin kurmuş olduğu Termessos antik kenti kalıntıları yer alır. Antik kent civarında derin vadiler ve tepeler yer alır[1]. Termessos kenti iyi korunmuş bir antik yerleşmedir. Güllük dağının güneybatısında 1150 m rakımlı alana kurulmuştur. Antik kentte en eski kalıntılar Helenistik devirden kalma mezarlardır. Diğer eserler Roma devrine aittir. Kuleler, surlar, agora, kral yolu, tiyatro, sarnıçlar, süslemeli mezarlar en önemli eserlerdendir[2]."
                ,"Kovada Gölü Millî Parkı, Isparta'nın Eğirdir ilçesi sınırları içerisinde yer alır. Millî park sâhası içerisinde konaklama ve piknik yapma amaçlı hazırlanmış yerler mevcuttur. Burada otelde değil çadırlarda ve karavanlarda kalınalabilir.", "Munzur Vadisi Millî Parkı, Tunceli ve Ovacık arasında uzanan Munzur Vadisi'nde, 42.000 hektarlık bir alandır. 1971 yılında millî park olarak ilan edilmiştir. Bu bölgenin millî park olarak ilan edilmesinde, başta akarsu kaynakları ve gözeler olmak üzere, zengin doğal veriler, endemik bitki türleri ve yöreye özgü hayvan türleri ile zenginleşen bitki örtüsü ve yaban hayvan varlığıdır.", "Olimpos Beydağları Millî Parkı, 1972 tarihinde Antalya ili Kemer ilçesi sınırarı içinde bulunan doğal ve tarihi güzelliklerin korunması için sit alanı olarak korunmaya alınan bölge.", "Köprülü Kanyon Millî Parkı, Antalya'nın Manavgat ilçesinde millî park. Park, Bolasan ile Beşkonak arasında, ortasından Köprü Çayı akan 14 km uzunluğunda, 100 m derinliğinde Köprülü Kanyon çevresinde yer alır. 14 km uzunluğu ile en uzun kanyonumuzdur. Park arazisinde sedir ormanları ve Kapadokya'daki peri bacalarına benzeyen taş oluşumları vardır. Köprü Çayı üzerindeki eski taş köprü günümüzde de kullanılmaktadır.[1]", "Ilgaz Dağı Millî Parkı, Batı Karadeniz bölümünde Kastamonu ve Çankırı illerinde, Ilgaz Dağları üzerinde 1976 yılında kurulmuş millî park.", "Başkomutan Tarihî Millî Parkı, Türkiye'nin İç Anadolu Bölgesi'nde tarihî ve kültürel değerlerin korunması amacıyla , 8 Kasım 1981'de ilân edilen millî park. Millî Mücadele'nin dönüm noktası olan çarpışmaların yaşandığı; günümüzde Afyonkarahisar, Kütahya ve Uşak illeri sınırları içinde kalan toplam 42.183 hektarlık alandan oluşmaktadır. Alan içerisinde çeşitli şehitlikler, anıtlar ve bir de müze bulunmaktadır.", "Altındere Millî Parkı, Trabzon'un güneyinde Maçka yakınlarındadır. Bu millî parkın içinde, neredeyse bulutların bile üzerinde yer alan muhteşem Sümela Manastırı bulunur. 270 m yükseklikteki bir uçurum fasadında bulunan manastır en görkemli konuma Trabzon İmparatoru Alexius III. Komnenos döneminde getirilmiştir. III. Alexius'un taç giyme töreni (1349) burada yapılmıştır. Manastırın içinde kütüphane, kilise, rahip odaları, şapel, ayazma ve mutfak bölümleri bulunmaktadır.", "Anadolu'da kurulan en eski uygarlıklardan biri olan Hititlerden kalma arkeolojik değerler barındırır. Hitit devletinin başkenti Hattuşaş'a ait; kent surları, yer kapı, aslanlı kapı ile yazılıkaya günümüze ulaşan önemli eserlerdendir.", "Nemrut Dağı Millî Parkı, Adıyaman ili; Kâhta ilçesinde bulunan ve içinde Kommagene Krallığı'nın bir antik kentini barındıran millî park ve ören yeri. Adıyaman il merkezinde Kâhta'ya bağlantı sağlayan karayolu ile ulaşım sağlanmakta olup, Millî Park Adıyaman il sınırları içerisindedir. Adıyaman hava alanından ulaşım oldukça rahat ve kolaydır. Adıyaman ve Kahta ilçesinden Nemrut dağına ve diğer tarihi yerlere servisler vardır.", "Beyşehir Gölü Millî Parkı, Beyşehir Gölü’nün yakınında Türkiye'nin en büyük millî parkıdır. Derlenen bilgilere göre, 1993 yılında Bakanlar Kurulu kararıyla kurulan millî park 88 bin 750 hektarlık alanı kapsıyor. Doğa Koruma ve Millî Parklar Genel Müdürlüğü bünyesinde koruma altında bulundurulan Türkiye'de toplam 897 bin 657 hektarlık alana sahip 40 adet millî park bulunuyor. Bu millî park alanlarının en genişi ise Beyşehir Gölü Millî Parkı olarak dikkat çekiyor. Türkiye'nin en büyük tatlı su kaynağı olan Beyşehir Gölü'nde Beyşehir ve Kızıldağ olmak üzere iki ayrı millî park bulunuyor."
                ,"Millî park sınırları içinde yer alan Pınarbaşı ve Hasanboğuldu piknik alanları başlıca gezi noktalarıdır. Ayrıca; Mehmetalan Köyü, millî park sınırları içinde kalır. Millî parkın kültürel özelliği ise Sarıkız efsanesi ve bu kişiye ait mezarın, millî park sınırları içinde bir tepede yer almasıdır.", "Altınbeşik Mağarası Millî Parkı, Antalya ilinde bulunan milli park. İbradi (Aydınkent) ilçesine 9.7 km uzaklıkta olan Ürünlü köyünün yaklaşık 5 km güneydoğusundadır. Derin ve sarp Manavgat vadisinin batı yamacında yer almaktadır.", "Hatila Vadisinin gerek ilginç jeolojik ve jeomorfolojik yapısı ve gerekse özgün bitki toplulukları yöreye Türkiye’de ender rastlanan bir alan özelliğini vermektedir. Ayrıca bu doğal öğelerin birleşimi sonucu eşsiz peyzaj güzellikleri ortaya çıkmakta ve bu durum da zengin rekreasyonel potansiyel oluşturmaktadır.", "Karagöl-Sahara Millî Parkı, Türkiye'deki millî park alanlarından birisidir. Artvin'in Şavşat ilçesi sınırları içerisinde yer alan park, Karagöl ve Sahara Yaylası olmak üzere iki ayrı sahadan oluşur.", "Kaçkar Dağları Millî Parkı büyük bölümü Rizenin Çamlıhemşin ilçesinde, bir bölümü Erzurum ve Artvin illerine uzanan millî park. 51.550 hektarlık mili park Fırtına Deresi ile Hemşin Deresi arasında yer alan Kaçkar Dağları üzerinde kurulmuştur.", "Aladağlar, Kayseri-Niğde-Adana illeri arasında bulunan dağ sırası, bitki örtüsü ve hayvan çeşitliliği bakımından zengindir. Bu nedenle dağın 54.524 hektarlık bir bölümü önce Hacer Ormanı Tabiat Parkı, 1995 yılında da Milli park ilan edilmiştir.", "Marmaris Millî Parkı, Marmaris ve Köyceğiz ilçelerinde 29.206 hektar alanda, 1996 yılında kurulmuştur.", "Saklıkent Millî Parkı veya yaygın adıyla Saklıkent Kanyonu, Antalya-Muğla sınırını çizen Eşen Çayı'nın kolu olan Karaçay'ın oluşturduğu kanyondur. Muğla'nın Seydikemer ilçesi sınırları içerisindedir. Suyun kolayca aşındırabileceği Kalkerli arazide, fay çatlaklarının da yardımıyla sarp ve derin bir kanyon oluşmuştur.Uzunluğu 18 km, yüksekliği 200 m'dir. En dar yeri 2 metreye kadar düşer. Eşen Çayı'nın bir kolu olan Karaçay'ın debisi Kanyon çıkışında 14–17 m³/sn'dir.[1]", "Antik Troas bölgesindeki Troya ören yeri ve çevresindeki tarihî- kültürel dokuyu korumak amacıyla 1996 yılında milli park olarak ilan edilmiş bir alandır.[2] Ezine ilçe sınırları içerisinde, Çanakkale Boğazı'nın girişinde yer alır. Troya Tarihî Milli Parkı içinde 1. derece Arkeolojik SİT alanı olarak ilan edilmiş 2 adet antik kent 4 tümülüs, 3 anıt eser, 3 tescilli mezar bulunur.", "Honaz Dağı, Türkiye'nin Denizli ilinin güneydoğusu boyunca, Ege ve Akdeniz bölgelerini ayıran doğal sınır olarak uzanan bir dağdır.", "Küre Dağları Millî Parkı, Karadeniz Bölgesi'nin batısında Küre Dağları üzerinde yer alan millî parktır. Park Kastamonu ve Bartın il sınırları içerisinde kalmaktadır. İdarî olarak millî park çevresindeki ilçe merkezleri ise Azdavay, Pınarbaşı, Ulus, Kurucaşile, Amasra ve Cide'dir. Küre Dağları Millî Parkı, yakın çevresini oluşturan tampon bölgelerle birlikte 103575 hektarlık bir alanı kaplamaktadır. Millî parkın kendisi ise 34018 hektar büyüklüğünde ve Batı Karadeniz Karst Kuşağı içinde yer almaktadır.", "Sarıkamış-Allahüekber Dağları Millî Parkı, Erzurum ve Kars illeri sınırları içinde, 22.519 hektarlık alanda 2004 yılında kurulmuş millî park. Binlerce Osmanlı askerinin öldüğü başarısız Sarıkamış Harekâtı, yaban hayatı zenginliği ve Sarıçam yayılışı Millî parkın temel özelliklerini oluşturur.", "Ağrı Dağı Millî Parkı, 2004 yılında, Ağrı dağı ve çevresindeki 88.014 ha alanda ilan edilen millî park. Nuh tufanı, Türkiye'nin en yüksek dağı ve en büyük buzulu, meteor çukuru, yaban hayatın çeşitliliği ile dikkat çeker.", "Gala Gölü Millî Parkı, Enez ve İpsala İlçeleri arasında bulunan Gala ve Pamuklu göllerini kapsayan alan 5 Mart 2005 tarihli Resmî Gazete'de yayınlanan 2005/8547 sayılı Bakanlar Kurulu kararıyla \"Gala Gölü Millî Parkı\" olarak belirlenmiştir.", "Sultan sazlığı, İç Anadolu Bölgesinde Kayseri il sınırları içerisinde Develi, Yahyalı ve Yeşilhisar ilçelerinin oluşturduğu üçgen içerisinde bulunmaktadır.[2]", "Tek Tek Dağları Millî Parkı, Şanlıurfa ilinde 19.335 ha alanda 2007 yılında ilan edilen millî park. Tektek Dağların üzerinde yer alır. Park alanı; Şuayip Şehri ve Soğmatar harabelerini, Senem mağarasını barındırır."
                ,"İğneada Longoz Ormanları Millî Parkı, Marmara bölgesi, Kırklareli ili, Demirköy ilçesinde, 3.155 ha alanda, 2007 yılında kurulan millî park[1].", "Yumurtalık Lagünü, Türkiye'nin Adana ilinin Yumurtalık ilçesinde yer alan bir lagündür. 21 Temmuz 2005'te Ramsar alanı olarak belirlenen lagün, 16 Aralık 2008'de millî park ilan edildi. Öncesinde tabiatı koruma alanı olarak sınıflandırılan Yumurtalık Lagünü 2008 yılında millî park yapılmış, Danıştay bu değişikliği iptal etse de 2016 yılında tamamlanan mahkeme süreciyle lagünün statüsü millî park olarak kesinlik kazanmıştır.[2][3]", "Tarihimize 93 Harbi olarak geçen 1877–1878 Osmanlı-Rus Savaşında şehrin korunmasında etkin rol üstlenen Mecidiye ve Aziziye tabyaları, Rusların kente daha fazla ilerlemesini engellemiştir. Erzurum’u ele geçirmek isteyen Ruslar Ermenilerin de yardımıyla Aziziye Tabyalarına saldırıp, nöbetçileri şehit ederler. Bu haber üzerine Erzurum halkı o zaman henüz 20 yaşında olan Nene Hatun’un önderliğinde kadın-erkek ellerine ne geçirdiyseler Aziziye Tabyasına koşarak büyük bir mücadele sonucunda tabyaları geri alırlar.", "Sakarya Meydan Muharebesi Tarihi Millî Parkı, Sakarya Meydan Muharebesi'nin yapıldığı alanda kurulan millî park[1]. Ankara ili Polatlı ve Haymana ilçe sınırlarındadır. 08.02.2015 tarihli Resmî Gazete'de[2] yayımlanan kararla 13.850 hektarlık alanda kurulmuştur.", "Kop Dağı Müdafaası Tarihî Millî Parkı, Türkiye'nin Bayburt ve Erzurum il sınırları içerisinde yer alan millî park.", "Malazgirt Meydan Muharebesi Millî Parkı, Muş ilinin Malazgirt ilçesi sınırları içerisinde yer alan millî park.", "İstiklâl Yolu, İnebolu sahilinden başlayıp Kastamonu ve Çankırı üzerinden Ankara'ya uzanan, Türk Kurtuluş Savaşı boyunca İnebolu'ya deniz yoluyla gelen cephanenin kağnılarla cepheye ulaştırılmasında kullanılmış olan 344 km'lik yoldur.[1] 2018'de 2.357 dekar alan millî park ilan edildi.[2][3]", "Botan Vadisi, Türkiye'nin Siirt ili sınırları içerisinde bulunan millî park statüsündeki tarihî alan.", "Hakkari Cilo ve Sat Dağları Millî Parkı, Türkiye'nin Hakkari ilinini Merkez, Şemdinli ve Yüksekova ilçeleri sınırları içinde yer alan bir millî parktır. 25 Eylül 2020 tarihinde kurulmuştur.[1] 27.500 hektar (275 km2) alan kaplamaktadır. Türkiye'nin 45. millî parkıdır.", "Sarıçalı Dağı Millî Parkı, Türkiye'nin Ankara ilinin Nallıhan ilçesinde yer alan bir millî parktır. 28 Ekim 2021 tarihinde kurulmuştur.[1] 1.024 hektar (10,24 km2) alan kaplamaktadır.", "Derebucak Çamlık Mağaraları Millî Parkı, Türkiye'nin Konya ilinin Derebucak ilçesinde yer alan bir millî parktır.", "Abant Gölü Millî Parkı, Türkiye'nin Bolu ilinin Mudurnu ilçesinde yer alan bir millî parktır."
        };



        
        List<milliPark> dizi = new List<milliPark> { };
        DateTime zaman;
        List<string>[] paragraflar = new List<string>[48];
        for (int i=0; i<paragraflar.Length; i++)
        {
            paragraflar[i] = new List<string>();
        }
        milliPark eklenecekPark;
        string line;
        string[] veriler;
        string[] sehirlerGecici;
        List<string> sehirler;
        Tree agac = new Tree();
        string[] geciciZaman;
        Hashtable parklar = new Hashtable();
        MaxHeap maxHeap = new MaxHeap(48);
        List<string> paragraf;
        

        for (int i = 0; i < paragArr.Length; i++)
        {
            paragraf = new List<string>();
            string[] cumleler = paragArr[i].Split(". ");
            foreach(string cumle in cumleler)
            {
                paragraflar[i].Add(cumle);
            }
                
        }


        try
        {
            //Dosyanın yolunu StreamReadera iletme
            StreamReader sr = new StreamReader("C:\\Users\\Selim\\source\\repos\\Proje3\\MilliPark.txt");
            //Read the first line of text
            line = sr.ReadLine();
            //Dosyanın sonuna kadar okuma
            int i = 0;
            while (line != null)
            {
                veriler = line.Split(";");
                
                
                geciciZaman = veriler[3].Split(".");
                zaman = new DateTime(int.Parse(geciciZaman[2]), int.Parse(geciciZaman[1]), int.Parse(geciciZaman[0]));
                //Satırdaki veriyi okuyup parkı oluşturma.
                eklenecekPark = new milliPark(veriler[0], veriler[1], double.Parse(veriler[2]), zaman, paragraflar[i]); // Dosyadan okunan parkı oluşturma
                agac.insert(eklenecekPark);//Ağaca parkı ekleme(1.a)
                // Sonraki satırı okuma
                line = sr.ReadLine();
                parklar.Add(eklenecekPark.getAd(), eklenecekPark);//Hashtable'a parkı ekleme(2.a)
                maxHeap.insert(eklenecekPark);//Max heap'e parkı eklme
                i++;
            }

            // Dosyayı kapatma
            sr.Close();
            Console.ReadLine();

            
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }

        //1.b
        int depth = agac.maxDepth(agac.getRoot(),0);
        Console.WriteLine("Ağacın derinliği: " + depth);
        agac.dengeliAgacDerinlik();

        //1.c
        string parkAdiBasi;
        Console.Write("Şehrini öğrenmek istediğiniz parkın adının ilk 3 harfini yazınız: ");
        parkAdiBasi = Console.ReadLine();
        agac.sehirBul(parkAdiBasi);


        //1.d
        KelimeAgaci kelimeAgaci= agac.kelimeAgaci();
        kelimeAgaci.inOrder(kelimeAgaci.getRoot());

        foreach (string key in parklar.Keys)
        {
            Console.WriteLine(String.Format("{0}: {1}", key, parklar[key]));
        }

        //2.b
        Console.Write("Tarihini değiştirmek istediğiniz parkın adını giriniz: ");
        string parkAdi = Console.ReadLine();
        Boolean milliParkFound;
        foreach (DictionaryEntry milliParkDict in parklar)
        {
            if (milliParkDict.Key.Equals(parkAdi))
            {
                milliParkFound = true;
                Console.Write("Yeni tarihi giriniz: ");
                string yeniTarih = Console.ReadLine();
                string[] tarihler = yeniTarih.Split(".");
                DateTime newTime = new DateTime(int.Parse(tarihler[0]), int.Parse(tarihler[1]), int.Parse(tarihler[2]));
                milliPark yeniMilliPark = (milliPark)milliParkDict.Value;
                yeniMilliPark.setKurulduguYil(newTime);
                parklar[milliParkDict.Key] = yeniMilliPark;
                break;
            }
        }

        //3.a
        Heap heap = new Heap(9);
        int[] randomArr = { 54, 23, 87, 43, 47, 14, 76, 5, 32 };
        foreach(int i in randomArr)
        {
            heap.insert(i);
        }
        Console.WriteLine(heap.remove().getKey());
        Console.WriteLine(heap.remove().getKey());
        Console.WriteLine(heap.remove().getKey());

        //3.c
        maxHeap.remove().getKey().toString();
        maxHeap.remove().getKey().toString();
        maxHeap.remove().getKey().toString();

        //4.a
        BubbleSort bubSort = new BubbleSort(9);
        foreach (int i in randomArr)
        {
            bubSort.insert(i);
        }
        bubSort.bubbleSort();
        bubSort.display();

    }
}
     







