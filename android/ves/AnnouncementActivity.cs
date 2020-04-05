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

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_announcement);

           var btnAnnouncement = FindViewById<EditText>(Resource.Id.actions);


        }
    }
}