using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace ves
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {


        EL.Announcements announcementEL = new EL.Announcements();
        DL.Announcements announcementDL = new DL.Announcements();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var btnControlPanel = FindViewById<Button>(Resource.Id.btnControlPanel);
            var btnMatches = FindViewById<Button>(Resource.Id.btnMatches);
            var btnAnnouncement = FindViewById<Button>(Resource.Id.btnAnnouncement);



            btnControlPanel.Click += btnControlPanel_Click;
            btnMatches.Click += btnMatches_Click;
            btnAnnouncement.Click += btnAnnouncement_Click;


        }

        private void btnControlPanel_Click(object sender, EventArgs e)
        {

        }
        private void btnMatches_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAnnouncement_Click(object sender, EventArgs e)
        {
            var dt = announcementDL.List();
            Toast.MakeText(this, dt.Rows[0]["announcement"].ToString(), ToastLength.Short).Show();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}