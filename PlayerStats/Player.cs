using System;

namespace PlayerStats
{
    public class Player
    {
        private float _highScore;
        private int _playedGames;
        private int _wonGames;
        public string Name { get; }
        public Player(string name)
        {
            Name = name;
            _playedGames = 0;
            _wonGames = 0;
            _highScore = 0;
        }
        public float HighScores
        {
            get => _highScore;

            set
            {
                if (value > _highScore)
                {
                    _highScore = value;
                }
            }
        }
        public float WinRate
        {
            get
            {
                if (_wonGames > 0)
                {
                    return (_wonGames/_playedGames); 
                }
                else 
                {
                    return 0;
                }
            }
        }
        public void PlayGame(bool win)
        {
            float score = 0;
            _playedGames += 1;

            if (win)
            {
                _wonGames += 1;
                HighScores = score;
            }
        }
    }
}