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
    public partial class FormPlay : Form
    {
        // class variables
        private Database db = new Database();
        private List<Geo> listG = new List<Geo>();
        private Player p; // current player

        private Random rnd = new Random();

        private int curGeoIndex; // current question index in Geo list
        private int bingoIndex; // right answer index of a radio button (1 of 4)

        private RadioButton[] rBtnArr;
        private PictureBox[] picBoxArr;
        private int checkedIndex; // checked Radio button Index in an array

        private int counter = 0; // question counter

        private List<int> noList = new List<int>(); // list for used data records

        private int mode = 0; // Quiz mode: 1 - guess country, 2 - guess capital, 3 - guess flag
        private int score = 0; // current player score
        

        // constructor
        public FormPlay(Player p)
        {
            this.p = p;
            InitializeComponent();
        }
        
        private void FormPlay_Load(object sender, EventArgs e)
        {
            listG = db.getGeoFromDB();
            lblPName.Text = p.pname;
            picBoxArr = new PictureBox[] { picBoxFlag1, picBoxFlag2, picBoxFlag3, picBoxFlag4 };
            lblCurrentScore.Text = $"score: {score.ToString()}";
        }

        //select mode panel
        private void btnStart_Click(object sender, EventArgs e)
        {
            // choosing mode changes the visibility of the panels
            panelChooseMode.Visible = false;
            panelPlay.Visible = true;
            
            if (rBtnFlag.Checked)
            {
                panelFlag.Visible = true;
                mode = 3;
            }
            else
            {
                panelCounCap.Visible = true;
                mode = 2;
                if (rBtnCountry.Checked)
                    mode = 1;
            }
            // starts the quiz
            NextQuestion();
        }
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // main logic
        private void NextQuestion()
        {
            lblPage.Text = $"{counter + 1}/10"; // updates the question number
            int rndIndex;
            List<int> rndList = new List<int>(); // List of 4 random indexes (of geo data record) used in a question

            do {
                rndIndex = rnd.Next(0, listG.Count()); // creates a number between 1 and the highest number in a geo list
                if (!rndList.Contains(rndIndex) && !noList.Contains(rndIndex))
                {
                    rndList.Add(rndIndex);
                    noList.Add(rndIndex);
                }
            } while (rndList.Count() < 4);

            curGeoIndex = rndIndex; // the last random number will be used for the current question

            // creates a random place (one of 4 radio buttons) for the right answer
            bingoIndex = rnd.Next(0, 4);

            // locates the right answer
            if (bingoIndex != 3)
            {
                rndList[3] = rndList[bingoIndex];
                rndList[bingoIndex] = curGeoIndex;
            }
            
            // mode GUESS FLAG
            if(mode == 3)
            {
                lblQuestionFlag.Text = $"{listG[curGeoIndex].country}, {listG[curGeoIndex].capital}";
                
                rBtnArr = new RadioButton[] { rBtn1f, rBtn2f, rBtn3f, rBtn4f };

                for (int i = 0; i < 4; i++)
                    picBoxArr[i].Image = Image.FromFile($@"flags/{listG[rndList[i]].flag}");
            }
            else // modes GUESS CAPITAl or GUESS COUNTRY
            {
                picBoxQuestion.Image = Image.FromFile($@"flags/{listG[curGeoIndex].flag}");

                if (mode == 2)
                    lblQuestionCounCap.Text = listG[curGeoIndex].country;
                else
                    lblQuestionCounCap.Text = listG[curGeoIndex].capital;

                rBtnArr = new RadioButton[] { rBtn1, rBtn2, rBtn3, rBtn4 };

                for (int i = 0; i < 4; i++)
                {
                    if (mode == 2)
                        rBtnArr[i].Text = listG[rndList[i]].capital;
                    else
                        rBtnArr[i].Text = listG[rndList[i]].country;
                }
            }
        }
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            if(btnOk.Text == "OK")
            {
                RadioButton checkedButton;
                if (mode == 3)
                    checkedButton = panelFlag.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                else
                    checkedButton = panelCounCap.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

                if (checkedButton != null)
                {
                    // search for the index of the checked radio button in array
                    
                    for (checkedIndex = 0; checkedIndex < rBtnArr.Length; checkedIndex++)
                        if (rBtnArr[checkedIndex] == checkedButton) break;

                    if (checkedIndex == bingoIndex)
                    {
                        checkedButton.ForeColor = Color.Green;
                        lblErrorPlay.ForeColor = Color.Green;
                        picBoxArr[bingoIndex].BackColor = Color.Green;
                        lblErrorPlay.Text = "you knew it!";
                        score += 3;
                        lblCurrentScore.Text = $"score: {score.ToString()}";
                    }
                    else
                    {
                        checkedButton.ForeColor = Color.Red;
                        picBoxArr[checkedIndex].BackColor = Color.Red;
                        rBtnArr[bingoIndex].ForeColor = Color.Green;
                        picBoxArr[bingoIndex].BackColor = Color.Green;
                        lblErrorPlay.ForeColor = Color.Red;
                        lblErrorPlay.Text = "that's wrong, sorry :(";
                    }
                    btnOk.Text = "NEXT";
                }
                else
                {
                    lblErrorPlay.ForeColor = Color.Red;
                    lblErrorPlay.Text = "please select one";
                }
            }
            else // button NEXT
            {
                counter++; // question counter
                if(counter < 10)
                {
                    UpdateControls();
                    btnOk.Text = "OK";
                    NextQuestion();
                }
                else
                    ShowPanelPlayEnd();
            }
        }


        private void UpdateControls()
        {
            rBtnArr[checkedIndex].ForeColor = Color.Black;
            rBtnArr[checkedIndex].Checked = false;
            picBoxArr[checkedIndex].BackColor = Color.Transparent;
            rBtnArr[bingoIndex].ForeColor = Color.Black;
            picBoxArr[bingoIndex].BackColor = Color.Transparent;
            lblErrorPlay.ForeColor = Color.Silver;
            lblErrorPlay.Text = "Error message";
        }

        // panel play end
        private void btnEnd_Click(object sender, EventArgs e)
        {
            ShowPanelPlayEnd();
        }

        private void ShowPanelPlayEnd()
        {
            panelPlay.Visible = false; // todo check  hide panelFlag
            panelPlayEnd.Visible = true;
            lblPnamePlayEnd.Text = p.pname;
            lblYourScore.Text += score.ToString();

            if (score > p.highscore)
                db.saveNewHighscore(p.id.ToString(), score.ToString());
        }
        
        private void btnPlayEndOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
