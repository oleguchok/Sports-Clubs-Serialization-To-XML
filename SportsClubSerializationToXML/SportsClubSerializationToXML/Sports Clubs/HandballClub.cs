using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Sports_Clubs
{
    class HandballClub : SportsClubs
    {
        private int countOfGoalkeepers;
        private int countOfWingers;
        private int countOfBacks;
        private int countOfCentre;
        private int countOfCircleRunners;

        public int CountOfGoalKeepers
        {
            get { return countOfGoalkeepers; }
            set { countOfGoalkeepers = value; }
        }

        public int CountOfWingers
        {
            get { return countOfWingers; }
            set { countOfWingers = value; }
        }

        public int CountOfLeftBacks
        {
            get { return countOfBacks; }
            set { countOfBacks = value; }
        }

        public int CountOfCentre
        {
            get { return countOfCentre; }
            set { countOfCentre = value; }
        }

        public int CountOfCircleRunners
        {
            get { return countOfCircleRunners; }
            set { countOfCircleRunners = value; }
        }

        public HandballClub() { }

        public HandballClub(string _name, string _country, string _city, string _homeArena, string _coach,
                            int _countOfGk, int _countOfW, int _countOfB, int _countOfCr, int _countOfCen)
                                : base(_name, _country,_city,_homeArena,_coach)
        {
            countOfGoalkeepers = _countOfGk;
            countOfCircleRunners = _countOfCr;
            countOfBacks = _countOfB;
            countOfWingers = _countOfW;
            countOfCentre = _countOfCen;
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + ". Squad: {0} goalkeepers, {1} backs, {2} wingers, {3} centre, {4} circle runners",
                countOfGoalkeepers.ToString(),countOfBacks.ToString(),countOfWingers.ToString(),
                countOfCentre.ToString(),countOfCircleRunners.ToString());
        }
    }
}
