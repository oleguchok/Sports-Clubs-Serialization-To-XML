using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Sports_Clubs
{
    class HockeyPlayer : Player
    {
        private int goalsCount;
        private string position;
        private int penaltyMin;

        public int GoalsCount
        {
            get { return goalsCount; }
            set { goalsCount = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public int PenaltyMin
        {
            get { return penaltyMin; }
            set { penaltyMin = value; }
        }

        public HockeyPlayer() { }

        public HockeyPlayer(string _name, int _age, decimal _earnings, int _goalsCount, string _position, int _penMin)
                                : base(_name,_age,_earnings)
        {
            goalsCount = _goalsCount;
            position = _position;
            penaltyMin = _penMin;
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + "Player: Hockey; Goals count: {0}; Position: {1}. Penalty: {2}",
                Convert.ToString(goalsCount), position, Convert.ToString(penaltyMin));
        }
    }
}
