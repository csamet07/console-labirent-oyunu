using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirent
{
    class Harita
    {
        public string[,] CreateMap()
        {
            Random random = new Random();
            string[,] Map = new string[10,10];
            string[] randomDeger = new string[2];
            randomDeger[0] ="0";
            randomDeger[1] ="1";
            Map[9, 1] = "1";
            Map[9, 4] = "1";
            Map[9, 8] = "1"; ;
            Map[9, 0] = "0";
            Map[9, 2] = "0";
            Map[9, 3] = "0";
            Map[9, 5] = "0";
            Map[9, 6] = "0";
            Map[9, 7] = "0";
            Map[9, 9] = "0";

            Map[8, 1] = randomDeger[random.Next(0, 2)];
            Map[8, 4] = randomDeger[random.Next(0, 2)];
            Map[8, 8] = randomDeger[random.Next(0, 2)];
            Map[8, 0] = randomDeger[random.Next(0, 2)];
            Map[8, 2] = randomDeger[random.Next(0, 2)];
            Map[8, 3] = randomDeger[random.Next(0, 2)];
            Map[8, 5] = randomDeger[random.Next(0, 2)];
            Map[8, 6] = randomDeger[random.Next(0, 2)];
            Map[8, 7] = randomDeger[random.Next(0, 2)];
            Map[8, 9] = randomDeger[random.Next(0, 2)];


            Map[7, 1] = randomDeger[random.Next(0, 2)];
            Map[7, 4] = randomDeger[random.Next(0, 2)];
            Map[7, 5] = randomDeger[random.Next(0, 2)];
            Map[7, 8] = randomDeger[random.Next(0, 2)];
            Map[7, 9] = randomDeger[random.Next(0, 2)];
            Map[7, 0] = randomDeger[random.Next(0, 2)];
            Map[7, 2] = randomDeger[random.Next(0, 2)];
            Map[7, 3] = randomDeger[random.Next(0, 2)];
            Map[7, 6] = randomDeger[random.Next(0, 2)];
            Map[7, 7] = randomDeger[random.Next(0, 2)];

            Map[6, 1] = randomDeger[random.Next(0, 2)];
            Map[6, 2] = randomDeger[random.Next(0, 2)];
            Map[6, 4] = randomDeger[random.Next(0, 2)];
            Map[6, 5] = "2";
            Map[6, 6] = randomDeger[random.Next(0, 2)];
            Map[6, 8] = randomDeger[random.Next(0, 2)];
            Map[6, 9] = randomDeger[random.Next(0, 2)];
            Map[6, 0] = randomDeger[random.Next(0, 2)];
            Map[6, 3] = randomDeger[random.Next(0, 2)];
            Map[6, 7] = randomDeger[random.Next(0, 2)];

            Map[5, 2] = randomDeger[random.Next(0, 2)];
            Map[5, 5] = randomDeger[random.Next(0, 2)];
            Map[5, 6] = randomDeger[random.Next(0, 2)];
            Map[5, 7] = randomDeger[random.Next(0, 2)];
            Map[5, 8] = randomDeger[random.Next(0, 2)];
            Map[5, 0] = randomDeger[random.Next(0, 2)];
            Map[5, 1] = randomDeger[random.Next(0, 2)];
            Map[5, 3] = randomDeger[random.Next(0, 2)];
            Map[5, 4] = randomDeger[random.Next(0, 2)];
            Map[5, 9] = randomDeger[random.Next(0, 2)];

            Map[4, 2] = randomDeger[random.Next(0, 2)];
            Map[4, 5] = randomDeger[random.Next(0, 2)];
            Map[4, 6] = randomDeger[random.Next(0, 2)];
            Map[4, 7] = randomDeger[random.Next(0, 2)];
            Map[4, 8] = randomDeger[random.Next(0, 2)];
            Map[4, 0] = randomDeger[random.Next(0, 2)];
            Map[4, 1] = randomDeger[random.Next(0, 2)];
            Map[4, 3] = randomDeger[random.Next(0, 2)];
            Map[4, 4] = randomDeger[random.Next(0, 2)];
            Map[4, 9] = randomDeger[random.Next(0, 2)];

            Map[3, 2] = randomDeger[random.Next(0,2)];
            Map[3, 3] = "2";
            Map[3, 4] = randomDeger[random.Next(0, 2)];
            Map[3, 5] = randomDeger[random.Next(0, 2)];
            Map[3, 6] = randomDeger[random.Next(0, 2)];
            Map[3, 0] = randomDeger[random.Next(0, 2)];
            Map[3, 1] = randomDeger[random.Next(0, 2)];
            Map[3, 7] = randomDeger[random.Next(0, 2)];
            Map[3, 8] = randomDeger[random.Next(0, 2)];
            Map[3, 9] = randomDeger[random.Next(0, 2)];

            Map[2, 2] = randomDeger[random.Next(0, 2)];
            Map[2, 5] = randomDeger[random.Next(0, 2)];
            Map[2, 6] = randomDeger[random.Next(0, 2)];
            Map[2, 0] = randomDeger[random.Next(0, 2)];
            Map[2, 1] = randomDeger[random.Next(0, 2)];
            Map[2, 3] = randomDeger[random.Next(0, 2)];
            Map[2, 4] = randomDeger[random.Next(0, 2)];
            Map[2, 7] = randomDeger[random.Next(0, 2)];
            Map[2, 8] = randomDeger[random.Next(0, 2)];
            Map[2, 9] = randomDeger[random.Next(0, 2)];

            Map[1, 1] = randomDeger[random.Next(0, 2)];
            Map[1, 2] = randomDeger[random.Next(0, 2)];
            Map[1, 5] = randomDeger[random.Next(0, 2)];
            Map[1, 6] = randomDeger[random.Next(0, 2)];
            Map[1, 7] = randomDeger[random.Next(0, 2)];
            Map[1, 8] = randomDeger[random.Next(0, 2)];
            Map[1, 0] = randomDeger[random.Next(0, 2)];
            Map[1, 3] = randomDeger[random.Next(0, 2)];
            Map[1, 4] = randomDeger[random.Next(0, 2)];
            Map[1, 9] = randomDeger[random.Next(0, 2)];

            Map[0, 2] = randomDeger[random.Next(0, 2)];
            Map[0, 8] = randomDeger[random.Next(0, 2)];
            Map[0, 0] = randomDeger[random.Next(0, 2)];
            Map[0, 1] = randomDeger[random.Next(0, 2)];
            Map[0, 3] = randomDeger[random.Next(0, 2)];
            Map[0, 4] = randomDeger[random.Next(0, 2)];
            Map[0, 5] = randomDeger[random.Next(0, 2)];
            Map[0, 6] = randomDeger[random.Next(0, 2)];
            Map[0, 7] = randomDeger[random.Next(0, 2)];
            Map[0, 9] = randomDeger[random.Next(0, 2)];


            return Map;
        }

        public void DrawFirstMap(string[,] map, int i)
        {
            foreach (var item in map)
            {
                if (i % 10 == 0 || i == 100)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(System.Environment.NewLine);
                    Console.Write("\t \t \t \t " + new string(' ', 3));

                }
                if (item == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (item == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.BackgroundColor = ConsoleColor.White;

                Console.Write(" " + " " + item + " ");
                i++;
            }
            Console.Write(System.Environment.NewLine);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("\t \t " + new string(' ', 2));

            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("Başlangıç noktası");

            for (int j = 0; j < 10; j++)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;

                switch (j)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(" " + " " + "1" + " ");
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(" " + " " + "2" + " ");
                        break;
                    case 8:
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(" " + " " + "3" + " ");
                        break;
                    default:
                        Console.Write(" " + " " + " " + " ");
                        break;
                }
            }
        }

        public void DrawGameMap(string[,] map, int i, int secim, int puan)
        {

            Console.WriteLine("Puan: " + puan);
            switch (secim)
            {
                case 1:
                    map[9, 1] = "K";
                    break;
                case 2:
                    map[9, 4] = "K";
                    break;
                case 3:
                    map[9, 8] = "K";
                    break;
                default:
                    break;
            }


            foreach (var item in map)
            {
                if (i % 10 == 0 || i == 100)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(System.Environment.NewLine);
                    Console.Write("\t \t \t \t " + new string(' ', 3));

                }
                if (item == "1" || item == "K")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (item == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(" " + " " + item + " ");

                i++;
            }
            Console.Write(System.Environment.NewLine);
            
        }
    
        public void DrawMoveGameMap(string[,] map, int puan)
        {
            int i = 0;

            Console.WriteLine("Puan: " + puan);

            foreach (var item in map)
            {
                if (i % 10 == 0 || i == 100)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(System.Environment.NewLine);
                    Console.Write("\t \t \t \t " + new string(' ', 3));

                }
                if (item == "1" || item == "K")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (item == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(" " + " " + item + " ");

                i++;
            }
        }
    }
}
