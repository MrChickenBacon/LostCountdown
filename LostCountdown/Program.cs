using System;
using System.Media;

namespace LostCountdown
{
    class Program
    {
        static void Main(string[] args)
        {
            StartConsole();
            //BeepOnKey();
        }

        private static void StartConsole()
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Lost Countdown";
            Console.Write(">: ");
            string input = Console.ReadLine();


            do
            {
                Console.Write(">: ");

                switch (input)
                {
                    case "4 8 15 16 23 42":
                        Console.WriteLine("108");
                        input = Console.ReadLine();
                        break;
                    default:
                        input = Console.ReadLine();
                        break;
                }
            } while (true);
        }

        public static void BeepOnKey()
        {
            SoundPlayer player = new SoundPlayer($@"C:\Users\Chris\Desktop\lost sounds\Key press.wav");
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
