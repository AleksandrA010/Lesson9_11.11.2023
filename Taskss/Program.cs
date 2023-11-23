using System;
using System.Collections.Generic;
using System.Threading;
using Taskss.Games;

namespace Taskss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //head
            Team Russia = null;
            Team France = null;
            Team China = null;
            Team Kazakhstan = null;
            string start = "Добро пожаловать в игру 'Big races'!";
            Console.CursorVisible = false;
            Console.SetCursorPosition((Console.BufferWidth - start.Length) / 2, 1);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(start);
            Thread.Sleep(3000);
            Console.Clear();
            Console.CursorVisible = true;
            Console.ForegroundColor = ConsoleColor.Gray;
            //main
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Russia,\nFrance,\nChina,\nKazakhstan.");
                Console.Write("\nВыберете страну, за которую хотите играть: ");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "Russia":
                        Russia = new Team("Russia");
                        Russia.InitPlayer();
                        France = new Team("France");
                        China = new Team("China");
                        Kazakhstan = new Team("Kazakhstan");
                        flag = false;
                        break;
                    case "France":
                        France = new Team("France");
                        France.InitPlayer();
                        Russia = new Team("Russia");
                        China = new Team("China");
                        Kazakhstan = new Team("Kazakhstan");
                        flag = false;
                        break;
                    case "China":
                        China = new Team("China");
                        China.InitPlayer();
                        France = new Team("France");
                        Russia = new Team("Russia");
                        Kazakhstan = new Team("Kazakhstan");
                        flag = false;
                        break;
                    case "Kazakhstan":
                        Kazakhstan = new Team("Kazakhstan");
                        Kazakhstan.InitPlayer();
                        Russia = new Team("Russia");
                        China = new Team("China");
                        France = new Team("France");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("\nВы не верно ввели страну, попробуйте ещё раз.");
                        Console.CursorVisible = false;
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.CursorVisible = true;
                        break;
                }
            }
            var listTeams = new List<Team>()
            {
                Russia, France, China, Kazakhstan
            };
            int PlayerIndexMemory = 0;
            for (int i = 0; i < listTeams.Count; i++)
            {
                if (listTeams[i].Player == true)
                {
                    PlayerIndexMemory = i;
                    break;
                }
            }
            //game 1
            Beach Beach = new Beach();
            Beach.Init();
            Beach.FindNumber(listTeams[PlayerIndexMemory]);
            for (int i = 0; i < listTeams.Count; i++)
            {
                if (i != PlayerIndexMemory)
                {
                    Beach.AIRandomScore(listTeams[i]);
                }
            }
            //final
            double maxScore = 0;
            int indexTeam = 0;
            var Teams = new List<string>();
            for (int i = 0; i < listTeams.Count; i++)
            {
                if (listTeams[i].Score > maxScore)
                {
                    maxScore = listTeams[i].Score;
                    indexTeam = i;
                }
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            for (int i = 0; i < listTeams.Count; i++)
            {
                if (listTeams[i].Score == maxScore)
                {
                    Teams.Add(listTeams[i].name + $", счёт — {maxScore}.");
                }
            }
            Console.WriteLine("\nКоманды с лучшим рейтингом: ");
            foreach (var item in Teams)
            {
                Console.Write(item + "\n");
            }
            Thread.Sleep(2000);
            Console.CursorVisible = false;
            Console.Write("\n\nДля завершения нажмите на любую клавишу...");
            Console.ReadKey();
        }
    }
}
