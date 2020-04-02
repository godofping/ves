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

        private void CalculateAfterStopTypingDGV()
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

        private void ManageDGV()
        {
            PopulateDGV();
            methods.DGVTheme(dgv);
            methods.DGVRenameColumns(dgv, "matchid", "Match Number", "Team A Name", "Team B Name", "Match Date", "Match Time", "Date Saved");
            methods.DGVHiddenColumns(dgv, "matchid");
            methods.DGVBUTTONView(dgv);
        }

        private void PopulateDGV()
        {
            var dt = matchBL.List(txtSearch.Text);
            methods.LoadDGV(dgv, dt);
        }

        private void frmMatches_Load(object sender, EventArgs e)
        {
            ManageDGV();
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
                //var frm = new PL.Registrations.frmPlantCRUD("VIEW", plantEL, this, plantcategoryEL);
                //frm.ShowDialog();

            }

        }
    }
}
