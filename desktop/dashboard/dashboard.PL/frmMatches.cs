using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboard.PL
{
    public partial class frmMatches : Form
    {
        Thread delayedCalculationThreadDGV;
        int delay = 0;

        EL.Matches matchEL = new EL.Matches();
        BL.Matches matchBL = new BL.Matches();


        public frmMatches()
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

        public void CalculateAfterStopTypingDGV()
        {
            delay += 150;
            if (delayedCalculationThreadDGV != null && delayedCalculationThreadDGV.IsAlive)
                return;

            delayedCalculationThreadDGV = new Thread(() =>
            {
                while (delay >= 150)
                {
                    delay = delay - 150;
                    try
                    {
                        Thread.Sleep(150);
                    }
                    catch (Exception) { }
                }
                Invoke(new Action(() =>
                {
                    PopulateDGV();
                }));
            });

            delayedCalculationThreadDGV.Start();
        }

        public void ManageDGV()
        {
            PopulateDGV();
            methods.DGVTheme(dgv);
            methods.DGVRenameColumns(dgv, "matchid", "Match Number", "Team A Name", "Team B Name", "Match Date", "Match Time", "Date modified");
            methods.DGVHiddenColumns(dgv, "matchid");
            methods.DGVBUTTONView(dgv);
        }

        private void PopulateDGV()
        {
            var dt = matchBL.List(txtSearch.Text);
            methods.LoadDGV(dgv, dt);
        }

        private void ShowForm(bool bol)
        {
            pnl1.Visible = bol;
            pnl2.Visible = bol;
            pnl3.Visible = bol;
            btnBack.Visible = bol;
            btnDelete.Visible = bol;
            pnlMain.Visible = !bol;
        }

        private void frmMatches_Load(object sender, EventArgs e)
        {
            ManageDGV();
            ShowForm(false);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CalculateAfterStopTypingDGV();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
                matchEL.Matchid = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["matchid"].Value);

            if (e.ColumnIndex == 0)
            {
                matchEL = matchBL.Select(matchEL);
                lblBeastOf.Text = matchEL.Bestof.ToString();
                lblMatchNumber.Text = matchEL.Matchnumber;
                lblReferee.Text = matchEL.Refereename;
                lblScorer.Text = matchEL.Scorername;
                lblLineJudges1.Text = matchEL.Linejudges1name;
                lblLineJudges2.Text = matchEL.Linejudges2name;
                lblLineJudges3.Text = matchEL.Linejudges3name;
                lblLineJudges4.Text = matchEL.Linejudges4name;
                lblDivision.Text = matchEL.Division;
                lblMatchDate.Text = matchEL.Matchdate;
                lblMatchTime.Text = matchEL.Matchtime;
                lblDateSaved.Text = matchEL.Matchsaveddatetime;
                lblTeamAName.Text = matchEL.Teamaname;
                lblTeamACoach.Text = matchEL.Teamacoach;
                lblTeamASet1.Text = matchEL.Teamaset1.ToString();
                lblTeamASet2.Text = matchEL.Teamaset2.ToString();
                lblTeamASet3.Text = matchEL.Teamaset3.ToString();
                lblTeamASet4.Text = matchEL.Teamaset4.ToString();
                lblTeamASet5.Text = matchEL.Teamaset5.ToString();
                lblTeamATimeout1.Text = matchEL.Teamatimeout1.ToString();
                lblTeamATimeout2.Text = matchEL.Teamatimeout2.ToString();
                lblTeamATimeout3.Text = matchEL.Teamatimeout3.ToString();
                lblTeamATimeout4.Text = matchEL.Teamatimeout4.ToString();
                lblTeamATimeout5.Text = matchEL.Teamatimeout5.ToString();
                lblTeamAResult.Text = matchEL.Teamaresult;
                lblTeamBName.Text = matchEL.Teambname;
                lblTeamBCoach.Text = matchEL.Teambcoach;
                lblTeamBSet1.Text = matchEL.Teambset1.ToString();
                lblTeamBSet2.Text = matchEL.Teambset2.ToString();
                lblTeamBSet3.Text = matchEL.Teambset3.ToString();
                lblTeamBSet4.Text = matchEL.Teambset4.ToString();
                lblTeamBSet5.Text = matchEL.Teambset5.ToString();
                lblTeamBTimeout1.Text = matchEL.Teambtimeout1.ToString();
                lblTeamBTimeout2.Text = matchEL.Teambtimeout2.ToString();
                lblTeamBTimeout3.Text = matchEL.Teambtimeout3.ToString();
                lblTeamBTimeout4.Text = matchEL.Teambtimeout4.ToString();
                lblTeamBTimeout5.Text = matchEL.Teambtimeout5.ToString();
                lblTeamBResult.Text = matchEL.Teambresult;



                ShowForm(true);
                


            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowForm(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete this match?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (matchBL.Delete(matchEL))
                {
                    MessageBox.Show("Deleted!");
                    ShowForm(false);
                    CalculateAfterStopTypingDGV();
                }
            }
        }
    }
}
