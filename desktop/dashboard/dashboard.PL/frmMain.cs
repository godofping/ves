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
    public partial class frmMain : Form
    {
        frmControlPanel frmControlPanel = new frmControlPanel();
        frmMatches frmMatches = new frmMatches();
        frmAnnouncement frmAnnouncement = new frmAnnouncement();

        public frmMain()
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

        private void ChangePanelLocation(Panel x, Button y)
        {
            x.Height = y.Height;
            x.Top = y.Top;
        }



        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnControlPanel_Click(object sender, EventArgs e)
        {
            var pleaseWait = new frmLoading();
            pleaseWait.Show();
            Application.DoEvents();

            ChangePanelLocation(pnlActiveButton, btnControlPanel);
            methods.ChangePanelDisplay(frmControlPanel, pnlMain);
            frmControlPanel.GetMatchInformation();

            pleaseWait.Dispose();
        }

        private void btnMatches_Click(object sender, EventArgs e)
        {
            var pleaseWait = new frmLoading();
            pleaseWait.Show();
            Application.DoEvents();

            ChangePanelLocation(pnlActiveButton, btnMatches);
            methods.ChangePanelDisplay(frmMatches, pnlMain);
            frmMatches.CalculateAfterStopTypingDGV();
            pleaseWait.Dispose();
        }

        private void btnAnnouncement_Click(object sender, EventArgs e)
        {
            var pleaseWait = new frmLoading();
            pleaseWait.Show();
            Application.DoEvents();

            ChangePanelLocation(pnlActiveButton, btnAnnouncement);
            methods.ChangePanelDisplay(frmAnnouncement, pnlMain);

            frmAnnouncement.GetAnnouncement();

            pleaseWait.Dispose();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var pleaseWait = new frmLoading();
            pleaseWait.Show();
            Application.DoEvents();

            ChangePanelLocation(pnlActiveButton, btnControlPanel);
            methods.ChangePanelDisplay(frmControlPanel, pnlMain);

            pleaseWait.Dispose();
        }
    }
}
