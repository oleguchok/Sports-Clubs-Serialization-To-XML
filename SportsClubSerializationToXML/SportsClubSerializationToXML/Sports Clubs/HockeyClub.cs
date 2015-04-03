using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Sports_Clubs
{
    class HockeyClub : SportsClubs
    {
        private int countOfGoalkeepers;
        private int countOfDefenders;
        private int countOfLeftForwards;
        private int countOfCentralForwards;
        private int countOfRightForwards;

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

        public int CountOfLeftForwards
        {
            get { return countOfLeftForwards; }
            set { countOfLeftForwards = value; }
        }

        public int CountOfCentralForwards
        {
            get { return countOfCentralForwards; }
            set { countOfCentralForwards = value; }
        }

        public int CountOfRightForwards
        {
            get { return countOfRightForwards; }
            set { countOfRightForwards = value; }
        }

        public HockeyClub() { }

        public HockeyClub(string _name, string _country, string _city, string _homeArena, string _coach,
                            int _countOfGk, int _countOfDf, int _countOfLf, int _countOfCf, int _countOfRf)
                                : base(_name, _country,_city,_homeArena,_coach)
        {
            countOfGoalkeepers = _countOfGk;
            countOfDefenders = _countOfDf;
            countOfLeftForwards = _countOfLf;
            countOfCentralForwards = _countOfCf;
            countOfRightForwards = _countOfRf;
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + ". Squad: {0} goalkeepers, {1} defenders, {2} left forwards, {3} central forwards, {4} right forwards",
                countOfGoalkeepers.ToString(), countOfDefenders.ToString(), countOfLeftForwards.ToString(),
                countOfCentralForwards.ToString(), countOfRightForwards.ToString()); 
        }
    }
}
