using System;
using System.Windows.Forms;

namespace dashboard.PL
{
    public partial class frmControlPanel : Form
    {
        EL.Matches matchEL = new EL.Matches();
        BL.Matches matchBL = new BL.Matches();

        public frmControlPanel()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        public class BufferedPanel : Panel
        {
            public BufferedPanel()
            {
                DoubleBuffered = true;
            }
        }

        public bool UpdateMatch()
        {
            if (matchBL.Update(matchEL))
            {
                GetMatchInformation();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void GetMatchInformation()
        {

            matchEL.Matchid = 1;
            matchEL = matchBL.Select(matchEL);


            //control panel
            lblSetNumber.Text = matchEL.Currentset.ToString();

            lblTeamAName.Text = matchEL.Teamaname;
            lblTeamAWonSet.Text = matchEL.Teamawonsets.ToString();

            lblTeamBName.Text = matchEL.Teambname;
            lblTeamBWonSet.Text = matchEL.Teambwonsets.ToString();

            if (matchEL.Currentset == 1)
            {
                lblTeamAScore.Text = matchEL.Teamaset1.ToString();
                lblTeamATimeOut.Text = matchEL.Teamatimeout1.ToString();

                lblTeamBScore.Text = matchEL.Teambset1.ToString();
                lblTeamBTimeOut.Text = matchEL.Teambtimeout1.ToString();
            }

            if (matchEL.Currentset == 2)
            {
                lblTeamAScore.Text = matchEL.Teamaset2.ToString();
                lblTeamATimeOut.Text = matchEL.Teamatimeout2.ToString();

                lblTeamBScore.Text = matchEL.Teambset2.ToString();
                lblTeamBTimeOut.Text = matchEL.Teambtimeout2.ToString();
            }

            if (matchEL.Currentset == 3)
            {
                lblTeamAScore.Text = matchEL.Teamaset3.ToString();
                lblTeamATimeOut.Text = matchEL.Teamatimeout3.ToString();

                lblTeamBScore.Text = matchEL.Teambset3.ToString();
                lblTeamBTimeOut.Text = matchEL.Teambtimeout3.ToString();
            }

            if (matchEL.Currentset == 4)
            {
                lblTeamAScore.Text = matchEL.Teamaset4.ToString();
                lblTeamATimeOut.Text = matchEL.Teamatimeout4.ToString();

                lblTeamBScore.Text = matchEL.Teambset4.ToString();
                lblTeamBTimeOut.Text = matchEL.Teambtimeout4.ToString();
            }

            if (matchEL.Currentset == 5)
            {
                lblTeamAScore.Text = matchEL.Teamaset5.ToString();
                lblTeamATimeOut.Text = matchEL.Teamatimeout5.ToString();

                lblTeamBScore.Text = matchEL.Teambset5.ToString();
                lblTeamBTimeOut.Text = matchEL.Teambtimeout5.ToString();
            }



        }

        private void ResetMatch()
        {
            matchEL.Matchnumber = "";
            matchEL.Refereename = "";
            matchEL.Scorername = "";
            matchEL.Linejudges1name = "";
            matchEL.Linejudges2name = "";
            matchEL.Linejudges3name = "";
            matchEL.Linejudges4name = "";
            matchEL.Division = "";
            matchEL.Matchdate = "";
            matchEL.Matchtime = "";
            matchEL.Teamaname = "-";
            matchEL.Teamacoach = "";
            matchEL.Teamaset1 = 0;
            matchEL.Teamaset2 = 0;
            matchEL.Teamaset3 = 0;
            matchEL.Teamaset4 = 0;
            matchEL.Teamaset5 = 0;
            matchEL.Teamatimeout1 = 0;
            matchEL.Teamatimeout2 = 0;
            matchEL.Teamatimeout3 = 0;
            matchEL.Teamatimeout4 = 0;
            matchEL.Teamatimeout5 = 0;
            matchEL.Teamawonsets = 0;
            matchEL.Teamaresult = "";
            matchEL.Teambname = "-";
            matchEL.Teambcoach = "";
            matchEL.Teambset1 = 0;
            matchEL.Teambset2 = 0;
            matchEL.Teambset3 = 0;
            matchEL.Teambset4 = 0;
            matchEL.Teambset5 = 0;
            matchEL.Teambtimeout1 = 0;
            matchEL.Teambtimeout2 = 0;
            matchEL.Teambtimeout3 = 0;
            matchEL.Teambtimeout4 = 0;
            matchEL.Teambtimeout5 = 0;
            matchEL.Teambwonsets = 0;
            matchEL.Teambresult = "";
            matchEL.Currentset = 1;
            matchEL.Matchsaveddatetime = "";
            matchEL.Bestof = 3;

            if (UpdateMatch())
            {
                btnSaveMatch.Visible = false;
            }

            CheckIfCanSet();
            ShowAddMinusButtons(true);


        }

        private void CheckIfCanSet()
        {
            if ((Convert.ToInt32(lblTeamAScore.Text) >= 25 & Convert.ToInt32(lblTeamAScore.Text) > (Convert.ToInt32(lblTeamBScore.Text) + 1)) | (Convert.ToInt32(lblTeamBScore.Text) >= 25 & Convert.ToInt32(lblTeamBScore.Text) > (Convert.ToInt32(lblTeamAScore.Text) + 1)))
            {
                btnSet.Visible = true;

            }
            else
            {
                btnSet.Visible = false;
            }
        }


        private void CheckIfCanEndMatch()
        {
            bool bol = false;
            if (matchEL.Bestof == 3)
            {
                if (matchEL.Teamawonsets == 2 | matchEL.Teambwonsets == 2)
                {
                    btnSaveMatch.Visible = true;
                    ShowAddMinusButtons(false);
                    bol = true;
                }
                else
                {
                    btnSaveMatch.Visible = false;
                    ShowAddMinusButtons(true);
                }

            }

            if (matchEL.Bestof == 5)
            {
                if (matchEL.Teamawonsets == 3 | matchEL.Teambwonsets == 3)
                {
                    btnSaveMatch.Visible = true;
                    ShowAddMinusButtons(false);
                    bol = true;
                }
                else
                {
                    btnSaveMatch.Visible = false;
                    ShowAddMinusButtons(true);
                }

            }

            if (bol)
            {
                if (matchEL.Teamawonsets > matchEL.Teambwonsets)
                {
                    matchEL.Teamaresult = "WIN";
                    matchEL.Teambresult = "LOSE";
                }

                if (matchEL.Teambwonsets > matchEL.Teamawonsets)
                {
                    matchEL.Teamaresult = "LOSE";
                    matchEL.Teambresult = "WIN";
                }

                if (matchEL.Teamawonsets == matchEL.Teambwonsets)
                {
                    matchEL.Teamaresult = "DRAW";
                    matchEL.Teambresult = "DRAW";
                }

                btnSet.Visible = false;
            }


            UpdateMatch();

        }

        private void ShowAddMinusButtons(bool bol)
        {
            btnTeamAScoreAdd.Visible = bol;
            btnTeamBScoreAdd.Visible = bol;
            btnTeamAScoreMinus.Visible = bol;
            btnTeamBScoreMinus.Visible = bol;
            btnTeamATimeOutAdd.Visible = bol;
            btnTeamBTimeOutAdd.Visible = bol;
            btnTeamATimeOutMinus.Visible = bol;
            btnTeamBTimeOutMinus.Visible = bol;

        }

        private void frmControlPanel_Load(object sender, EventArgs e)
        {

            GetMatchInformation();
            CheckIfCanSet();
            CheckIfCanEndMatch();

        }



        private void btnMatchInfo_Click(object sender, EventArgs e)
        {
            frmMatchInformation frmMatchInformation = new frmMatchInformation(matchEL, this);
            frmMatchInformation.ShowDialog();
        }

        private void btnTeamAScoreAdd_Click(object sender, EventArgs e)
        {
            if (matchEL.Currentset == 1)
            {
                matchEL.Teamaset1 = matchEL.Teamaset1 + 1;
            }

            if (matchEL.Currentset == 2)
            {
                matchEL.Teamaset2 = matchEL.Teamaset2 + 1;
            }

            if (matchEL.Currentset == 3)
            {
                matchEL.Teamaset3 = matchEL.Teamaset3 + 1;
            }

            if (matchEL.Currentset == 4)
            {
                matchEL.Teamaset4 = matchEL.Teamaset4 + 1;
            }

            if (matchEL.Currentset == 5)
            {
                matchEL.Teamaset5 = matchEL.Teamaset5 + 1;
            }

            UpdateMatch();
            CheckIfCanSet();

        }

        private void btnTeamAScoreMinus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblTeamAScore.Text) != 0)
            {
                if (matchEL.Currentset == 1)
                {
                    matchEL.Teamaset1 = matchEL.Teamaset1 - 1;
                }

                if (matchEL.Currentset == 2)
                {
                    matchEL.Teamaset2 = matchEL.Teamaset2 - 1;
                }

                if (matchEL.Currentset == 3)
                {
                    matchEL.Teamaset3 = matchEL.Teamaset3 - 1;
                }

                if (matchEL.Currentset == 4)
                {
                    matchEL.Teamaset4 = matchEL.Teamaset4 - 1;
                }

                if (matchEL.Currentset == 5)
                {
                    matchEL.Teamaset5 = matchEL.Teamaset5 - 1;
                }

                UpdateMatch();

                CheckIfCanSet();
            }
        }

