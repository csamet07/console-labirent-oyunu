using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Labirent
{
    class Hareket
    {

        public int MoveK(string key, string[,] map, string[,] bombalar, int puan)
        {
            Console.Clear();
            Harita harita = new Harita();
            int konumX = 0;
            int konumY = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (map[i,j] == "K")
                    {
                        konumX = i;
                        konumY = j;
                    }
                }
            }

            //ConsoleKeyInfo KeyInput = Console.ReadKey(true);
            if (key == "w")
            {
                konumX--;
                if (map[konumX, konumY] == "0")
                {
                    konumX++;
                    puan--;
                    Program.UyariVer();
                    harita.DrawMoveGameMap(map, puan);                    
                    return puan;
                }
                else if (bombalar[konumX, konumY] == "2")
                {
                    //Console.WriteLine("BOMBA Oyunu kaybettin.");
                    puan = -700;
                    return puan;
                }
                else
                {
                    map[konumX+1, konumY] = "1";
                    map[konumX, konumY] = "K";
                    if (konumX == 0)
                    {
                        
                        Console.Clear();
                        Console.WriteLine("Oyun Bitti. Puanınız : " + puan);
                        Console.ReadLine();
                        puan = -999;
                    }
                    else
                    {
                        puan++;
                        harita.DrawMoveGameMap(map, puan);
                    }

                                       
                    return puan;
                }
            }
            else if (key == "s")
            {
                if ((konumX == 9 && konumY == 1) || (konumX == 9 && konumY == 4) || (konumX == 1 && konumY == 8))
                {
                    puan = -500;
                    return puan;
                }
                else
                {
                    konumX++;
                    if (map[konumX, konumY] == "0")
                    {
                        konumX--;
                        harita.DrawMoveGameMap(map, puan);
                        Program.UyariVer();
                        puan--;
                        return puan;
                    }
                    else if (bombalar[konumX, konumY] == "2")
                    {
                        //Console.WriteLine("BOMBA Oyunu kaybettin.");
                        puan = -700;
                        return puan;
                    }
                    else
                    {
                        map[konumX - 1, konumY] = "1";
                        map[konumX, konumY] = "K";
                        puan++;
                        harita.DrawMoveGameMap(map, puan);
                        return puan;
                        //    if ((konumX == 9 && konumY == 1) || (konumX == 9 && konumY == 4) || (konumX == 1 && konumY == 8))
                        //    {
                        //        puan = -500;
                        //        return puan;
                        //    }
                        //    else
                        //    {

                        //    }
                        //}
                    }
                }
            }
            else if (key == "a")
            {
                if (konumY == 0)
                {
                    puan--;
                    Program.UyariVer();
                    harita.DrawMoveGameMap(map, puan);
                    return puan;
                }
                else
                {
                    konumY--;
                    if (map[konumX, konumY] == "0")
                    {
                        konumY++;
                        puan--;
                        Program.UyariVer();
                        harita.DrawMoveGameMap(map, puan);
                        return puan;
                    }
                    else if (bombalar[konumX, konumY] == "2")
                    {
                        //Console.WriteLine("BOMBA Oyunu kaybettin.");
                        puan = -700;
                        return puan;
                    }
                    else
                    {
                        map[konumX, konumY + 1] = "1";
                        map[konumX, konumY] = "K";
                        puan++;
                        harita.DrawMoveGameMap(map, puan);
                        return puan;
                    }
                }                
            }
            else if (key == "d")
            {
                if (konumY == 9)
                {
                    puan--;
                    Program.UyariVer();
                    harita.DrawMoveGameMap(map, puan);
                    return puan;
                }
                else
                {
                    konumY++;
                    if (map[konumX, konumY] == "0")
                    {
                        konumY--;
                        puan--;
                        Program.UyariVer();
                        harita.DrawMoveGameMap(map, puan);
                        return puan;
                    }
                    else if (bombalar[konumX, konumY] == "2")
                    {
                        //Console.WriteLine("BOMBA Oyunu kaybettin.");
                        puan = -700;
                        return puan;
                    }
                    else
                    {
                        map[konumX, konumY - 1] = "1";
                        map[konumX, konumY] = "K";
                        puan++;
                        harita.DrawMoveGameMap(map, puan);
                        return puan;
                    }
                }                
            }
            else if (key == "q")
            {
                Environment.Exit(0);
            }
            else if (key == "g")
            {
                bool bombaAcik = true;
                foreach (var item in map)
                {
                    if (item == "2")
                    {
                        bombaAcik = false;
                    }
                }

                if (!bombaAcik)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (bombalar[i, j] == "2")
                            {
                                map[i, j] = "1";
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (bombalar[i, j] == "2")
                            {
                                map[i, j] = "2";
                            }
                        }
                    }
                }



                harita.DrawMoveGameMap(map, puan);
            }
            else
            {
                Console.WriteLine("hatalı giriş");
            }

            if ((konumX == 0 && konumY == 2) || (konumX == 0 && konumY == 8))
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();

                Console.WriteLine(System.Environment.NewLine);
                Console.WriteLine(System.Environment.NewLine);
                Console.WriteLine(System.Environment.NewLine);
                Console.WriteLine(System.Environment.NewLine);
                Console.WriteLine("\t \t \t \t Oyun bitti tebrikler.");
                Console.ReadLine();
            }
            return puan;
        }

    }
}
