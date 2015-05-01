using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Sports_Clubs
{
    public class PokerPlayer : Player
    {
        private int rating;
        private double winrate;

        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public double Winrate
        {
            get { return winrate; }
            set { winrate = value; }
        }
        
        public PokerPlayer() { }

        public PokerPlayer(string _name, int _age, decimal _earnings, int _rating, double _winrate)
                                : base(_name, _age,_earnings)
        {
            rating = _rating;
            winrate = _winrate;
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + "Player: Poker; Rating: {0}; Winrate: {1}%",
                Convert.ToString(rating),Convert.ToString(winrate));
        }
    }
}
