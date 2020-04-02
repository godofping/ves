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
    public partial class frmAnnouncement : Form
    {
        EL.Announcements announcementEL = new EL.Announcements();
        BL.Announcements announcementBL = new BL.Announcements();

        public frmAnnouncement()
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

        public void GetAnnouncement()
        {
            var dt = announcementBL.List();
            txtMessage.Text = dt.Rows[0]["announcement"].ToString();
        }

        private void frmAnnouncement_Load(object sender, EventArgs e)
        {
            GetAnnouncement();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            announcementEL.Announcement = txtMessage.Text;

            if (announcementBL.Update(announcementEL))
            {
                MessageBox.Show("Saved!");
            }
            else
            {
                MessageBox.Show("Error!");
            }

            
        }

        
    }
}
