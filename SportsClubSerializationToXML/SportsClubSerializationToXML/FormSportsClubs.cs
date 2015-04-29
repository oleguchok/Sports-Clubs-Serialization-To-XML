using SportsClubSerializationToXML.Creators;
using SportsClubSerializationToXML.Sports_Clubs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsClubSerializationToXML
{
    public partial class FormSportsClubs : Form
    {
        ClubCreator clubCreator;
        List<Player> sportsClubs = new List<Player>();
        Player forEdit;

        public FormSportsClubs()
        {
            InitializeComponent();
        }

        private void TextBoxEnabled()
        {
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            textBox11.Enabled = true;
        }

        private void radioButtonFootball_CheckedChanged(object sender, EventArgs e)
        {
            clubCreator = new FootballClubCreator();
            TextBoxEnabled();
            label7.Text = "Count of Goalkeepers";
            label8.Text = "Count of Defenders";
            label9.Text = "Count of Midfielders";
            label10.Text = "Count of Forwards";
            textBox11.Enabled = false;
            label11.Text = "";
        }

        private void radioButtonBasketball_CheckedChanged(object sender, EventArgs e)
        {
            clubCreator = new BasketballClubCreator();
            TextBoxEnabled();
            label7.Text = "Count of Point Guards";
            label8.Text = "Count of Shooting Guards";
            label9.Text = "Count of Small Forwards";
            label10.Text = "Count of Power Forwards";
            label11.Text = "Count of Centre";
        }

        private void radioButtonVolleyball_CheckedChanged(object sender, EventArgs e)
        {
            clubCreator = new VolleyballClubCreator();
            TextBoxEnabled();
            label7.Text = "Count of Middle Blockers";
            label8.Text = "Count of Outside Hitters";
            label9.Text = "Count of Libero";
            label10.Text = "Count of Setters";
            label11.Text = "Count of Opposite";
        }

        private void radioButtonHockey_CheckedChanged(object sender, EventArgs e)
        {
            clubCreator = new HockeyClubCreator();
            TextBoxEnabled();
            label7.Text = "Count of Goalkeepers";
            label8.Text = "Count of Defenders";
            label9.Text = "Count of Left Forwards";
            label10.Text = "Count of Center Forwards";
            label11.Text = "Count of Right Forwards";
        }

        private void radioButtonRugby_CheckedChanged(object sender, EventArgs e)
        {
            clubCreator = new RugbyClubCreator();
            TextBoxEnabled();
            label7.Text = "Count of Defenders";
            label8.Text = "Count of Attackers";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox9.Enabled = false;
        }

        private void radioButtonHandball_CheckedChanged(object sender, EventArgs e)
        {
            clubCreator = new HandballClubCreator();
            TextBoxEnabled();
            label7.Text = "Count of Goalkeepers";
            label8.Text = "Count of Wingers";
            label9.Text = "Count of Backs";
            label10.Text = "Count of Centre";
            label11.Text = "Count of Circle Runner";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            List<string> data = new List<string>();
            
            data.Add(textBox1.Text);
            data.Add(textBox2.Text);
            data.Add(textBox3.Text);
            data.Add(textBox7.Text);
            data.Add(textBox8.Text);
            data.Add(textBox9.Text);
            data.Add(textBox10.Text);
            data.Add(textBox11.Text);
            
            sportsClubs.Add(clubCreator.FactoryMethod(data.ToArray()));
            listBoxClubs.Items.Clear();
            foreach (SportsClubs club in sportsClubs)
                listBoxClubs.Items.Add(club);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {            
            sportsClubs.RemoveAt(listBoxClubs.SelectedIndex);
            listBoxClubs.Items.Clear();
            foreach (SportsClubs club in sportsClubs)
                listBoxClubs.Items.Add(club);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            forEdit = sportsClubs[listBoxClubs.SelectedIndex];
            FillFields(forEdit);
        }

        private void FillFields(SportsClubs forEdit)
        {
            textBox1.Text = forEdit.Name;
            textBox2.Text = forEdit.Country;
            textBox3.Text = forEdit.City;
            Type t = forEdit.GetType();
            if (t.Name == "FootballClub")
               
        }
    }
}
