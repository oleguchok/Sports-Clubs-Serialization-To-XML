using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Sports_Clubs
{
    class SnookerPlayer : Player
    {
        private int rating;
        private int senchuryCount;

        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public int SenchuryCount
        {
            get { return senchuryCount; }
            set { senchuryCount = value; }
        }

        public SnookerPlayer() { }

        public SnookerPlayer(string _name, int _age, decimal _earnings,int _rating, int _senCount)
                                : base(_name, _age,_earnings)
        {
            rating = _rating;
            senchuryCount = _senCount;
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + "Player: Snooker; Rating: {0}; Count of SenchuryBreaks: {1}",
                Convert.ToString(rating),Convert.ToString(senchuryCount)); 
        }
    }
}
