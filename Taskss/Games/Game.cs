using System;
using Taskss.Games;

namespace Taskss
{
    internal abstract class Game : IGameInit
    {
        public abstract string name { get; }

        public virtual void Init()
        {
            Console.Clear();
            Console.WriteLine($"Добро пожаловать на игру {name}.");
        }
    }
}
