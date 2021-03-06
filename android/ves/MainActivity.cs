﻿using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Content;
using Android;

namespace ves
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        readonly string[] permissionGroup =
        {
            Manifest.Permission.ReadExternalStorage,
            Manifest.Permission.WriteExternalStorage,
            Manifest.Permission.Camera
        };

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            RequestPermissions(permissionGroup, 0);



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
            Intent cp = new Intent(this, typeof(ControlPanelActivity));
            StartActivity(cp);
        }
        private void btnMatches_Click(object sender, EventArgs e)
        {
            Intent cp = new Intent(this, typeof(MatchesActivity));
            StartActivity(cp);
        }

        private void btnAnnouncement_Click(object sender, EventArgs e)
        {
            Intent cp = new Intent(this, typeof(AnnouncementActivity));
            StartActivity(cp);
        }

        
    }
}