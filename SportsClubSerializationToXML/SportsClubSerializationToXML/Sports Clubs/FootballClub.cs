using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Sports_Clubs
{
    class FootballClub : SportsClubs
    {
        private int countOfGoalkeepers;
        private int countOfDefenders;
        private int countOfMidfielders;
        private int countOfForwards;

        public int CountOfGoalKeepers
        {
            get { return countOfGoalkeepers; }
            set { countOfGoalkeepers = value; }
        }

        public int CountOfDefenders
        {
            get { return countOfDefenders; }
            set { countOfDefenders = value; }
        }

        public int CountOfMidfielders
        {
            get { return countOfMidfielders; }
            set { countOfMidfielders = value; }
        }

        public int CountOfForwards
        {
            get { return countOfForwards; }
            set { countOfForwards = value; }
        }

        public FootballClub() { }

        public FootballClub(string _name, string _country, string _city, string _homeArena, string _coach,
                            int _countOfGk, int _countOfDf, int _countOfMf, int _countOfFw)
                                : base(_name, _country,_city,_homeArena,_coach)
        {
            countOfGoalkeepers = _countOfGk;
            countOfDefenders = _countOfDf;
            countOfMidfielders = _countOfMf;
            countOfForwards = _countOfFw;
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + ". Squad: {0} goalkeepers, {1} defenders, {2} midfielders, {3} forwards",
                countOfGoalkeepers.ToString(), countOfDefenders.ToString(), countOfMidfielders.ToString(),
                countOfForwards.ToString());            
        }
    }
}
