using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ves
{
    [Activity(Label = "AnnouncementActivity")]
    public class AnnouncementActivity : Activity
    {
        EL.Announcements announcementEL = new EL.Announcements();
        DL.Announcements announcementDL = new DL.Announcements();

        Button btnUpdateAnnouncement;
        EditText etMessageAnnouncement;


         private void initialize()
        {
            etMessageAnnouncement = (EditText)FindViewById(Resource.Id.etMessageAnnouncement);
            btnUpdateAnnouncement = (Button)FindViewById(Resource.Id.btnUpdateAnnouncement);
        }

        private void GetData()
        {
            var dt = announcementDL.List();
            etMessageAnnouncement.Text = dt.Rows[0]["announcement"].ToString();
        }


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            

            // Create your application here
            SetContentView(Resource.Layout.activity_announcement);
            initialize();

            GetData();

            btnUpdateAnnouncement.Click += btnUpdateAnnouncement_Click;
        }

        private void btnUpdateAnnouncement_Click(object sender, EventArgs e)
        {

            announcementEL.Announcement = etMessageAnnouncement.Text;
            if (announcementDL.Update(announcementEL))
            {
                Toast.MakeText(this, "Updated!", ToastLength.Short).Show();
            }
            else
            {
                Toast.MakeText(this, "Failed!", ToastLength.Short).Show();
            }
        }
    }
}