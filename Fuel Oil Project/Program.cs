using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkaryakıtPROJE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Değişken Tanımlama
            double dizel = 25.12;
            double benzin = 19.68;
            double lpg = 10.14;

            double dizeltank = 1500;
            double benzintank = 2000;
            double lpgtank = 5000;

            double satismiktari = 0;

            char anamenusecim = '0';
            char altmenusecim = '0';
            char akaryakitfiyatguncelle = '0';
            char akaryakitsatistipi = '0';

        //Ana Menü Oluşturma

        MENU:
            Console.WriteLine("Akaryakıt Satış Takip Programı");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine();
            Console.WriteLine("1.Birim Fiyatları Göster");
            Console.WriteLine("2.Birim Fiyat Güncelle");
            Console.WriteLine("3.Akaryakıt Satışı Yap");
            Console.WriteLine("4.Depo Durumunu Göster");
            Console.WriteLine("5.Toplam Satışları Göster");
            Console.WriteLine("6.Çıkış Yap");

            Console.WriteLine();
            Console.WriteLine("Lütfen Seçiminizi Yapınız.");
            anamenusecim = Convert.ToChar(Console.ReadLine());

            //1


            if (anamenusecim == '1')
            {
                Console.Clear();
                Console.WriteLine("***Birim Fiyatlar Listesindesiniz***");
                Console.WriteLine();
                Console.WriteLine("Dizel(D) : {0} TL/Litre", dizel);
                Console.WriteLine("Benzin(B) : {0} TL/Litre", benzin);
                Console.WriteLine("LPG(L) : {0} TL/Litre", lpg);
                Console.WriteLine();

            ALTMENU:
                Console.WriteLine("Seçiminizi Yapınız: \n1: Ana Menüye Dön \n2: Programı Kapat");
                altmenusecim = Convert.ToChar(Console.ReadLine());

                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yaptınız! Lütfen Doğru Seçim Yapınız..");
                    Console.WriteLine();
                    goto ALTMENU;
                }
            }


            //2

            else if (anamenusecim == '2')
            {
                Console.Clear();
                Console.WriteLine("***Birim Fiyat Güncelleyiniz***");
                Console.WriteLine();




            AKARTYAKITTIPI:
                Console.WriteLine("Akaryakıt Tipini Seçiniz \n-D \n-B \n-L");
                akaryakitfiyatguncelle = Convert.ToChar(Console.ReadLine());

                if (akaryakitfiyatguncelle == 'D' || akaryakitfiyatguncelle == 'd')
                {
                    Console.WriteLine("Dizel (D) : {0} TL/Litre", dizel);
                    Console.Write("Dizel Yakıt İçin Yeni Fiyat Giriniz :");

                    dizel = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Değişiklik Yapilmıştır.");
                    Console.WriteLine("Güncel Dizel (D) : {0} TL/Litre", dizel);
                }
                else if (akaryakitfiyatguncelle == 'B' || akaryakitfiyatguncelle == 'b')
                {
                    Console.WriteLine("Benzin (B) : {0} TL/Litre", benzin);
                    Console.Write("Benzin Yakıt İçin Yeni Fiyat Giriniz :");

                    benzin = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Değişiklik Yapilmıştır.");
                    Console.WriteLine("Güncel Benzin (B) : {0} TL/Litre", benzin);
                }
                else if (akaryakitfiyatguncelle == 'L' || akaryakitfiyatguncelle == 'l')
                {
                    Console.WriteLine("LPG (L) : {0} TL/Litre", lpg);
                    Console.Write("LPG Yakıt İçin Yeni Fiyat Giriniz :");

                    lpg = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Değişiklik Yapilmıştır.");
                    Console.WriteLine("Güncel LPG (L) : {0} TL/Litre", lpg);
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yaptınız! Lütfen Doğru Seçim Yapınız..");
                    goto AKARTYAKITTIPI;
                }

            ALTMENU:
                Console.WriteLine("Seçiminizi Yapınız: \n1: Ana Menüye Dön \n2: Programı Kapat");
                altmenusecim = Convert.ToChar(Console.ReadLine());

                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yaptınız! Lütfen Doğru Seçim Yapınız..");
                    goto ALTMENU;
                }
            }



            //3


            else if (anamenusecim == '3')
            {

                Console.Clear();
                Console.WriteLine("***Akaryakıt Satışı İşlemlerindesiniz***");
                Console.WriteLine();

            AKARYAKITSATISI:
                Console.WriteLine("Akaryakıt Tipini Seçiniz \n-D \n-B \n-L");

                akaryakitsatistipi = Convert.ToChar(Console.ReadLine());

                if (akaryakitsatistipi == 'D' || akaryakitsatistipi == 'd')
                {
                    if (dizeltank == 0)
                    {
                        Console.WriteLine("Yakıt Tankında Hiç Dizel Yakıt Kalmamıştır");
                        goto MENU;
                    }
                    else
                    {
                        Console.WriteLine("lütfen Alacağınız Dizel Yakıt Miktarını Giriniz :");
                        satismiktari = Convert.ToDouble(Console.ReadLine());

                        if (dizeltank < satismiktari)
                        {
                            Console.WriteLine("Yakıt Tankında {0} Litre Dizel Yakıt Vardır! İşlem Başarısız.", dizeltank);
                            goto MENU;
                        }
                        else if (dizeltank >= satismiktari)
                        {
                            dizeltank = dizeltank - satismiktari;
                            Console.WriteLine();
                            Console.WriteLine("Yakıtınız Dolduruluyor .");
                            System.Threading.Thread.Sleep(3000);
                            Console.WriteLine();
                            Console.WriteLine("Yakıt Dolumu Tamamlanmıştır .");
                            Console.WriteLine("Yakıt Tankında {0} Litre Dizel Yakıt Kalmıştır.", dizeltank);
                            Console.WriteLine();
                        }
                    }
                }

                else if (akaryakitsatistipi == 'B' || akaryakitsatistipi == 'b')
                {
                    if (benzintank == 0)
                    {
                        Console.WriteLine("Yakıt tankında hiç Benzin yakıt kalmamıştır");
                        goto MENU;
                    }
                    else
                    {
                        Console.WriteLine("lütfen Alacağınız Benzin Yakıt Miktarını Giriniz :");
                        satismiktari = Convert.ToDouble(Console.ReadLine());

                        if (benzintank < satismiktari)
                        {
                            Console.WriteLine("Yakıt Tankında {0} Litre Benzin Yakıt Vardır! İşlem Başarısız.", benzintank);
                            goto MENU;
                        }
                        else if (benzintank >= satismiktari)
                        {
                            benzintank = benzintank - satismiktari;
                            Console.WriteLine("Yakıtınız Dolduruluyor .");
                            System.Threading.Thread.Sleep(3000);
                            Console.WriteLine();
                            Console.WriteLine("Yakıt Dolumu Tamamlanmıştır .");
                            Console.WriteLine("Yakıt Tankında {0} Litre Benzin Yakıt Kalmıştır.", benzintank);
                            Console.WriteLine();
                        }
                    }
                }

                else if (akaryakitsatistipi == 'L' || akaryakitsatistipi == 'l')
                {
                    if (lpgtank == 0)
                    {
                        Console.WriteLine("Yakıt tankında hiç LPG yakıt kalmamıştır");
                        goto MENU;
                    }
                    else
                    {
                        Console.WriteLine("lütfen Alacağınız LPG Yakıt Miktarını Giriniz :");
                        satismiktari = Convert.ToDouble(Console.ReadLine());

                        if (lpgtank < satismiktari)
                        {
                            Console.WriteLine("Yakıt Tankında {0} Litre LPG Yakıt Vardır! İşlem Başarısız.", lpgtank);
                            goto MENU;
                        }
                        else if (lpgtank >= satismiktari)
                        {
                            lpgtank = lpgtank - satismiktari;
                            Console.WriteLine("Yakıtınız Dolduruluyor .");
                            System.Threading.Thread.Sleep(3000);
                            Console.WriteLine();
                            Console.WriteLine("Yakıt Dolumu Tamamlanmıştır .");
                            Console.WriteLine("Yakıt Tankında {0} Litre LPG Yakıt Kalmıştır.", lpgtank);
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yaptınız! Lütfen Doğru Seçim Yapınız..");
                    goto AKARYAKITSATISI;
                }

            ALTMENU:
                Console.WriteLine("Seçiminizi Yapınız: \n1: Ana Menüye Dön \n2: Programı Kapat");
                altmenusecim = Convert.ToChar(Console.ReadLine());

                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yaptınız! Lütfen Doğru Seçim Yapınız..");
                    goto ALTMENU;
                }
            }



            //4

            else if (anamenusecim == '4')
            {

                Console.Clear();
                Console.WriteLine("***Depo Durumunu Göster***");
                Console.WriteLine();

                Console.WriteLine("Dizel Yakıt Tankı %{0} doludur", (dizeltank / 15));

                Console.WriteLine("Benzin Yakıt Tankı %{0} doludur", (benzintank / 20));

                Console.WriteLine("LPG Yakıt Tankı %{0} doludur", (lpgtank / 50));
                Console.WriteLine();

            ALTMENU:
                Console.WriteLine("Seçiminizi Yapınız: \n1: Ana Menüye Dön \n2: Programı Kapat");
                altmenusecim = Convert.ToChar(Console.ReadLine());

                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yaptınız! Lütfen Doğru Seçim Yapınız..");
                    goto ALTMENU;
                }
            }


            //5

            else if (anamenusecim == '5')
            {

                Console.Clear();
                Console.WriteLine("***Toplam Satışları Göster***");
                Console.WriteLine();

                Console.WriteLine("Satılan Toplam Dizel Yakıt : {0}", (1500 - dizeltank));
                Console.WriteLine("Toplam Dizel Yakıt Tutarı : {0}", (1500 - dizeltank) * dizel);
                Console.WriteLine();

                Console.WriteLine("Satılan Toplam Benzin Yakıt : {0}", (2000 - benzintank));
                Console.WriteLine("Toplam Benzin Yakıt Tutarı : {0}", (2000 - benzintank) * benzin);
                Console.WriteLine();

                Console.WriteLine("Satılan Toplam LPG Yakıt : {0}", (5000 - lpgtank));
                Console.WriteLine("Toplam LPG Yakıt Tutarı : {0}", (5000 - lpgtank) * lpg);
                Console.WriteLine();

                Console.WriteLine("Toplam Tutar :{0}", ((1500 - dizeltank) * dizel) + ((2000 - benzintank) * benzin) + ((5000 - lpgtank) * lpg));
                Console.WriteLine();

            ALTMENU:
                Console.WriteLine("Seçiminizi Yapınız: \n1: Ana Menüye Dön \n2: Programı Kapat");
                altmenusecim = Convert.ToChar(Console.ReadLine());

                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yaptınız! Lütfen Doğru Seçim Yapınız..");
                    goto ALTMENU;
                }
            }

            //6

            else if (anamenusecim == '6')
            {

                Console.WriteLine("Tekrar Bekleriz.. :)");
                System.Threading.Thread.Sleep(2000);
                Environment.Exit(0);
            }


        }
    }
}