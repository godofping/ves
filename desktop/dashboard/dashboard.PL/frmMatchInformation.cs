using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboard.PL
{
    public partial class frmMatchInformation : Form
    {
        EL.Matches matchEL;
        frmControlPanel frmControlPanel;
        public frmMatchInformation(EL.Matches _matchEL, frmControlPanel _frmControlPanel)
        {
            InitializeComponent();
            matchEL = _matchEL;
            frmControlPanel = _frmControlPanel;
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


        private void GetInformation()
        {
            cbBestOf.SelectedIndex = cbBestOf.FindStringExact(matchEL.Bestof.ToString());
            txtMatchNumber.Text = matchEL.Matchnumber;
            txtReferee.Text = matchEL.Refereename;
            txtScorer.Text = matchEL.Scorername;
            txtLineJudges1.Text = matchEL.Linejudges1name;
            txtLineJudges2.Text = matchEL.Linejudges2name;
            txtLineJudges3.Text = matchEL.Linejudges3name;
            txtLineJudges4.Text = matchEL.Linejudges4name;
            txtDivision.Text = matchEL.Division;
            txtDate.Text = matchEL.Matchdate;
            txtTime.Text = matchEL.Matchtime;
            txtTeamAName.Text = matchEL.Teamaname;
            txtTeamACoach.Text = matchEL.Teamacoach;
            txtTeamBName.Text = matchEL.Teambname;
            txtTeamBCoach.Text = matchEL.Teambcoach;
            lblTeamASet1.Text = matchEL.Teamaset1.ToString();
            lblTeamASet2.Text = matchEL.Teamaset2.ToString();
            lblTeamASet3.Text = matchEL.Teamaset3.ToString();
            lblTeamASet4.Text = matchEL.Teamaset4.ToString();
            lblTeamASet5.Text = matchEL.Teamaset5.ToString();
            lblTeamATimeOut1.Text = matchEL.Teamatimeout1.ToString();
            lblTeamATimeOut2.Text = matchEL.Teamatimeout2.ToString();
            lblTeamATimeOut3.Text = matchEL.Teamatimeout3.ToString();
            lblTeamATimeOut4.Text = matchEL.Teamatimeout4.ToString();
            lblTeamATimeOut5.Text = matchEL.Teamatimeout5.ToString();
            lblTeamAResult.Text = matchEL.Teamaresult;
            lblTeamBSet1.Text = matchEL.Teambset1.ToString();
            lblTeamBSet2.Text = matchEL.Teambset2.ToString();
            lblTeamBSet3.Text = matchEL.Teambset3.ToString();
            lblTeamBSet4.Text = matchEL.Teambset4.ToString();
            lblTeamBSet5.Text = matchEL.Teambset5.ToString();
            lblTeamBTimeOut1.Text = matchEL.Teambtimeout1.ToString();
            lblTeamBTimeOut2.Text = matchEL.Teambtimeout2.ToString();
            lblTeamBTimeOut3.Text = matchEL.Teambtimeout3.ToString();
            lblTeamBTimeOut4.Text = matchEL.Teambtimeout4.ToString();
            lblTeamBTimeOut5.Text = matchEL.Teambtimeout5.ToString();
            lblTeamBResult.Text = matchEL.Teambresult;

        }

        private void ShowBestOf5(bool bol)
        {
            lblSet4A.Visible = bol;
            lblSet4B.Visible = bol;
            lblSet5A.Visible = bol;
            lblSet5B.Visible = bol;
            lblTimeout4A.Visible = bol;
            lblTimeout4B.Visible = bol;
            lblTimeout5A.Visible = bol;
            lblTimeout5B.Visible = bol;
            lblTeamASet4.Visible = bol;
            lblTeamBSet4.Visible = bol;
            lblTeamASet5.Visible = bol;
            lblTeamBSet5.Visible = bol;
            lblTeamATimeOut4.Visible = bol;
            lblTeamBTimeOut4.Visible = bol;
            lblTeamATimeOut5.Visible = bol;
            lblTeamBTimeOut5.Visible = bol;
        }

        private void frmMatchInformation_Load(object sender, EventArgs e)
        {
            GetInformation();
            if (cbBestOf.Text.Equals("3"))
            {
                ShowBestOf5(false);
            }

            if (cbBestOf.Text.Equals("5"))
            {
                ShowBestOf5(true);
            }

            if (matchEL.Currentset == 1 & matchEL.Teamaset1 == 0 & matchEL.Teambset1 == 0 & matchEL.Teamatimeout1 == 0 & matchEL.Teambtimeout1 == 0)
            {
                cbBestOf.Enabled = true;
            }
            else
            {
                cbBestOf.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            matchEL.Bestof = Convert.ToInt32(cbBestOf.Text);
            matchEL.Matchnumber = txtMatchNumber.Text;
            matchEL.Refereename = txtReferee.Text;
            matchEL.Scorername = txtScorer.Text;
            matchEL.Linejudges1name = txtLineJudges1.Text;
            matchEL.Linejudges2name = txtLineJudges2.Text;
            matchEL.Linejudges3name = txtLineJudges3.Text;
            matchEL.Linejudges4name = txtLineJudges4.Text;
            matchEL.Division = txtDivision.Text;
            matchEL.Matchdate = txtDate.Text;
            matchEL.Matchtime = txtTime.Text;
            matchEL.Teamaname = txtTeamAName.Text;
            matchEL.Teamacoach = txtTeamACoach.Text;
            matchEL.Teambname = txtTeamBName.Text;
            matchEL.Teambcoach = txtTeamBCoach.Text;
            if (frmControlPanel.UpdateMatch())
                this.Close();
            else
                MessageBox.Show("Error!");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbBestOf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBestOf.Text.Equals("3"))
            {
                ShowBestOf5(false);
            }

            if (cbBestOf.Text.Equals("5"))
            {
                ShowBestOf5(true);
            }
        }
    }
}
