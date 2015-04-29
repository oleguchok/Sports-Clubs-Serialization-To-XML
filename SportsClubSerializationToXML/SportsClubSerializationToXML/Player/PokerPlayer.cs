using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Sports_Clubs
{
    class PokerPlayer : Player
    {
        private int rating;
        private float winrate;

        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public float Winrate
        {
            get { return winrate; }
            set { winrate = value; }
        }
        
        public PokerPlayer() { }

        public PokerPlayer(string _name, int _age, decimal _earnings, int _rating, float _winrate)
                                : base(_name, _age,_earnings)
        {
            rating = _rating;
            winrate = _winrate;
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + " Rating: {0}; Winrate: {1}%",
                Convert.ToString(rating),Convert.ToString(winrate));
        }
    }
}
