using System;
using System.Threading;

namespace Taskss.Games
{
    internal class Beach : Game, IFindNumber, IAI
    {
        public override string name { get { return "Beach"; } }
        public override void Init()
        {
            base.Init();
            Console.WriteLine();
        }
        public void FindNumber(Team team)
        {
            int maxScore = 5;
            int inputAttempt = 1;
            Random rand = new Random();
            int hiddenNumber = rand.Next(1, 10);
            Console.WriteLine("Было загаданно число от 1 до 10.\nПопробуйте отгадать его.");
            Console.Write("\nВведите предлолагаемое (целое) число: ");
            while (true)
            {
                bool flagAttempt = int.TryParse(Console.ReadLine(), out int attempt);
                if (!flagAttempt | attempt < 1 | attempt > 10)
                {
                    Console.WriteLine("Не верно введены данные попробуйте ещё раз.\n");
                    continue;
                }
                if (hiddenNumber == attempt)
                {
                    if (inputAttempt == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nВы выиграли 5 очков.");
                        Console.CursorVisible = false;
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.CursorVisible = true;
                        team.AddScore(maxScore);
                        return;
                    }
                    else if (inputAttempt == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nВы выиграли 2,5 очка.");
                        Console.CursorVisible = false;
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.CursorVisible = true;
                        team.AddScore(maxScore / 2);
                        return;
                    }
                }
                else
                {
                    inputAttempt++;
                    if (inputAttempt == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nВ этом раунде вы програли.");
                        Console.CursorVisible = false;
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.CursorVisible = true;
                        team.AddScore(0);
                        return;
                    }
                    else if (inputAttempt == 2)
                    {
                        Console.WriteLine("Вы не угадали, у вас есть ещё попытка.\n");
                    }
                }
                flagAttempt = false;
            }
        }

        public void AIRandomScore(Team team)
        {
            Random rand = new Random();
            int random = rand.Next(1, 3);
            if (random == 3)
            {
                team.AddScore(5);
            }
            else if (random == 1)
            {
                team.AddScore(2.5);
            }
            else
            {
                team.AddScore(0);
            }
        }
    }
}
