using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Sports_Clubs
{
    class RugbyClub : SportsClubs
    {
        private int countOfDefenders;
        private int countOfAttackers;

        public int CountOfDefenders
        {
            get { return countOfDefenders; }
            set { countOfDefenders = value; }
        }

        public int CountOfAttackers
        {
            get { return countOfAttackers; }
            set { countOfAttackers = value; }
        }

        public RugbyClub() { }
        public RugbyClub(string _name, string _country, string _city, int _countOfDf, int _countOfAt)
                                : base(_name, _country,_city)
        {
            countOfDefenders = _countOfDf;
            countOfAttackers = _countOfAt;
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + ". Squad: {0} defenders, {1} attackers",
                countOfDefenders.ToString(), countOfAttackers.ToString());
        }
    }
}
