using SportsClubSerializationToXML.Sports_Clubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin
{
    class F1Player : Player
    {
        private int granpriWins;
        private string team;
        private int rating;

        public int GranpriWins
        {
            get { return granpriWins; }
            set { granpriWins = value; }
        }

        public string Team
        {
            get { return team; }
            set { team = value; }
        }

        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public F1Player() { }

        public F1Player(string _name, int _age, decimal _earnings, int _gpWins, string _team, int _rating)
                                : base(_name,_age,_earnings)
        {
            GranpriWins = _gpWins;
            Team = _team;
            Rating = _rating;
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + "Player: F1; GranPri Wins: {0}; Team: {1}; Rating: {2}",
                Convert.ToString(granpriWins), team, Convert.ToString(rating));
        }
    }
}
