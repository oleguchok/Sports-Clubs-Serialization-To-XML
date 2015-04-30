using SportsClubSerializationToXML.Sports_Clubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Repository
{
    class PlayerRepository
    {
        private List<Player> players = new List<Player>() 
        {
            new FootballPlayer() 
            { Age = 32, Position = "Attacker", GoalsCount = 12, Earnings = 1000, Name = "Lukas Podolski"}
        };
        public List<Player> Players 
        { 
            get { return players; }
            set { players = value; }
        }
    }
}
