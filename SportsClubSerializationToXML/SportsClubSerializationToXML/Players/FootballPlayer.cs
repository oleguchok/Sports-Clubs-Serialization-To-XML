using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SportsClubSerializationToXML.Sports_Clubs
{
    [Serializable]
    public class FootballPlayer : Player
    {
        /*private enum Positions
        {
            Goalkeeper,
            Defender,
            Midfielder,
            Forward
        }*/
        private int goalsCount;
        
        private string position;

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

        public FootballPlayer() { }

        public FootballPlayer(string _name, int _age, decimal _earnings, int _goalsCount, string _position)
                                : base(_name,_age,_earnings)
        {
            goalsCount = _goalsCount;
            position = _position;
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + "Player: Football; Goals count: {0}; Position: {1}",
                Convert.ToString(goalsCount),position);            
        }
    }
}