        private void btnTeamBScoreAdd_Click(object sender, EventArgs e)
        {
            if (matchEL.Currentset == 1)
            {
                matchEL.Teambset1 = matchEL.Teambset1 + 1;
            }

            if (matchEL.Currentset == 2)
            {
                matchEL.Teambset2 = matchEL.Teambset2 + 1;
            }

            if (matchEL.Currentset == 3)
            {
                matchEL.Teambset3 = matchEL.Teambset3 + 1;
            }

            if (matchEL.Currentset == 4)
            {
                matchEL.Teambset4 = matchEL.Teambset4 + 1;
            }

            if (matchEL.Currentset == 5)
            {
                matchEL.Teambset5 = matchEL.Teambset5 + 1;
            }

            UpdateMatch();
            CheckIfCanSet();
        }

        private void btnTeamBScoreMinus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblTeamBScore.Text) != 0)
            {
                if (matchEL.Currentset == 1)
                {
                    matchEL.Teambset1 = matchEL.Teambset1 - 1;
                }

                if (matchEL.Currentset == 2)
                {
                    matchEL.Teambset2 = matchEL.Teambset2 - 1;
                }

                if (matchEL.Currentset == 3)
                {
                    matchEL.Teambset3 = matchEL.Teambset3 - 1;
                }

                if (matchEL.Currentset == 4)
                {
                    matchEL.Teambset4 = matchEL.Teambset4 - 1;
                }

                if (matchEL.Currentset == 5)
                {
                    matchEL.Teambset5 = matchEL.Teambset5 - 1;
                }

                UpdateMatch();
                CheckIfCanSet();
            }
        }

        private void btnTeamATimeOutAdd_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblTeamATimeOut.Text) != 2)
            {
                if (matchEL.Currentset == 1)
                {
                    matchEL.Teamatimeout1 = matchEL.Teamatimeout1 + 1;
                }

                if (matchEL.Currentset == 2)
                {
                    matchEL.Teamatimeout2 = matchEL.Teamatimeout2 + 1;
                }

                if (matchEL.Currentset == 3)
                {
                    matchEL.Teamatimeout3 = matchEL.Teamatimeout3 + 1;
                }

                if (matchEL.Currentset == 4)
                {
                    matchEL.Teamatimeout4 = matchEL.Teamatimeout4 + 1;
                }

                if (matchEL.Currentset == 5)
                {
                    matchEL.Teamatimeout5 = matchEL.Teamatimeout5 + 1;
                }

                UpdateMatch();
            }
        }

        private void btnTeamATimeOutMinus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblTeamATimeOut.Text) != 0)
            {
                if (matchEL.Currentset == 1)
                {
                    matchEL.Teamatimeout1 = matchEL.Teamatimeout1 - 1;
                }

                if (matchEL.Currentset == 2)
                {
                    matchEL.Teamatimeout2 = matchEL.Teamatimeout2 - 1;
                }

                if (matchEL.Currentset == 3)
                {
                    matchEL.Teamatimeout3 = matchEL.Teamatimeout3 - 1;
                }

                if (matchEL.Currentset == 4)
                {
                    matchEL.Teamatimeout4 = matchEL.Teamatimeout4 - 1;
                }

                if (matchEL.Currentset == 5)
                {
                    matchEL.Teamatimeout5 = matchEL.Teamatimeout5 - 1;
                }

                UpdateMatch();
            }
        }

        private void btnTeamBTimeOutAdd_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblTeamBTimeOut.Text) != 2)
            {
                if (matchEL.Currentset == 1)
                {
                    matchEL.Teambtimeout1 = matchEL.Teambtimeout1 + 1;
                }

                if (matchEL.Currentset == 2)
                {
                    matchEL.Teambtimeout2 = matchEL.Teambtimeout2 + 1;
                }

                if (matchEL.Currentset == 3)
                {
                    matchEL.Teambtimeout3 = matchEL.Teambtimeout3 + 1;
                }

                if (matchEL.Currentset == 4)
                {
                    matchEL.Teambtimeout4 = matchEL.Teambtimeout4 + 1;
                }

                if (matchEL.Currentset == 5)
                {
                    matchEL.Teambtimeout5 = matchEL.Teambtimeout5 + 1;
                }

                UpdateMatch();
            }
        }

        private void btnTeamBTimeOutMinus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblTeamBTimeOut.Text) != 0)
            {
                if (matchEL.Currentset == 1)
                {
                    matchEL.Teambtimeout1 = matchEL.Teambtimeout1 - 1;
                }

                if (matchEL.Currentset == 2)
                {
                    matchEL.Teambtimeout2 = matchEL.Teambtimeout2 - 1;
                }

                if (matchEL.Currentset == 3)
                {
                    matchEL.Teambtimeout3 = matchEL.Teambtimeout3 - 1;
                }

                if (matchEL.Currentset == 4)
                {
                    matchEL.Teambtimeout4 = matchEL.Teambtimeout4 - 1;
                }

                if (matchEL.Currentset == 5)
                {
                    matchEL.Teambtimeout5 = matchEL.Teambtimeout5 - 1;
                }

                UpdateMatch();
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(lblTeamAScore.Text) == 0 & Convert.ToInt32(lblTeamBScore.Text) == 0)
            {
                MessageBox.Show("Failed to end the set. Both team has no score.");
            }
            else
            {
                bool bol = false;
                if (matchEL.Currentset == 3 | matchEL.Currentset == 5)
                {
                    if (Convert.ToInt32(lblTeamAScore.Text) < 15 & Convert.ToInt32(lblTeamBScore.Text) < 15)
                    {
                        MessageBox.Show("Atleast one team should score 15 or more.");
                    }
                    else
                    {
                        bol = true;
                    }
                }

                if (matchEL.Currentset == 1 | matchEL.Currentset == 2 | matchEL.Currentset == 4)
                {
                    if (Convert.ToInt32(lblTeamAScore.Text) < 25 & Convert.ToInt32(lblTeamBScore.Text) < 25)
                    {
                        MessageBox.Show("Atleast one team should score 25 or more.");
                    }
                    else
                    {
                        bol = true;
                    }
                }


                if (bol)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure to end this set?", "Warning", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (matchEL.Currentset == 1)
                        {
                            if (matchEL.Teamaset1 > matchEL.Teambset1)
                            {
                                matchEL.Teamawonsets += 1;
                            }

                            if (matchEL.Teamaset1 < matchEL.Teambset1)
                            {
                                matchEL.Teambwonsets += 1;
                            }

                            if (matchEL.Teamaset1 == matchEL.Teambset1)
                            {
                                matchEL.Teamawonsets += 1;
                                matchEL.Teambwonsets += 1;
                            }
                        }

                        if (matchEL.Currentset == 2)
                        {
                            if (matchEL.Teamaset2 > matchEL.Teambset2)
                            {
                                matchEL.Teamawonsets += 1;
                            }

                            if (matchEL.Teamaset2 < matchEL.Teambset2)
                            {
                                matchEL.Teambwonsets += 1;
                            }

                            if (matchEL.Teamaset2 == matchEL.Teambset2)
                            {
                                matchEL.Teamawonsets += 1;
                                matchEL.Teambwonsets += 1;
                            }


                        }

                        if (matchEL.Currentset == 3)
                        {
                            if (matchEL.Teamaset3 > matchEL.Teambset3)
                            {
                                matchEL.Teamawonsets += 1;
                            }

                            if (matchEL.Teamaset3 < matchEL.Teambset3)
                            {
                                matchEL.Teambwonsets += 1;
                            }

                            if (matchEL.Teamaset3 == matchEL.Teambset3)
                            {
                                matchEL.Teamawonsets += 1;
                                matchEL.Teambwonsets += 1;
                            }
                        }

                        if (matchEL.Currentset == 4)
                        {
                            if (matchEL.Teamaset4 > matchEL.Teambset4)
                            {
                                matchEL.Teamawonsets += 1;
                            }

                            if (matchEL.Teamaset4 < matchEL.Teambset4)
                            {
                                matchEL.Teambwonsets += 1;
                            }

                            if (matchEL.Teamaset4 == matchEL.Teambset4)
                            {
                                matchEL.Teamawonsets += 1;
                                matchEL.Teambwonsets += 1;
                            }
                        }

                        if (matchEL.Currentset == 5)
                        {
                            if (matchEL.Teamaset5 > matchEL.Teambset5)
                            {
                                matchEL.Teamawonsets += 1;
                            }

                            if (matchEL.Teamaset5 < matchEL.Teambset5)
                            {
                                matchEL.Teambwonsets += 1;
                            }

                            if (matchEL.Teamaset5 == matchEL.Teambset5)
                            {
                                matchEL.Teamawonsets += 1;
                                matchEL.Teambwonsets += 1;
                            }
                        }


                        if (matchEL.Bestof == 3)
                        {
                            if (matchEL.Teamawonsets == 2 | matchEL.Teambwonsets == 2)
                            {
                            }
                            else
                            {
                                matchEL.Currentset = matchEL.Currentset + 1;
                            }
                        }

                        if (matchEL.Bestof == 5)
                        {
                            if (matchEL.Teamawonsets == 3 | matchEL.Teambwonsets == 3)
                            {
                            }
                            else
                            {
                                matchEL.Currentset = matchEL.Currentset + 1;
                            }
                        }


                        UpdateMatch();
                        CheckIfCanSet();
                        CheckIfCanEndMatch();

                    }
                }
            }


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to reset this match?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ResetMatch();
            }
        }

        private void btnEndMatch_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to save this match?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (UpdateMatch())
                {
                    matchEL.Matchsaveddatetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    matchBL.Insert(matchEL);
                    ShowAddMinusButtons(false);
                    ResetMatch();
                    MessageBox.Show("Match information is saved to the database.");
                }
            }
        }
    }
}
