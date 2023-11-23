using System;

namespace Taskss
{
    internal class Team : ITeamInit
    {
        public string name;
        public bool player;
        public double score;
        public double Score { get { return score; } }
        public bool Player { get { return player; } }
        public Team(string name)
        {
            this.name = name;
            score = 0;
            player = false;
        }
        public void InitPlayer()
        {
            player = true;
        }
        public void AddScore(double add) 
        {
            score = score + add;
        }
    }
}
