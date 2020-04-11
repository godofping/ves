using Android;
using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Widget;
using Plugin.Media;
using System;
using System.IO;

namespace ves
{
    [Activity(Label = "AnnouncementActivity")]
    public class AnnouncementActivity : Activity
    {
        EL.Announcements announcementEL = new EL.Announcements();
        DL.Announcements announcementDL = new DL.Announcements();

        Button btnUpdateAnnouncement, btnUploadAnnouncement;
        EditText etMessageAnnouncement, etFullscreenMessageAnnouncement;
        RadioButton rb1, rb2, rb3;
        ImageView ivAnnouncement;

        int announcementtype = 0;
        string str = "";



        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Android.Content.PM.Permission[] grantResults)
        {
            Plugin.Permissions.PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        private void initialize()
        {
            etMessageAnnouncement = (EditText)FindViewById(Resource.Id.etMessageAnnouncement);
            etFullscreenMessageAnnouncement = (EditText)FindViewById(Resource.Id.etFullscreenMessageAnnouncement);
            btnUpdateAnnouncement = (Button)FindViewById(Resource.Id.btnUpdateAnnouncement);
            btnUploadAnnouncement = (Button)FindViewById(Resource.Id.btnUploadAnnouncement);
            rb1 = (RadioButton)FindViewById(Resource.Id.rb1);
            rb2 = (RadioButton)FindViewById(Resource.Id.rb2);
            rb3 = (RadioButton)FindViewById(Resource.Id.rb3);
            ivAnnouncement = (ImageView)FindViewById(Resource.Id.ivAnnouncement);
        }



        private void GetAnnouncement()
        {
            var dt = announcementDL.List();
            etMessageAnnouncement.Text = dt.Rows[0]["announcement"].ToString();
            etFullscreenMessageAnnouncement.Text = dt.Rows[0]["announcementtextfullscreen"].ToString();

            announcementtype = Convert.ToInt32(dt.Rows[0]["announcementtype"]);

            if (dt.Rows[0]["announcementimage"].ToString().Length > 0)
            {
                byte[] bytes = Convert.FromBase64String(dt.Rows[0]["announcementimage"].ToString());



                ivAnnouncement.SetImageBitmap(BitmapFactory.DecodeByteArray(bytes, 0, bytes.Length));


                str = dt.Rows[0]["announcementimage"].ToString();


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

            RadioButtonActions();

        }

        private void RadioButtonActions()
        {

            if (rb1.Checked == true)
            {
                announcementtype = 1;
                etMessageAnnouncement.Enabled = true;

                etFullscreenMessageAnnouncement.Enabled = false;

                ivAnnouncement.Enabled = false;
                btnUploadAnnouncement.Enabled = false;

            }
            else if (rb2.Checked == true)
            {
                announcementtype = 2;
                etMessageAnnouncement.Enabled = false;

                etFullscreenMessageAnnouncement.Enabled = true;

                ivAnnouncement.Enabled = false;
                btnUploadAnnouncement.Enabled = false;

            }
            else if (rb3.Checked == true)
            {


                announcementtype = 3;
                etMessageAnnouncement.Enabled = false;

                etFullscreenMessageAnnouncement.Enabled = false;

                ivAnnouncement.Enabled = true;
                btnUploadAnnouncement.Enabled = true;
            }


        }

        async void UploadImage()
        {

            try
            {
                await CrossMedia.Current.Initialize();

                if (!CrossMedia.Current.IsPickPhotoSupported)
                {
                    Toast.MakeText(this, "Upload not supported on this device", ToastLength.Short).Show();
                    return;
                }

                var file = await CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
                {
                    PhotoSize = Plugin.Media.Abstractions.PhotoSize.Full

                });

                // Convert file to byre array, to bitmap and set it to our ImageView

                byte[] imageArray = System.IO.File.ReadAllBytes(file.Path);
                var bitmap = BitmapFactory.DecodeByteArray(imageArray, 0, imageArray.Length);
                ivAnnouncement.SetImageBitmap(bitmap);


                ivAnnouncement.BuildDrawingCache(true);
                Bitmap bmap = ivAnnouncement.GetDrawingCache(true);
                ivAnnouncement.SetImageBitmap(bmap);
                Bitmap b = Bitmap.CreateBitmap(ivAnnouncement.GetDrawingCache(true));



                using (var stream = new MemoryStream())
                {
                    b.Compress(Bitmap.CompressFormat.Png, 0, stream);

                    var bytes = stream.ToArray();
                    str = Convert.ToBase64String(bytes);
                }


            }
            catch (Exception ex)
            {
                Toast.MakeText(this, "Photo Canceled", ToastLength.Short).Show();
            }

        }



        readonly string[] permissionGroup =
        {
            Manifest.Permission.ReadExternalStorage,
            Manifest.Permission.WriteExternalStorage,
            Manifest.Permission.Camera
        };

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_announcement);
            initialize();



            GetAnnouncement();

            btnUpdateAnnouncement.Click += btnUpdateAnnouncement_Click;
            rb1.CheckedChange += rb1_CheckedChange;
            rb2.CheckedChange += rb2_CheckedChange;
            rb3.CheckedChange += rb3_CheckedChange;

            btnUploadAnnouncement.Click += btnUploadAnnouncement_Click;

            RequestPermissions(permissionGroup, 0);

        }

        private void btnUploadAnnouncement_Click(object sender, EventArgs e)
        {
            UploadImage();
        }

        private void rb3_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            RadioButtonActions();

        }

        private void rb2_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            RadioButtonActions();

        }

        private void rb1_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            RadioButtonActions();
        }

        [Obsolete]
        private void btnUpdateAnnouncement_Click(object sender, EventArgs e)
        {


       



            announcementEL.Announcement = etMessageAnnouncement.Text;
            announcementEL.Announcementtextfullscreen = etFullscreenMessageAnnouncement.Text;
            announcementEL.Announcementtype = announcementtype;
            announcementEL.Announcementimage = str;

            

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