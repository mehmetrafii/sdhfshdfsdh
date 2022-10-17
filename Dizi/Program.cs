using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Ornek
            //double malFiyati = 0, komisyonMitari = 0, toplamKomisiyon = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    try
            //    {
            //        Console.WriteLine("{0} Malin Fiyatini Giriniz: ", i + 1);
            //        malFiyati = Convert.ToDouble(Console.ReadLine());
            //        if (malFiyati > 60)
            //        {
            //            komisyonMitari = malFiyati * 0.02;
            //        }
            //        else if (malFiyati <= 60 && malFiyati > 0)
            //        {
            //            komisyonMitari = malFiyati * 0.03;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Yanlış girdi tekrar deneyiniz...");
            //            i--;
            //        }
            //        Console.WriteLine("{0} Mal İçin kom: {1}", i + 1, komisyonMitari);
            //        toplamKomisiyon += komisyonMitari;

            //    }

            //    catch (Exception)
            //    {

            //        i--;
            //    }
            //}
            //Console.WriteLine("Toplam : {0}", toplamKomisiyon);
            #endregion
            #region Ornek2
            //int[] dizi = new int[20];
            //Random rnd = new Random();
            //int diziToplam = 0, ortalamaBuyuk = 0, ortalamadanKucuk = 0;
            //double diziOrtalamasi = 0;
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    dizi[i] = rnd.Next(1, 25);
            //    diziToplam += dizi[i];
            //}
            //diziOrtalamasi = diziToplam / 20;
            //foreach (var dizim in dizi)
            //{
            //    if (dizim > diziOrtalamasi)
            //    {
            //        ortalamaBuyuk += 1;
            //    }
            //    else
            //    {
            //        ortalamadanKucuk += 1;
            //    }

            //}
            //Console.WriteLine("Ortalama: {0} Ortalamadan Büyük Eleman Sayisi: {1}," +
            //    " Ortalamadan Küçük eleman Sayisi:{2} ", diziOrtalamasi, ortalamaBuyuk, ortalamadanKucuk);
            //Console.ReadLine();



            #endregion
            #region merttutunmaz

            //int[] dizi = new int[20];

            //Random rnd = new Random();

            //int toplam = 0;
            //double aritmetik = 0;

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    dizi[i] = rnd.Next(0, 100);
            //    Console.WriteLine($"{i+1}. sayı = " + dizi[i]);
            //    toplam += dizi[i];
            //    aritmetik = toplam / dizi.Length;
            //}
            //Console.WriteLine("\nToplam ="+toplam);
            //Console.WriteLine("\naritmetik ortalama ="+aritmetik);

            //Console.WriteLine("\nAritmetik ortalamadan büyük olan sayılar:");

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    if (dizi[i]>aritmetik)
            //    {
            //        Console.Write(dizi[i]+" ");
            //    }
            //}

            //Console.WriteLine("\nAritmetik ortalamadan küçük olan sayılar:");

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    if (dizi[i] < aritmetik)
            //    {
            //        Console.Write(dizi[i]+" ");
            //    }
            //}

            //  Console.ReadLine();

            #endregion
            #region DevrimMehmet

            //int kisi = 0;
            //int toplam = 0;
            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int k = 1; k <=3; k++)
            //    {

            //            Console.WriteLine($"Lütfen {i}.kat {k}.dairede kaç kişi kalıyor? ");
            //            kisi = int.Parse(Console.ReadLine());
            //            toplam += kisi;

            //    }
            //}
            //Console.WriteLine("Bu Binada Toplam {0} kişi kalıyor.", toplam);
            //Console.ReadLine();
            #endregion
            #region Ornek4
            //int[,] dizi = new int[4, 3];
            //int toplamKisi = 0, evdeKisi = 0;
            //for (int i = 0; i < dizi.GetLength(0); i++)
            //{
            //    for (int j = 0; j < dizi.GetLength(1); j++)
            //    {
            //        Console.WriteLine("{0} . kat {1} Daire deki kişi Sayisi Giriniz:  ",i+1,j+1);
            //        evdeKisi = Convert.ToInt16(Console.ReadLine());
            //        toplamKisi += evdeKisi;
            //    }
            //}

            //Console.WriteLine("toplam kişi sayisi {0}",toplamKisi);
            #endregion
            #region Ornek
            //string cumle; char harf;
            //Console.Write("Cümleyi Giriniz : ");
            //cumle = Console.ReadLine();
            //Console.WriteLine("Girilen Cümele : {0}", cumle);
            //Console.Write("Şifreli Hali : ");
            //int sifreli = 0;
            //for (int i = cumle.Length - 1; i >= 0; i--)
            //{
            //    harf = cumle[i];
            //    if (harf == 'a')
            //    {
            //        harf = '?';
            //        sifreli++;
            //    }
            //    if (harf == 'e')
            //    {
            //        harf = '*';
            //        sifreli++;
            //    }
            //    if (harf == 'ı' || harf == 'i')
            //    { 
            //        harf = '='; sifreli++;
            //    }
            //    if (harf == 'ö' || harf == 'o') 
            //    { 
            //        harf = '&'; sifreli++; 
            //    }
            //    if (harf == 'u' || harf == 'ü')
            //    {
            //        harf = '+'; 
            //        sifreli++; 
            //    }
            //    if (i == 0) 
            //    {
            //        Console.WriteLine("{0}", harf);
            //    }

            //    else
            //   Console.Write("{0}", harf);
            //}
            //Console.WriteLine("Toplam {0} tane harf şifrelendi {1} tanesi şifrelenmedi", sifreli, cumle.Length - sifreli);
            #endregion
            #region IndexOf
            //int[] sayiRakam = new int[] { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine(Array.IndexOf(sayiRakam, 4));
            #endregion
            #region IndexOf
            //Array isimler = new[] {"Neval","İlker","Bedirhan","Burak","Mert1","Mert2","Erhan" };
            //  int index=  Array.IndexOf(isimler, "Bedirhan",0,6);
            //Console.WriteLine(index);
            #endregion
            #region IndexOf
            //Array isimler = new[] { "Neval", "İlker", "Bedirhan", "Burak", "Mert1", "Mert2", "Erhan" };
            //int index = Array.IndexOf(isimler, "İlker");

            //if (index!=-1)
            //{
            //    Console.WriteLine("var "+ index);

            //}
            //else
            //{
            //    Console.WriteLine("yok");
            //}
            #endregion
            #region IndexOf
            //int[] numaralar = new int[6];
            //int sayi;
            //int i = 0;
            //Random rmd = new Random();
            //while (i < 6)
            //{
            //    sayi = rmd.Next(1, 49);
            //    if (Array.IndexOf(numaralar, sayi) == -1)
            //    {
            //        numaralar[i] = sayi;
            //        i++;
            //    }
            //}
            //Array.Sort(numaralar);
            //foreach (int item in numaralar)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion
            #region Maaş
            //          double ahmetMaas = 0, hasanMaas = 0, ekUcret = 0;
            //          int kacAy = 0;
            //          Console.Write("Ahmet'in Başlangıç Maaşı :");
            //          ahmetMaas = Convert.ToDouble(Console.ReadLine());
            //          Console.Write("Hasan'ın Başlangıç Maaşı :");
            //          hasanMaas = Convert.ToDouble(Console.ReadLine());
            //          Console.Write("Kaç Ay Sürecek:");
            //          kacAy = Convert.ToInt32(Console.ReadLine());
            //          for (int i = 0; i <= kacAy; i++)
            //          {

            //              if (i % 2 == 0)
            //              {
            //                  //ahmetin para artacak
            //                  ekUcret = ahmetMaas * 0.5;
            //                  ahmetMaas += ekUcret;

            //              }
            //              else
            //              {
            //                  //ahmetin para azalacak
            //                  ekUcret = ahmetMaas * 0.25;
            //                  ahmetMaas -= ekUcret;

            //              }

            //              //hasanınki her türlü artacak

            //              ekUcret = hasanMaas * 0.25;
            //              hasanMaas += ekUcret;

            //Console.WriteLine("{ 0}. Ayın Sonunda Ahmetin Maaşı : { 1}, Hasanın Maaşı { 2}", i + 1,ahmetMaas,hasanMaas);
            //      }
            //          if (ahmetMaas == hasanMaas)
            //              Console.WriteLine("Sonuç Olarak {0} Ay Sonunda Ahmet, Hasandan Daha Fazla Maaş Almaktadır.", kacAy);
            //          else if (ahmetMaas == hasanMaas) { 

            //           Console.WriteLine("Sonuç Olarak {0} ", kacAy);
            //          }
            //          else { 
            //          Console.WriteLine("Sonuç Olarak { 0} Ay Sonunda Hasan Ahmetten Daha Fazla Maaş Almaktadır.", kacAy);

            //          } 
            #endregion
            #region Muhammet
            //string[] ay = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };
            //double ahmetMaas = 0;
            //double hasanMaas = 0;
            //start:
            //try
            //{
            //    Console.WriteLine("Ahmetin maaşını giriniz...");
            //    ahmetMaas = Convert.ToDouble(Console.ReadLine());
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Yanlış girdi tekrar deneyiniz!!!!");
            //    goto start;
            //}
            //start2:
            //try
            //{
            //    Console.WriteLine("Hasanın maaşını giriniz...");
            //    hasanMaas = Convert.ToDouble(Console.ReadLine());
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Yanlış girdi tekrar deneyiniz!!!!");
            //    goto start2;
            //}
            //double ahmetToplam = 0;
            //for (int i = 0; i < 12; i++)
            //{
            //    ahmetMaas = ahmetMaas * 1.5;
            //    ahmetToplam += ahmetMaas;
            //    Console.WriteLine($"Ahmetin {ay[i]} ayındaki maaşı : {ahmetMaas} Tl");
            //    i++;
            //    ahmetMaas = ahmetMaas * 0.75;
            //    Console.WriteLine($"Ahmetin {ay[i]} ayındaki maaşı : {ahmetMaas} Tl");
            //    ahmetToplam += ahmetMaas;


            //}
            //Console.WriteLine("*****************************");
            //double hasanToplam = hasanMaas;
            //for (int i = 1; i < 12; i++)
            //{
            //    hasanMaas = hasanMaas * 1.25;
            //    hasanToplam += hasanMaas;
            //    Console.WriteLine($"Hasanın {ay[i]} ayındaki maaşı : {hasanMaas} Tl");
            //}
            //Console.WriteLine("*****************************");
            //if (ahmetToplam > hasanToplam)
            //{
            //    Console.WriteLine($"Ahmetin maaşı Hasanın maaşından fazladır.\nAhmetin maaşı: {ahmetToplam} Tl\nHasanın maaşı : {hasanToplam} TL\nAradaki fark : {ahmetToplam-hasanToplam} TL");
            //}
            //else if (ahmetToplam < hasanToplam)
            //{
            //    Console.WriteLine($"Hasanın maaşı Ahmetin maaşından fazladır.\nHasanın maaşı: {hasanToplam} TL\nAhmetin maaşı : {ahmetToplam} TL\nAradaki fark : {hasanToplam - ahmetToplam} TL");
            //}
            //else if (hasanToplam == ahmetToplam)
            //{
            //    Console.WriteLine($"Maaşları eşittir. {hasanToplam}tl");
            //}
            #endregion
            #region Yanlıs
            //Random rnd = new Random();
            //int ilkSayi = 0, ikinciSayi = 0, toplamPuan = 0, sayilarinToplami = 0, girilenCevap = 0, dogruCevapSayisi = 0, yanlisCevapSayisi = 0;
            //char devam;
            //do
            //{

            //    ilkSayi = rnd.Next(1, 100);
            //    ikinciSayi = rnd.Next(1, 100);
            //    sayilarinToplami = ilkSayi + ikinciSayi;
            //    Console.WriteLine("{0} + {1} = ?", ilkSayi, ikinciSayi);
            //    Console.Write("Cevabınız : ");
            //    girilenCevap = Convert.ToInt32(Console.ReadLine());
            //    if (girilenCevap == sayilarinToplami)
            //    {
            //        Console.WriteLine("Tebrikler Bildiniz");
            //        toplamPuan += 5;
            //        dogruCevapSayisi += 1;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Üzgünüm Bilemediniz");
            //        toplamPuan -= 2;
            //        yanlisCevapSayisi += 1;
            //    }
            //    Console.Write("Tekrar Oynamak istiyormusunuz(e/E)?");
            //    devam = Convert.ToChar(Console.ReadLine());

            //} while (devam == 'E' || devam == 'e');

            //Console.WriteLine("Toplam Doğru Cevap Sayınız {0}, Yanlış Cevap Sayınız {1}, Toplamda Almış Olduğunuz Puan {2}", dogruCevapSayisi, yanlisCevapSayisi, toplamPuan);
            #endregion
            #region DevrimMehmet
            // start1:
            // Console.Clear();
            // Random random =new Random();
            // int toplamPuan = 0;
            // int soruSayisi = 0;
            // int cevap = 0;

            //basla:

            // int sayi1=random.Next(0,100);
            // int sayi2=random.Next(0,100);
            // Console.WriteLine("1.Sayı: {0}",sayi1);
            // Console.WriteLine("2.Sayı: {0}", sayi2);


            // bool durum = true;
            // while (durum)
            // {
            //     try
            //     {
            //         Console.WriteLine("Lütfen {0}+{1}=? işleminin sonucunu yazınız.", sayi1, sayi2);
            //         cevap = int.Parse(Console.ReadLine());
            //         durum = false;

            //     }
            //     catch (Exception)
            //     {

            //         Console.WriteLine("Lütfen int türünde sayı giriniz.");
            //     }
            // }
            // if (cevap==sayi1+sayi2)
            // {
            //     Console.WriteLine("Tebrikler doğru bildiniz.");
            //     toplamPuan += 5;

            // }
            // else
            // {
            //     Console.WriteLine("Üzgünüm yanlış cevap.");
            //     toplamPuan -= 2;
            // }
            // soruSayisi++;
            // Console.WriteLine("Devam Etmek istiyor Musunuz?(e/E) ");
            // string cevap2 = Console.ReadLine();
            // if (cevap2=="e" ||cevap2=="E")
            // {
            //     goto basla;
            // }
            // else
            // {
            //     Console.WriteLine("Toplam Puanınız:{0} ve cevapladığınız soru sayısı:{1} ",toplamPuan,soruSayisi);
            // }

            // Console.ReadLine();
            // Console.WriteLine("Sıfırlamak için bir tuşa basınız");
            // goto start1;

            #endregion
            #region OtoparkHesabı
            //double odenecekTutar = 0;
            //int kalinanSure = 0, aracTipi = 0;
            //Console.WriteLine("Araç Tipleri Taksi : 1, Minübüs : 2, Ticari : 3");
            //Console.Write("Lütfen Araç Tipini Giriniz : ");
            //aracTipi = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Kalınan Süreyi Giriniz : ");
            //kalinanSure = Convert.ToInt32(Console.ReadLine());
            //if (kalinanSure > 1)
            //{
            //    for (int i = 1; i <= kalinanSure; i++)
            //    {
            //        if (i == 1)
            //        {
            //            if (aracTipi == 1) 
            //            {
            //                odenecekTutar = i * 5;
            //            }
            //            else if (aracTipi == 2)
            //            {
            //                odenecekTutar = i * 6;
            //            }
            //            else if (aracTipi == 3) 
            //            { 
            //                odenecekTutar = i * 6.5;
            //            }
            //        }
            //        else
            //        {

            //            kalinanSure -= 1;
            //            if (aracTipi == 1) 
            //            {
            //                odenecekTutar += kalinanSure * 5 * 1.20;
            //            }
            //            else if (aracTipi == 2) 
            //            {
            //                odenecekTutar += kalinanSure * 6 * 1.215;
            //            }
            //            else if (aracTipi == 3) 
            //            {
            //                odenecekTutar += kalinanSure * 6.5 * 1.25;
            //            }
            //        }
            //    }

            //}

            //else
            //{

            //    if (aracTipi == 1)
            //    {

            //        odenecekTutar = kalinanSure * 5;
            //    }
            //    else if (aracTipi == 2) 
            //    {
            //        odenecekTutar = kalinanSure * 6;
            //    }
            //    else if (aracTipi == 3)
            //    {
            //        odenecekTutar = kalinanSure * 6.5;
            //    }

            //}
            //Console.WriteLine("Ödenecek Tutar : {0} TL", odenecekTutar);
            //Console.ReadLine();
            #endregion
            #region ParametredeDeger
            //bool sonuc = AsalSayimi(25);
            //if (sonuc) Console.WriteLine("Asal Sayı");
            //else Console.WriteLine("asal sayı değil");
            //Console.ReadLine(); 
            //static bool AsalSayimi(int sayi)
            //{
            //    bool sonuc;
            //    int sayac = 0;
            //    for (int i = 1; i <= sayi; i++)
            //    {
            //        if (sayi % i == 0)
            //        {
            //            sayac += 1;
            //        }

            //    }
            //    if (sayac == 2)
            //    {
            //        sonuc = true;
            //    }

            //    else
            //    {
            //        sonuc = false;
            //    }
            //    return sonuc;
            //}
            #endregion
            #region Cümle
            //static bool KelimeVarmi(string cumle, string kelime)
            //{

            //    bool sonuc;
            //    sonuc = false;
            //    string[] kelimeler = kelime.Split(' ');
            //    foreach (string kelimem in kelimeler)
            //    {
            //        if (kelimem == kelime) sonuc = true;
            //        break;
            //    }

            //    return sonuc;

            //}

            //main içi
            //bool sonuc = KelimeVarmi("osman bizi ışınla", "bizi");
            //    if (sonuc) Console.WriteLine("Var");
            //    else Console.WriteLine("YOK");
            //    Console.ReadLine();
            #endregion
            #region Mükemmel sayi
            //main kısımı==> MukemmelSayi(6);

            //static void MukemmelSayi(int sayi)
            //{
            //    int bolenToplami = 0;
            //    for (int i = 1; i < sayi; i++)
            //    {
            //        if (sayi % i == 0)
            //        {
            //            bolenToplami += i;
            //        }
            //    }
            //    if (sayi == bolenToplami)
            //    { Console.WriteLine("mükemmel sayı"); }
            //    else Console.WriteLine("mükemmel say değil");
            //}
            #endregion
            #region BeşinKatları


            //int elemanSayisi = 0;
            //int sonuc = 0;
            //int rastgeleSayi = 0;
            //Console.Write("Dizinin Eleman Sayısını Girin : ");
            //elemanSayisi = Convert.ToInt32(Console.ReadLine());
            //int[] dizi = new int[elemanSayisi];
            //Random rnd = new Random();
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    sonuc = 0;
            //    do
            //    {
            //        rastgeleSayi = rnd.Next(0, 1000);
            //        if (rastgeleSayi % 2 != 0 && rastgeleSayi % 5 == 0)
            //        {
            //            dizi[i] = rastgeleSayi;
            //            sonuc = 1;
            //        }

            //    } while (sonuc != 1);

            //    Console.WriteLine(dizi[i]);

            //}

            #endregion
            #region burak
            //Program prg = new Program();
            //prg.dizie();
            //public void dizie()
            //{
            //    Console.WriteLine("dizinin eleman sayısını girin");
            //    int dizie = int.Parse(Console.ReadLine());
            //    int[] dizi = new int[dizie];
            //    Random rnd = new Random();
            //    for (int i = 0; i < dizi.Length; i++)
            //    {
            //    start1:
            //        int sayi = rnd.Next(0, 1000);

            //        if (sayi % 2 == 1 & sayi % 5 == 0)
            //        {
            //            dizi[i] = sayi;
            //            Console.Write(dizi[i]+" ");
            //        }
            //        else goto start1;
            //    }
            //    Console.ReadLine();
            //}
            #endregion
            #region DevrimMehmet
            //int[,] dizi = new int[20, 2];
            //Random r = new Random();
            //for (int i = 0; i < dizi.GetLength(0); i++)
            //{
            //    dizi[i,0] = r.Next(0, 101);//vize
            //    dizi[i, 1] = r.Next(0, 101);//final
            //    int ortalama = (dizi[i, 0] + dizi[i, 1]) / 2;
            //    string sonuc = "Geçti";
            //    if (ortalama<70)
            //    {
            //        sonuc = "Kaldı";
            //    }
            //    Console.WriteLine($"{i+1}.Öğrenci Vize Notu:{dizi[i, 0]} Final Notu:{dizi[i, 1]} Ortalama: {ortalama} Sonuç: {sonuc}");
            //}

            #endregion
            #region kare
            /*    KarelerinToplami(int sayi) adlı kendini çağıran bir metot yazınız. Metot kendisine parametre olarak yollanan sayıdan bire(1) kadar olan sayıların karelerinin toplamını bulup geri döndürecektir. Eğer parametre olarak yollanan sayı 0 veya negatif ise “Hesaplama Ġşlemi Yapılamaz.” ġeklinde bir mesajı ekrana yazdırıp geriye -1 döndürecektir*/

            //KarelerinToplami(10);
            //static int KarelerinToplami(int sayi)
            //{
            //    int toplam =0;
            //    if (sayi < 1)
            //    {
            //        Console.WriteLine("hesaplama işlemi yapılamaz");
            //        toplam = -1; 
            //    }
            //    else
            //    {
            //        for (int i = 1; i <= sayi; i++)
            //        {
            //            toplam += i * i;
            //        }

            //    }
            //    Console.WriteLine(toplam);
            //    return toplam;
            //}
            #endregion




            deneme getir = new deneme();
            getir.metod4();
            getir.metod4();
            


            Console.ReadLine();
        }
       

            /*Erişim türleri:
   1)Public : Tüm classlarda çağrılıp, kullanılabilir. Global bir metot diye düşünülebilir.
   2)	Private : Sadece bulunduğu class da çağrılır.
   3)	Static : Bulunduğu class da metot adı ile dirkt çağrılır.
   4)	Public-static: genel bir değişken tanımlaması olmasına rağmen başka classa gidemez sadece kendi clasında class nesnesi tanımlanmadan kullanılabilir
   5)	Private-static: private clas özel tanımlama ve static ise classa ait değişken olduğundan dışarıdan çağırıldığında erişilemez
   */

            class deneme
            {
                public void metod4()
                {
                    Console.WriteLine("Metod 4");
                    deneme deger = new deneme();
                    deger.metod5();
                    metod6();
                }
                private void metod5()
                {
                    Console.WriteLine("Metod 5");
                }
                public static void metod6()
                {
                    Console.WriteLine("Metod 6");
                }
            }


        }
    }

    


