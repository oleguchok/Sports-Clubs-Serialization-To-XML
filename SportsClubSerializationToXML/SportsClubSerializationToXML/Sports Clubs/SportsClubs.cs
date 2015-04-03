using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Sports_Clubs
{
    abstract class SportsClubs
    {
        protected string name;
        protected string country;
        protected string city;
        protected string homeArena;
        protected string coach;

        public string Name 
        { 
            get { return name; }
            set { name = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string HomeArena
        {
            get { return homeArena; }
            set { homeArena = value; }
        }

        public string Coach
        {
            get { return coach; }
            set { coach = value; }
        }

        public SportsClubs() { }

        public SportsClubs(string _name, string _country, string _city,
                           string _homeArena, string _coach)
        {
            name = _name;
            country = _country;
            city = _city;
            homeArena = _homeArena;
            coach = _coach;
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + ": Team {0} from {1},{2}. Home arena {3}. Coach{4}",
                name, country, city, homeArena, coach);
        }
    }
}
