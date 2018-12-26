using System;
using System.Media;

namespace LostCountdown
{
    class Program
    {
        static void Main(string[] args)
        {
            //StartConsole();
            BeepOnKey();
        }

        private static void StartConsole()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Lost Countdown";
            Console.WriteLine(">: ");
            string input = Console.ReadLine();
            SoundPlayer player = new SoundPlayer($@"C:\Users\Chris\Desktop\Key press.wav");

            while (true)
            {
                switch (input)
                {
                    case "4 8 15 16 23 42":
                        Console.WriteLine("108");
                        input = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Wrong!");
                        input = Console.ReadLine();
                        break;
                }
            }
        }

        public static void BeepOnKey()
        {
            SoundPlayer player = new SoundPlayer($@"C:\Users\Chris\Desktop\Key press.wav");
            do
            {
                player.Stop();

                while (!Console.KeyAvailable)
                {
                }

                var mykey = Console.ReadKey(true);

                switch (mykey.Key)
                {
                    case ConsoleKey.DownArrow:
                        player.Stop();
                        break;
                    default:
                        Console.WriteLine("Otherkey!");
                        player.PlaySync();
                        break;
                }
            } while (true);
        }
    }
}
