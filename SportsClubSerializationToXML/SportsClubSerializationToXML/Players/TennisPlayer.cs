using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Sports_Clubs
{
    public class TennisPlayer : Player
    {
        private int rating;
        private int trophyCount;

        public int Raiting
        {
            get { return rating; }
            set { rating = value; }
        }

        public int TrophyCount
        {
            get { return trophyCount; }
            set { trophyCount = value; }
        }

        public TennisPlayer() { }
        public TennisPlayer(string _name, int _age, decimal _earnings, int _rating, int _trophyCount)
                                : base(_name, _age, _earnings)
        {
            rating = _rating;
            trophyCount = _trophyCount;
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + "Player: Tennis; Rating: {0}; Count Of Trophies: {1}",
                Convert.ToString(rating),Convert.ToString(trophyCount));
        }
    }
}
