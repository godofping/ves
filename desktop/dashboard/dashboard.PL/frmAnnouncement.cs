using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        int announcementtype = 0;

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

        public class BufferedPanel : Panel
        {
            public BufferedPanel()
            {
                DoubleBuffered = true;
            }
        }

        private void RadioButtonActions()
        {

            if (announcementtype == 1)
            {


                txtMessage.Enabled = true;

                txtFullscreenMessage.Enabled = false;

                pbImage.Enabled = false;
                btnUploadImage.Enabled = false;

            }
            else if (announcementtype == 2)
            {

                txtMessage.Enabled = false;

                txtFullscreenMessage.Enabled = true;

                pbImage.Enabled = false;
                btnUploadImage.Enabled = false;

            }
            else if (announcementtype == 3)
            {



                txtMessage.Enabled = false;

                txtFullscreenMessage.Enabled = false;

                pbImage.Enabled = true;
                btnUploadImage.Enabled = true;
            }


        }

        public void GetAnnouncement()
        {
            var dt = announcementBL.List();
            txtMessage.Text = dt.Rows[0]["announcement"].ToString();
            txtFullscreenMessage.Text  = dt.Rows[0]["announcementtextfullscreen"].ToString();

            announcementtype = Convert.ToInt32(dt.Rows[0]["announcementtype"]);

            if (dt.Rows[0]["announcementimage"].ToString().Length > 0)
            {
                byte[] bytes = Convert.FromBase64String(dt.Rows[0]["announcementimage"].ToString());

                Image image;
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    image = Image.FromStream(ms);
                }

                pbImage.Image = image;
            }


            
            if (announcementtype == 1)
            {
                rb1.Checked = true;
                rb2.Checked = false;
                rb3.Checked = false;
            }
            else if (announcementtype == 2)
            {
                rb1.Checked = false;
                rb2.Checked = true;
                rb3.Checked = false;
            }
            else if (announcementtype == 3)
            {
                rb1.Checked = false;
                rb2.Checked = false;
                rb3.Checked = true;
            }


        }

        private void frmAnnouncement_Load(object sender, EventArgs e)
        {
            GetAnnouncement();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            announcementEL.Announcement = txtMessage.Text;
            announcementEL.Announcementtextfullscreen = txtFullscreenMessage.Text;
            announcementEL.Announcementtype = announcementtype;
            announcementEL.Announcementimage = Convert.ToBase64String(methods.ConvertImageToByteArray(pbImage.Image));

            if (announcementBL.Update(announcementEL))
            {
                MessageBox.Show("Saved!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            announcementtype = 1;
            RadioButtonActions();
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            announcementtype = 2;
            RadioButtonActions();
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            announcementtype = 3;
            RadioButtonActions();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                announcementEL.Announcementimage = open.FileName;
                pbImage.Image = new Bitmap(announcementEL.Announcementimage);
            }
        }
    }
}
