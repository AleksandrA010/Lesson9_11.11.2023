using System;

namespace Taskss.Games
{
    internal interface IGameInit
    {
        string name { get; }
        void Init();
    }
}
