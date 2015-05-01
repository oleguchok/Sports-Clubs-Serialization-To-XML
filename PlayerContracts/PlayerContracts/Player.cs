using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SportsClubSerializationToXML.Sports_Clubs
{
    [Serializable()]
    public abstract class Player
    {
        protected string name;
        protected int age;
        protected decimal earnings;

        public string Name 
        { 
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public decimal Earnings
        {
            get { return earnings; }
            set { earnings = value; }
        }

        public Player() { }

        public Player(string _name, int _age, decimal _earnings)
        {
            name = _name;
            age = _age;
            earnings = _earnings;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}; Age: {1}; Earnings: {2}.",
                name, Convert.ToString(age), Convert.ToString(earnings));
        }
    }
}
