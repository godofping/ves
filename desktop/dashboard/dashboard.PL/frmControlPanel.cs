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

        private void frmControlPanel_Load(object sender, EventArgs e)
        {

            GetMatchInformation();

            if (matchEL.Currentset == 5)
            {
                btnSet.Enabled = false;
            }
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

        private void btnMatchInfo_Click(object sender, EventArgs e)
        {
            frmMatchInformation frmMatchInformation = new frmMatchInformation(matchEL);
            frmMatchInformation.ShowDialog();
        }

        private void btnTeamAScoreAdd_Click(object sender, EventArgs e)
        {
            if (matchEL.Currentset == 1)
            {
                matchEL.Teamaset1 = matchEL.Teamaset1 + 1;
                if (matchBL.Update(matchEL))
                {
                    lblTeamAScore.Text = matchEL.Teamaset1.ToString();
                }
            }

            if (matchEL.Currentset == 2)
            {
                matchEL.Teamaset2 = matchEL.Teamaset2 + 1;
                if (matchBL.Update(matchEL))
                {
                    lblTeamAScore.Text = matchEL.Teamaset2.ToString();
                }
            }

            if (matchEL.Currentset == 3)
            {
                matchEL.Teamaset3 = matchEL.Teamaset3 + 1;
                if (matchBL.Update(matchEL))
                {
                    lblTeamAScore.Text = matchEL.Teamaset3.ToString();
                }
            }

            if (matchEL.Currentset == 4)
            {
                matchEL.Teamaset4 = matchEL.Teamaset4 + 1;
                if (matchBL.Update(matchEL))
                {
                    lblTeamAScore.Text = matchEL.Teamaset4.ToString();
                }
            }

            if (matchEL.Currentset == 5)
            {
                matchEL.Teamaset5 = matchEL.Teamaset5 + 1;
                if (matchBL.Update(matchEL))
                {
                    lblTeamAScore.Text = matchEL.Teamaset5.ToString();
                }
            }

        }

        private void btnTeamAScoreMinus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblTeamAScore.Text) != 0)
            {
                if (matchEL.Currentset == 1)
                {
                    matchEL.Teamaset1 = matchEL.Teamaset1 - 1;
                    if (matchBL.Update(matchEL))
                    {
                        lblTeamAScore.Text = matchEL.Teamaset1.ToString();
                    }
                }

                if (matchEL.Currentset == 2)
                {
                    matchEL.Teamaset2 = matchEL.Teamaset2 - 1;
                    if (matchBL.Update(matchEL))
                    {
                        lblTeamAScore.Text = matchEL.Teamaset2.ToString();
                    }
                }

                if (matchEL.Currentset == 3)
                {
                    matchEL.Teamaset3 = matchEL.Teamaset3 - 1;
                    if (matchBL.Update(matchEL))
                    {
                        lblTeamAScore.Text = matchEL.Teamaset3.ToString();
                    }
                }

                if (matchEL.Currentset == 4)
                {
                    matchEL.Teamaset4 = matchEL.Teamaset4 - 1;
                    if (matchBL.Update(matchEL))
                    {
                        lblTeamAScore.Text = matchEL.Teamaset4.ToString();
                    }
                }

                if (matchEL.Currentset == 5)
                {
                    matchEL.Teamaset5 = matchEL.Teamaset5 - 1;
                    if (matchBL.Update(matchEL))
                    {
                        lblTeamAScore.Text = matchEL.Teamaset5.ToString();
                    }
                }
            }
        }

        private void btnTeamBScoreAdd_Click(object sender, EventArgs e)
        {
            if (matchEL.Currentset == 1)
            {
                matchEL.Teambset1 = matchEL.Teambset1 + 1;
                if (matchBL.Update(matchEL))
                {
                    lblTeamBScore.Text = matchEL.Teambset1.ToString();
                }
            }

            if (matchEL.Currentset == 2)
            {
                matchEL.Teambset2 = matchEL.Teambset2 + 1;
                if (matchBL.Update(matchEL))
                {
                    lblTeamBScore.Text = matchEL.Teambset2.ToString();
                }
            }

            if (matchEL.Currentset == 3)
            {
                matchEL.Teambset3 = matchEL.Teambset3 + 1;
                if (matchBL.Update(matchEL))
                {
                    lblTeamBScore.Text = matchEL.Teambset3.ToString();
                }
            }

            if (matchEL.Currentset == 4)
            {
                matchEL.Teambset4 = matchEL.Teambset4 + 1;
                if (matchBL.Update(matchEL))
                {
                    lblTeamBScore.Text = matchEL.Teambset4.ToString();
                }
            }

            if (matchEL.Currentset == 5)
            {
                matchEL.Teambset5 = matchEL.Teambset5 + 1;
                if (matchBL.Update(matchEL))
                {
                    lblTeamBScore.Text = matchEL.Teambset5.ToString();
                }
            }
        }

        private void btnTeamBScoreMinus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblTeamBScore.Text) != 0)
            {
                if (matchEL.Currentset == 1)
                {
                    matchEL.Teambset1 = matchEL.Teambset1 - 1;
                    if (matchBL.Update(matchEL))
                    {
                        lblTeamBScore.Text = matchEL.Teambset1.ToString();
                    }
                }

                if (matchEL.Currentset == 2)
                {
                    matchEL.Teambset2 = matchEL.Teambset2 - 1;
                    if (matchBL.Update(matchEL))
                    {
                        lblTeamBScore.Text = matchEL.Teambset2.ToString();
                    }
                }

                if (matchEL.Currentset == 3)
                {
                    matchEL.Teambset3 = matchEL.Teambset3 - 1;
                    if (matchBL.Update(matchEL))
                    {
                        lblTeamBScore.Text = matchEL.Teambset3.ToString();
                    }
                }

                if (matchEL.Currentset == 4)
                {
                    matchEL.Teambset4 = matchEL.Teambset4 - 1;
                    if (matchBL.Update(matchEL))
                    {
                        lblTeamBScore.Text = matchEL.Teambset4.ToString();
                    }
                }

                if (matchEL.Currentset == 5)
                {
                    matchEL.Teambset5 = matchEL.Teambset5 - 1;
                    if (matchBL.Update(matchEL))
                    {
                        lblTeamBScore.Text = matchEL.Teambset5.ToString();
                    }
                }
            }
        }

        private void btnTeamATimeOutAdd_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblTeamATimeOut.Text) != 3)
            {
                if (matchEL.Currentset == 1)
                {
                    matchEL.Teamatimeout1 = matchEL.Teamatimeout1 + 1;
                    if (matchBL.Update(matchEL))
                    {
                        lblTeamATimeOut.Text = matchEL.Teamatimeout1.ToString();
                    }
                }

                if (matchEL.Currentset == 2)
                {
                    matchEL.Teamatimeout2 = matchEL.Teamatimeout2 + 1;
                    if (matchBL.Update(matchEL))
                    {
                        lblTeamATimeOut.Text = matchEL.Teamatimeout2.ToString();
                    }
                }

                if (matchEL.Currentset == 3)
                {
                    matchEL.Teamatimeout3 = matchEL.Teamatimeout3 + 1;
                    if (matchBL.Update(matchEL))
                    {
                        lblTeamATimeOut.Text = matchEL.Teamatimeout3.ToString();
                    }
                }

                if (matchEL.Currentset == 4)
                {
                    matchEL.Teamatimeout4 = matchEL.Teamatimeout4 + 1;
                    if (matchBL.Update(matchEL))
                    {
                        lblTeamATimeOut.Text = matchEL.Teamatimeout4.ToString();
                    }
                }

                if (matchEL.Currentset == 5)
                {
                    matchEL.Teamatimeout5 = matchEL.Teamatimeout5 + 1;
                    if (matchBL.Update(matchEL))
                    {
                        lblTeamATimeOut.Text = matchEL.Teamatimeout5.ToString();
                    }
                }
            }
        }

        private void btnTeamATimeOutMinus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblTeamATimeOut.Text) != 0)
            {
                if (matchEL.Currentset == 1)
                {
                    matchEL.Teamatimeout1 = matchEL.Teamatimeout1 - 1;
                    if (matchBL.Update(matchEL))
                    {
                        lblTeamATimeOut.Text = matchEL.Teamatimeout1.ToString();
                    }
                }

                if (matchEL.Currentset == 2)
                {
                    matchEL.Teamatimeout2 = matchEL.Teamatimeout2 - 1;
                    if (matchBL.Update(matchEL))
                    {
                        lblTeamATimeOut.Text = matchEL.Teamatimeout2.ToString();
                    }
                }

                if (matchEL.Currentset == 3)
                {
                    matchEL.Teamatimeout3 = matchEL.Teamatimeout3 - 1;
                    if (matchBL.Update(matchEL))
                    {
                        lblTeamATimeOut.Text = matchEL.Teamatimeout3.ToString();
                    }
                }

                if (matchEL.Currentset == 4)
                {
                    matchEL.Teamatimeout4 = matchEL.Teamatimeout4 - 1;
                    if (matchBL.Update(matchEL))
                    {
                        lblTeamATimeOut.Text = matchEL.Teamatimeout4.ToString();
                    }
                }

                if (matchEL.Currentset == 5)
                {
                    matchEL.Teamatimeout5 = matchEL.Teamatimeout5 - 1;
                    if (matchBL.Update(matchEL))
                    {
                        lblTeamATimeOut.Text = matchEL.Teamatimeout5.ToString();
                    }
                }
            }
        }

        private void btnTeamBTimeOutAdd_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblTeamBTimeOut.Text) != 3)
            {
                if (matchEL.Currentset == 1)
                {
                    matchEL.Teambtimeout1 = matchEL.Teambtimeout1 + 1;
                    if (matchBL.Update(matchEL))
                    {
                        lblTeamBTimeOut.Text = matchEL.Teambtimeout1.ToString();
                    }
                }

                if (matchEL.Currentset == 2)
                {
                    matchEL.Teambtimeout2 = matchEL.Teambtimeout2 + 1;
                    if (matchBL.Update(matchEL))
                    {
                        lblTeamBTimeOut.Text = matchEL.Teambtimeout2.ToString();
                    }
                }

                if (matchEL.Currentset == 3)
                {
                    matchEL.Teambtimeout3 = matchEL.Teambtimeout3 + 1;
                    if (matchBL.Update(matchEL))
                    {
                        lblTeamBTimeOut.Text = matchEL.Teambtimeout3.ToString();
                    }
                }

                if (matchEL.Currentset == 4)
                {
                    matchEL.Teambtimeout4 = matchEL.Teambtimeout4 + 1;
                    if (matchBL.Update(matchEL))
                    {
                        lblTeamBTimeOut.Text = matchEL.Teambtimeout4.ToString();
                    }
                }

                if (matchEL.Currentset == 5)
                {
                    matchEL.Teambtimeout5 = matchEL.Teambtimeout5 + 1;
                    if (matchBL.Update(matchEL))
                    {
                        lblTeamBTimeOut.Text = matchEL.Teambtimeout5.ToString();
                    }
                }
            }
        }

        private void btnTeamBTimeOutMinus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblTeamBTimeOut.Text) != 0)
            {
                if (matchEL.Currentset == 1)
                {
                    matchEL.Teambtimeout1 = matchEL.Teambtimeout1 - 1;
                    if (matchBL.Update(matchEL))
                    {
                        lblTeamBTimeOut.Text = matchEL.Teambtimeout1.ToString();
                    }
                }

                if (matchEL.Currentset == 2)
                {
                    matchEL.Teambtimeout2 = matchEL.Teambtimeout2 - 1;
                    if (matchBL.Update(matchEL))
                    {
                        lblTeamBTimeOut.Text = matchEL.Teambtimeout2.ToString();
                    }
                }

                if (matchEL.Currentset == 3)
                {
                    matchEL.Teambtimeout3 = matchEL.Teambtimeout3 - 1;
                    if (matchBL.Update(matchEL))
                    {
                        lblTeamBTimeOut.Text = matchEL.Teambtimeout3.ToString();
                    }
                }

                if (matchEL.Currentset == 4)
                {
                    matchEL.Teambtimeout4 = matchEL.Teambtimeout4 - 1;
                    if (matchBL.Update(matchEL))
                    {
                        lblTeamBTimeOut.Text = matchEL.Teambtimeout4.ToString();
                    }
                }

                if (matchEL.Currentset == 5)
                {
                    matchEL.Teambtimeout5 = matchEL.Teambtimeout5 - 1;
                    if (matchBL.Update(matchEL))
                    {
                        lblTeamBTimeOut.Text = matchEL.Teambtimeout5.ToString();
                    }
                }
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblSetNumber.Text) != 5)
            {
                matchEL.Currentset = matchEL.Currentset + 1;
                if (matchBL.Update(matchEL))
                {
                    GetMatchInformation();
                }

                if (matchEL.Currentset == 5)
                {
                    btnSet.Enabled = false;
                }
            }

        }
    }
}
