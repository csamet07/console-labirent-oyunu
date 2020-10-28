using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Labirent
{
    class Program
    {
        //camelCase yapısı ile yazılmıştır.
        static int secim = 0;
        static int puan = 0;
        public static void StartGame()
        {
            Console.Write(" \t \t \t \t Labirent Oyununa Hoşgeldiniz\n\n\n\t\t\tEntera basarak oyuna başlayabilirsiniz.\n\nOyun size 3 adet yol sunar ve bunlardan birini seçerek oyunu başlatırsınız\nOyunda ilerleyebileceğiniz yerler 1 olan yollardır 0 olan yerler duvardır ve çarptığınızda puanınızdan 1 puan eksilir\nHer başarılı hamlenizde puanınız 1 artar.Yollar rastgele bir şekilde oluştuğundan dolayı bazen çıkış olmayabilir.\nSeçim ekranına geri geldiğinizde yollar yeniden güncellenir ve böylece çıkışı olan bir yol bulabilirsiniz\nHer yeniden seçim yaptğınızda puanınızda sıfırlanır\nİki adet gizli halde mayın bulunmaktadır bu mayınlara bastığınızda oyun biter.\n\t\t\t\t\t\t\t\t\t\t\t\tBOL ŞANSLAR :)");
            Console.Write(System.Environment.NewLine);
            Console.Write(System.Environment.NewLine);
        }

        public static void YolSecimi(string[,] map, int i)
        {
            puan = 0;
            Harita harita = new Harita();

            Console.Write(System.Environment.NewLine);
            Console.Write(" \t \t \t \t Başlangıç yolu seçiniz : " + System.Environment.NewLine);
            string gelenDeger = Console.ReadLine();

            if (gelenDeger == "1" || gelenDeger == "2" || gelenDeger == "3")
            {
                secim = Convert.ToInt32(gelenDeger);
                Console.Clear();
                harita.DrawGameMap(map, i, secim, puan);
            }
            else
            {
                Console.Write(" \t \t \t \t Geçersiz bir yol seçtiniz");
            }
        }
        public static void UyariVer()
        {
            MessageBox.Show("Duvara çarptın ve puanın 1 azaldı.");
        }

        static void Main(string[] args)
        {
            StartGame();
            Console.Title = "Labirent Oyunu";
            Console.ReadLine();

            Harita harita = new Harita();

            string[,] map = harita.CreateMap();
            string[,] bombalar = new string[10,10];
            

            for (int k = 0; k < 10; k++)
            {
                for (int m = 0; m < 10; m++)
                {
                    if (map[k, m] == "2")
                    {
                        bombalar[k, m] = "2";
                        map[k, m] = "1";
                    }
                }
            }

            
            int i = 0;

            harita.DrawFirstMap(map, i);
            Console.Write(System.Environment.NewLine);

            bool isFinish = true;

            while (isFinish)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                if (secim == 0)
                {
                    YolSecimi(map, i);
                }
                else
                {
                    Console.Write(System.Environment.NewLine);
                    Console.Write("Hareket Giriniz (w-a-s-d) - bombalar (g)" + System.Environment.NewLine);

                    string hareketDegeri = Console.ReadLine();

                    if (hareketDegeri != "w" && hareketDegeri != "a" && hareketDegeri != "s" && hareketDegeri != "d" && hareketDegeri != "g")
                    {
                        Console.Write(" \t \t \t \t Yanlış değer girdiniz.");
                       
                    }
                    else
                    {
                        Hareket hareket = new Hareket();
                        puan = hareket.MoveK(hareketDegeri, map, bombalar,puan);

                        //-999 oyun kazanıldı
                        //-500 başlangıca dönüş yapıldı
                        //-700 bomba bulundu
                        if (puan == -999)
                        {
                            isFinish = false;
                        }
                        else if (puan == -500)
                        {
                            Console.Clear();

                            Harita newHarita = new Harita();
                            map = newHarita.CreateMap();

                            for (int k = 0; k < 10; k++)
                            {
                                for (int m = 0; m < 10; m++)
                                {
                                    if (map[k, m] == "2")
                                    {
                                        bombalar[k, m] = "2";
                                        map[k, m] = "1";
                                    }
                                }
                            }

                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;

                            newHarita.DrawFirstMap(map, 0);

                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;

                            

                            secim = 0;
                            puan = 0;
                        }
                        else if (puan == -700)
                        {
                            Console.WriteLine("BOMBA Oyunu kaybettin.");
                            isFinish = false;
                            Console.ReadLine();                            
                        }
                    }                    
                }                
            }
        }
    
        
    }
}
