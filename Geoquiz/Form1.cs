using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geoquiz
{
    public partial class Form1 : Form
    {
        private Database db = new Database();
        private List<Player> listP = new List<Player>();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (tbPlayer.Text != "")
            {
                int index = RegPlayer();
                FormPlay Play = new FormPlay(listP[index]);
                Play.ShowDialog();
            }
            else
            { 
                lblErrorF1.ForeColor = Color.Red;
                lblErrorF1.Text = "please type player name";
            }
        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            if (tbPlayer.Text != "")
                RegPlayer();

            FormScores Scores = new FormScores();
            Scores.ShowDialog();
        }

        private int RegPlayer()
        {
            listP = db.getPlayersFromDB();
            int index = listP.FindIndex(x => x.pname == tbPlayer.Text);
            lblErrorF1.ForeColor = Color.Green;
            lblErrorF1.Text = $"welcome back {tbPlayer.Text}";
            if (index == -1)
            {
                db.saveNewPlayer(tbPlayer.Text);
                listP = db.getPlayersFromDB();
                index = listP.Count() - 1;
                lblErrorF1.ForeColor = Color.Green;
                lblErrorF1.Text = $"user {tbPlayer.Text} created";
            }
            return index;
        }
    }
}
