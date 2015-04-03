using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Sports_Clubs
{
    class BasketballClub : SportsClubs
    {
        private int pointGuard;
        private int shootingGuard;
        private int smallForward;
        private int powerForward;
        private int center;

        public int PointGuard
        {
            get { return pointGuard; }
            set { pointGuard = value; }
        }

        public int ShootingGuard
        {
            get { return shootingGuard; }
            set { shootingGuard = value; }
        }

        public int SmallForward
        {
            get { return smallForward; }
            set { smallForward = value; }
        }

        public int PowerForward
        {
            get { return powerForward; }
            set { powerForward = value; }
        }

        public int Center
        {
            get { return center; }
            set { center = value; }
        }

        public BasketballClub() { }

        public BasketballClub(string _name, string _country, string _city, int _countOfPg, int _countOfSg, int _countOfSf, int _countOfPf, int _countOfC)
                                : base(_name, _country,_city)
        {
            pointGuard = _countOfPg;
            shootingGuard = _countOfSg;
            smallForward = _countOfSf;
            powerForward = _countOfPf;
            center = _countOfC;
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + ". Squad: {0} point guards, {1} shooting guards, {2} small forwards, {3} power forwards, {4} center",
                pointGuard.ToString(), shootingGuard.ToString(), smallForward.ToString(),
                powerForward.ToString(), center.ToString());
        }
    }
}
