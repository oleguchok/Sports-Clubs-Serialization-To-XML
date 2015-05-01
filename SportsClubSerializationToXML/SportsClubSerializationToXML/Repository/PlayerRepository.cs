using SportsClubSerializationToXML.Sports_Clubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SportsClubSerializationToXML.Repository
{
    [Serializable()]
    public class PlayerRepository
    {
        private List<Player> players = new List<Player>() 
        {
            new FootballPlayer() 
            { Age = 32, Position = "Attacker", GoalsCount = 12, Earnings = 1000, Name = "Lukas Podolski"},
            new HockeyPlayer()
            { Age = 40, Position = "Left Forward", GoalsCount = 32, PenaltyMin = 12, Earnings = 1500, Name = "Teemu Selane"},
            new TennisPlayer()
            { Age = 27, Earnings = 300000, TrophyCount = 10, Raiting = 8, Name = "Viktoria Azarenka"},
            new BasketballPlayer()
            { Age = 28, Points = 220, Earnings = 12310, Name = "James Lebron", Position = "Power Forward"},
            new PokerPlayer()
            { Age = 25, Winrate = 74, Rating = 49, Earnings = 200000, Name = "Viktor Blom"},
            new SnookerPlayer()
            { Age = 43, SenchuryCount = 854, Rating = 2, Earnings = 50, Name = "Ronnie O'Sullivan"}
        };
        public List<Player> Players 
        { 
            get { return players; }
            set { players = value; }
        }
    }
}
