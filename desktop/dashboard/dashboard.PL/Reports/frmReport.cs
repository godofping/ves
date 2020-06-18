using System;
using System.Windows.Forms;

namespace dashboard.PL.Reports
{
    public partial class frmReport : Form
    {
        EL.Matches matchEL;
        BL.Matches matchBL = new BL.Matches();

        public frmReport(EL.Matches _matchEL)
        {
            InitializeComponent();
            matchEL = _matchEL;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {



            rptMatch rptMatch = new rptMatch();

            rptMatch.Database.Tables["matches"].SetDataSource(matchBL.ListAll(matchEL.Matchid));

            crv.ReportSource = null;
            crv.ReportSource = rptMatch;
            crv.Refresh();

        }
    }
}
