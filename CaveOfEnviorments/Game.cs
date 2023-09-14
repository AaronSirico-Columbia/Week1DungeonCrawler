using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaveOfEnviorments
{
    internal class Game
    {
        Player Mage = new Player();
        Utility Util = new Utility();
        //Ascii Art
        public void welcome()
        {
            Console.WriteLine("  ____                   ___   __   _____            _                                 _       \r\n / ___|__ ___   _____   / _ \\ / _| | ____|_ ____   _(_) ___  _ __ _ __ ___   ___ _ __ | |_ ___ \r\n| |   / _` \\ \\ / / _ \\ | | | | |_  |  _| | '_ \\ \\ / / |/ _ \\| '__| '_ ` _ \\ / _ \\ '_ \\| __/ __|\r\n| |__| (_| |\\ V /  __/ | |_| |  _| | |___| | | \\ V /| | (_) | |  | | | | | |  __/ | | | |_\\__ \\\r\n \\____\\__,_| \\_/ \\___|  \\___/|_|   |_____|_| |_|\\_/ |_|\\___/|_|  |_| |_| |_|\\___|_| |_|\\__|___/");
        }

        //Captures and outputs player name
        public void OutputName()
        {
            Console.Write("Enter your Name: ");
            Mage.name = Console.ReadLine();
            Console.WriteLine($"Welcome Mage {Mage.name}");
        }

        //Method for level one
        public void LevelOne()
        {
            Util.SetColor(ConsoleColor.Blue, ConsoleColor.Blue);
            Console.WriteLine($"This part of the cave is icy and frigid. An ice monster approaches you. {Mage.name}, what do you do?");
            Console.WriteLine("A. Ice Spell");
            Console.WriteLine("B. Fire Spell");
            Console.WriteLine("C. Boulder Spell");
            inputCapture();
            Util.SetColor(ConsoleColor.White, ConsoleColor.White);
        }
        //Method for level two
        public void LevelTwo()
        {
            Util.SetColor(ConsoleColor.DarkGreen, ConsoleColor.DarkGreen);
            Console.WriteLine($"Lush vines and foliage surrounds you. A towering shapeless water ghoul is manuvering toward you. {Mage.name}, what do you do?");
            Console.WriteLine("A. Ice Spell");
            Console.WriteLine("B. Fire Spell");
            Console.WriteLine("C. Boulder Spell");
            inputCapture();
            Util.SetColor(ConsoleColor.White, ConsoleColor.White);
        }

        //Method for level three
        public void LevelThree()
        {
            
            Console.WriteLine($"You have arrived at the end of the cave. Three items lie in front of you. {Mage.name}, what item do you choose?");
            Util.SetColor(ConsoleColor.DarkMagenta, ConsoleColor.DarkMagenta);
            Console.WriteLine("A. An Ancient Book");
            Util.SetColor(ConsoleColor.DarkYellow, ConsoleColor.DarkYellow);
            Console.WriteLine("B. A Weathered Treasure Chest");
            Util.SetColor(ConsoleColor.Red, ConsoleColor.Red);
            Console.WriteLine("C. An Elixir");
            inputCapture();
        }

        //Captures player input
        public void inputCapture()
        {
            Mage.input = Console.ReadLine();
        }

        //The overall game loop method
        public void GameLoop()
        {
            LevelOne();
            if (Mage.input.ToUpper() == "B")
            {
               
                Console.WriteLine($"{Environment.NewLine} The Ice Monster melts away at your feet. Your trudge through the cave continues... {Environment.NewLine}");
                LevelTwo();
                if(Mage.input.ToUpper() == "A")
                {
                    Console.WriteLine($"{Environment.NewLine} The Water Ghoul freezes fully in its place and shatters. The cave continues further... {Environment.NewLine}");
                    LevelThree();
                    if(Mage.input.ToUpper() == "A")
                    {
                        Console.Clear();
                        Util.SetColor(ConsoleColor.DarkMagenta, ConsoleColor.DarkMagenta);
                        Console.WriteLine("As you grab the book, the floor from under you propells you upward. You have done it, you are free!");
                    }
                    else if(Mage.input.ToUpper() == "B")
                    {
                        Console.Clear();
                        Util.SetColor(ConsoleColor.DarkYellow, ConsoleColor.DarkYellow);
                        Console.WriteLine("As you place your hands on the chest to open it, they are cemented to the chest. The cave begins to fill with water... ");
                    }
                    else
                    {
                        Console.Clear();
                        Console.Write("You drink the elixir, and everything fades to black...");
                    }
                }
                else if (Mage.input.ToUpper() == "C" || Mage.input.ToUpper() == "B")
                {
                    Console.Clear();
                    Util.SetColor(ConsoleColor.White, ConsoleColor.White);
                    Console.Write($"{Environment.NewLine} The spell has no effect. The monster has consumed you.{Environment.NewLine}");

                }
            }
            else if (Mage.input.ToUpper() == "C" || Mage.input.ToUpper() == "A")
                {
                Console.Clear();
                Util.SetColor(ConsoleColor.White, ConsoleColor.White);
                Console.Write($"{Environment.NewLine} The spell has no effect. The monster has consumed you.{Environment.NewLine}");

            }
            Util.SetColor(ConsoleColor.White, ConsoleColor.White);
        }

    }
}
