using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Sports_Clubs
{
    class VolleyballClub : SportsClubs
    {
        private int countOfMiddleBlockers;
        private int countOfOutsideHitters;
        private int countOfLibero;
        private int countOfSetters;
        private int countOfOpposite;

        public int CountOfMiddleBlockers
        {
            get { return countOfMiddleBlockers; }
            set { countOfMiddleBlockers = value; }
        }

        public int CountOfOutsideHitters
        {
            get { return countOfOutsideHitters; }
            set { countOfOutsideHitters = value; }
        }

        public int CountOfLibero
        {
            get { return countOfLibero; }
            set { countOfLibero = value; }
        }

        public int CountOfSetters
        {
            get { return countOfSetters; }
            set { countOfSetters = value; }
        }

        public int CountOfOpposite
        {
            get { return countOfOpposite; }
            set { countOfOpposite = value; }
        }

        public VolleyballClub() { }

        public VolleyballClub(string _name, string _country, string _city, string _homeArena, string _coach,
                            int _countOfMb, int _countOfOh, int _countOfLib, int _countOfSet, int _countOfOpp)
                                : base(_name, _country,_city,_homeArena,_coach)
        {
            countOfOpposite = _countOfOpp;
            countOfOutsideHitters = _countOfOh;
            countOfSetters = _countOfSet;
            countOfLibero = _countOfLib;
            countOfMiddleBlockers = _countOfMb;
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + ". Squad: {0} middle blockers, {1} outside hitters, {2} libero, {3} setters, {4} opposite",
                countOfMiddleBlockers.ToString(), countOfOutsideHitters.ToString(), countOfLibero.ToString(),
                countOfSetters.ToString(), countOfOpposite.ToString());
        }
    }
}
