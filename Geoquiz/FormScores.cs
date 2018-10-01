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
    public partial class FormScores : Form
    {
        private Database db = new Database();
        private List<Player> listP = new List<Player>();

        public FormScores()
        {
            InitializeComponent();
        }
        
        private void FormScores_Load(object sender, EventArgs e)
        {
            // show players in comboBox
            listP = db.getPlayersFromDB();
            foreach (var x in listP)
                comboBplayers.Items.Add(x.pname);

            // show all highscores in the dataGridView
            ShowAllHighscores();
        }
        
        private void rBtnAllPlayers_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnAllPlayers.Checked)
            {
                comboBplayers.SelectedIndex = -1;
                ShowAllHighscores();
            }
        }

        private void comboBplayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBplayers.SelectedIndex == -1)
                rBtnAllPlayers.Checked = true;
            else
            {
                rBtnAllPlayers.Checked = false;
                ShowPlayerHighscore(listP[comboBplayers.SelectedIndex]);
            }
        }

        private void ShowAllHighscores()
        {
            dataGridViewScores.Rows.Clear();
            foreach (var x in listP)
                dataGridViewScores.Rows.Add(x.pname, x.highscore.ToString());
        }

        private void ShowPlayerHighscore(Player p)
        {
            dataGridViewScores.Rows.Clear();
            dataGridViewScores.Rows.Add(p.pname, p.highscore.ToString());
        }

        private void btnBackScores_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
