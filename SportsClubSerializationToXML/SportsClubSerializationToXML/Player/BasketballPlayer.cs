using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Sports_Clubs
{
    class BasketballPlayer : Player
    {
        private string position;
        private int points;

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public int Points
        {
            get { return points; }
            set { points = value; }
        }

        public BasketballPlayer() { }

        public BasketballPlayer(string _name, int _age, decimal _earnings, string _pos, int _points)
                                : base(_name, _age,_earnings)
        {
            position = _pos;
            points = _points;
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + " Position: {0}; Points: {1}",
                position, Convert.ToString(points));
        }
    }
}
