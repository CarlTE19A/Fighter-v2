using System;
using System.IO;
using System.Text.Json;

namespace TheGrace
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayTitle();

            System.Console.WriteLine();
            ChooseGrace();
            System.Console.WriteLine("---END---");
            Console.ReadLine();
        }
        public static void ChooseGrace()
        {
            char graceChoice = 'a';
            while(graceChoice != 'x')
            {
                System.Console.WriteLine("Do you want NEW GRACE?");
                System.Console.WriteLine("y/n, x to exit");
                graceChoice = Console.ReadKey().KeyChar;
                Console.Clear();
                graceChoice = Char.ToLower(graceChoice);
                if(graceChoice == 'y')
                {
                    Grace yourGrace = NewGrace();
                }
                else if(graceChoice == 'n')
                {
                    LastGrace();
                }
            }
        }
        public static void LastGrace()
        {   
            Console.Clear();
            Grace lastGrace = new Grace();
            try
            {
                lastGrace = JsonSerializer.Deserialize<Grace>(File.ReadAllText(@"Grace.json"));
            }
            catch
            {
                lastGrace.Name = "NONEXISTENT";
            }
            if(lastGrace.Danger == 666)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            System.Console.WriteLine("The Last Players Grace:");
            System.Console.WriteLine(lastGrace.Name);
            System.Console.WriteLine(lastGrace.Name + " has the Worth of " + lastGrace.Worth);
            System.Console.WriteLine(lastGrace.Name + " has the danger level of " + lastGrace.Danger);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey(); Console.WriteLine();
        }
        public static Grace NewGrace()
        {
            Grace yourGrace = new Grace();
            System.Console.WriteLine("What is your Grace?");
            yourGrace.Name = Console.ReadLine();
            System.Console.WriteLine("Worth Level:" + yourGrace.Worth);
            System.Console.WriteLine("Danger Level:" + yourGrace.Danger);
            string newGrace = JsonSerializer.Serialize<Grace>(yourGrace);
            File.WriteAllText(@"Grace.json", newGrace);
            return yourGrace;
        }
        public static void DisplayTitle()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.WriteLine(@"  _____    __      ________   _______ _    _ ______    _____ _____            _____ ______ ");
            System.Console.WriteLine(@" / ____|  /\ \    / /  ____| |__   __| |  | |  ____|  / ____|  __ \     /\   / ____|  ____|");
            System.Console.WriteLine(@"| (___   /  \ \  / /| |__       | |  | |__| | |__    | |  __| |__) |   /  \ | |    | |__   ");
            System.Console.WriteLine(@" \___ \ / /\ \ \/ / |  __|      | |  |  __  |  __|   | | |_ |  _  /   / /\ \| |    |  __|  ");
            System.Console.WriteLine(@" ____) / ____ \  /  | |____     | |  | |  | | |____  | |__| | | \ \  / ____ \ |____| |____ ");
            System.Console.WriteLine(@"|_____/_/    \_\/   |______|    |_|  |_|  |_|______|  \_____|_|  \_\/_/    \_\_____|______|");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
