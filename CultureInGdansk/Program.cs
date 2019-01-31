﻿using System;
using System.IO;

namespace CultureInGdansk
{
    class Program
    {


        static void Main(string[] args)
        {


            JsonReader ReadJson = new JsonReader
            {
            };



            ConsoleKeyInfo userInput;

            do
            {
                DisplayMenu();

                userInput = Console.ReadKey();
                Console.ReadLine();
                switch (userInput.KeyChar.ToString())
                {
                    case "1":
                        Console.Clear();
                        ReadJson.JsonRead();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("\nWcisnieto 2");
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("\nWcisnieto 3");
                        break;
                    case "4":
                        Console.Clear();
                        ReadJson.JsonUpdate();
                        break;
                    // itd.

                    default:
                        Console.Clear();
                        Console.WriteLine("\nNiema takiej opcji. Spróbuj jeszcze raz");
                        break;
                }

            } while (userInput.Key != ConsoleKey.Escape);


        }


        static public void DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to Gdańska Kultura application");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1. Wczytaj dane z pliku");
            Console.WriteLine("2. Wyszukaj wydarzenie");
            Console.WriteLine("3. Wyświetl szczegóły wydarzenia");
            Console.WriteLine("4. Zaktualizuj plik");
            Console.WriteLine("Press ESC to Exit");
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            Console.Write("Enter your selection: ");
            //string result = Console.ReadLine();

            //return Convert.ToInt32(result);
        }
    }
}