
    public class Stats
    {
        public int Wins { get; set;}
        public int Lose { get;set;}
        public int Fights { get; set;}
        public Stats(int wins, int lose, int fights)
        {
            Wins = wins;
            Lose = lose;
            Fights = fights;
        }
        public Stats(){ }
    }

