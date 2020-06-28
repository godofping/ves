using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using static Android.App.DatePickerDialog;

namespace ves
{
    [Activity(Label = "MatchInformationActivity")]

    public class MatchInformationActivity : Activity, IOnDateSetListener
    {
        EL.Matches matchEL = new EL.Matches();
        DL.Matches matchDL = new DL.Matches();

        string val; //best of
        string val2; //division
        Spinner sBestof, sDivision;
        EditText etMatchNumber, etRefereeA, etRefereeB, etScorer, etLineJudge1, etLineJudge2, etLineJudge3, etLineJudge4, etDate, etTime, etTeamAName, etTeamACoach, etTeamBName, etTeamBCoach;
        TextView tvTeamBSet1, tvTeamBSet2, tvTeamBSet3, tvTeamBSet4, tvTeamBSet5, tvTeamBTimeou1, tvTeamBTimeou2, tvTeamBTimeou3, tvTeamBTimeou4, tvTeamBTimeou5, tvTeamBResult;
        TextView tvTeamASet1, tvTeamASet2, tvTeamASet3, tvTeamASet4, tvTeamASet5, tvTeamATimeou1, tvTeamATimeou2, tvTeamATimeou3, tvTeamATimeou4, tvTeamATimeou5, tvTeamAResult;
        TextView tvlTeamASet4, tvlTeamASet5, tvlTeamBSet4, tvlTeamBSet5, tvlTeamATimeout4, tvlTeamATimeout5, tvlTeamBTimeout4, tvlTeamBTimeout5;
        Button btnSave, btnCancel, btnSelectTime, btnSelectDate;

        private const int DATE_DIALOG = 1;
        private const int TIME_DIALOG = 1;
        private int year = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
        private int month = Convert.ToInt32(DateTime.Now.ToString("MM"));
        private int day = Convert.ToInt32(DateTime.Now.ToString("dd"));

        private int hour = Convert.ToInt32(DateTime.Now.ToString("hh"));
        private int minutes = Convert.ToInt32(DateTime.Now.ToString("ii"));


        private void initialize()
        {

            btnSave = FindViewById<Button>(Resource.Id.btnSave);
            btnCancel = FindViewById<Button>(Resource.Id.btnCancel);

            btnSelectDate = FindViewById<Button>(Resource.Id.btnSelectDate);
            btnSelectTime = FindViewById<Button>(Resource.Id.btnSelectTime);

            sBestof = FindViewById<Spinner>(Resource.Id.sBestof);
            sDivision = FindViewById<Spinner>(Resource.Id.sDivision);

            etMatchNumber = FindViewById<EditText>(Resource.Id.etMatchNumber);
            etRefereeA = FindViewById<EditText>(Resource.Id.etRefereeA);
            etRefereeB = FindViewById<EditText>(Resource.Id.etRefereeB);
            etScorer = FindViewById<EditText>(Resource.Id.etScorer);
            etLineJudge1 = FindViewById<EditText>(Resource.Id.etLineJudge1);
            etLineJudge2 = FindViewById<EditText>(Resource.Id.etLineJudge2);
            etLineJudge3 = FindViewById<EditText>(Resource.Id.etLineJudge3);
            etLineJudge4 = FindViewById<EditText>(Resource.Id.etLineJudge4);
            etTime = FindViewById<EditText>(Resource.Id.etTime);
            etDate = FindViewById<EditText>(Resource.Id.etDate);
            etTeamAName = FindViewById<EditText>(Resource.Id.etTeamAName);
            etTeamACoach = FindViewById<EditText>(Resource.Id.etTeamACoach);
            etTeamBName = FindViewById<EditText>(Resource.Id.etTeamBName);
            etTeamBCoach = FindViewById<EditText>(Resource.Id.etTeamBCoach);
            tvTeamASet1 = FindViewById<TextView>(Resource.Id.tvTeamASet1);
            tvTeamASet2 = FindViewById<TextView>(Resource.Id.tvTeamASet2);
            tvTeamASet3 = FindViewById<TextView>(Resource.Id.tvTeamASet3);
            tvTeamASet4 = FindViewById<TextView>(Resource.Id.tvTeamASet4);
            tvTeamASet5 = FindViewById<TextView>(Resource.Id.tvTeamASet5);
            tvTeamATimeou1 = FindViewById<TextView>(Resource.Id.tvTeamATimeout1);
            tvTeamATimeou2 = FindViewById<TextView>(Resource.Id.tvTeamATimeout2);
            tvTeamATimeou3 = FindViewById<TextView>(Resource.Id.tvTeamATimeout3);
            tvTeamATimeou4 = FindViewById<TextView>(Resource.Id.tvTeamATimeout4);
            tvTeamATimeou5 = FindViewById<TextView>(Resource.Id.tvTeamATimeout5);
            tvTeamAResult = FindViewById<TextView>(Resource.Id.tvTeamAResult);
            tvTeamBSet1 = FindViewById<TextView>(Resource.Id.tvTeamBSet1);
            tvTeamBSet2 = FindViewById<TextView>(Resource.Id.tvTeamBSet2);
            tvTeamBSet3 = FindViewById<TextView>(Resource.Id.tvTeamBSet3);
            tvTeamBSet4 = FindViewById<TextView>(Resource.Id.tvTeamBSet4);
            tvTeamBSet5 = FindViewById<TextView>(Resource.Id.tvTeamBSet5);
            tvTeamBTimeou1 = FindViewById<TextView>(Resource.Id.tvTeamBTimeout1);
            tvTeamBTimeou2 = FindViewById<TextView>(Resource.Id.tvTeamBTimeout2);
            tvTeamBTimeou3 = FindViewById<TextView>(Resource.Id.tvTeamBTimeout3);
            tvTeamBTimeou4 = FindViewById<TextView>(Resource.Id.tvTeamBTimeout4);
            tvTeamBTimeou5 = FindViewById<TextView>(Resource.Id.tvTeamBTimeout5);
            tvTeamBResult = FindViewById<TextView>(Resource.Id.tvTeamBResult);

            tvlTeamASet4 = FindViewById<TextView>(Resource.Id.tvlTeamASet4);
            tvlTeamASet5 = FindViewById<TextView>(Resource.Id.tvlTeamASet5);
            tvlTeamBSet4 = FindViewById<TextView>(Resource.Id.tvlTeamBSet4);
            tvlTeamBSet5 = FindViewById<TextView>(Resource.Id.tvlTeamBSet5);
            tvlTeamATimeout4 = FindViewById<TextView>(Resource.Id.tvlTeamATimeout4);
            tvlTeamATimeout5 = FindViewById<TextView>(Resource.Id.tvlTeamATimeout5);
            tvlTeamBTimeout4 = FindViewById<TextView>(Resource.Id.tvlTeamBTimeout4);
            tvlTeamBTimeout5 = FindViewById<TextView>(Resource.Id.tvlTeamBTimeout5);

        }

        private void GetInformation()
        {
            matchEL.Matchid = 1;
            matchEL = matchDL.Select(matchEL);

            var items = new List<string>() { "3", "5" };
            var items2 = new List<string>() { "Men", "Women", "Mixed" };

            var adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, items);
            var adapter2 = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, items2);

            sBestof.Adapter = adapter;
            sDivision.Adapter = adapter2;

            sBestof.SetSelection(adapter.GetPosition(matchEL.Bestof.ToString()));
            sDivision.SetSelection(adapter2.GetPosition(matchEL.Division.ToString()));


            etMatchNumber.Text = matchEL.Matchnumber;
            etRefereeA.Text = matchEL.Refereeaname;
            etRefereeB.Text = matchEL.Refereebname;
            etScorer.Text = matchEL.Scorername;
            etLineJudge1.Text = matchEL.Linejudges1name;
            etLineJudge2.Text = matchEL.Linejudges2name;
            etLineJudge3.Text = matchEL.Linejudges3name;
            etLineJudge4.Text = matchEL.Linejudges4name;
            etDate.Text = matchEL.Matchdate;
            etTime.Text = matchEL.Matchtime;
            etTeamAName.Text = matchEL.Teamaname;
            etTeamACoach.Text = matchEL.Teamacoach;
            etTeamBName.Text = matchEL.Teambname;
            etTeamBCoach.Text = matchEL.Teambcoach;
            tvTeamASet1.Text = matchEL.Teamaset1.ToString();
            tvTeamASet2.Text = matchEL.Teamaset2.ToString();
            tvTeamASet3.Text = matchEL.Teamaset3.ToString();
            tvTeamASet4.Text = matchEL.Teamaset4.ToString();
            tvTeamASet5.Text = matchEL.Teamaset5.ToString();
            tvTeamATimeou1.Text = matchEL.Teamatimeout1.ToString();
            tvTeamATimeou2.Text = matchEL.Teamatimeout2.ToString();
            tvTeamATimeou3.Text = matchEL.Teamatimeout3.ToString();
            tvTeamATimeou4.Text = matchEL.Teamatimeout4.ToString();
            tvTeamATimeou5.Text = matchEL.Teamatimeout5.ToString();
            tvTeamAResult.Text = matchEL.Teamaresult;
            tvTeamBSet1.Text = matchEL.Teambset1.ToString();
            tvTeamBSet2.Text = matchEL.Teambset2.ToString();
            tvTeamBSet3.Text = matchEL.Teambset3.ToString();
            tvTeamBSet4.Text = matchEL.Teambset4.ToString();
            tvTeamBSet5.Text = matchEL.Teambset5.ToString();
            tvTeamATimeou1.Text = matchEL.Teambtimeout1.ToString();
            tvTeamATimeou2.Text = matchEL.Teambtimeout2.ToString();
            tvTeamATimeou3.Text = matchEL.Teambtimeout3.ToString();
            tvTeamATimeou4.Text = matchEL.Teambtimeout4.ToString();
            tvTeamATimeou5.Text = matchEL.Teambtimeout5.ToString();
            tvTeamBResult.Text = matchEL.Teambresult;

        }

        private void ShowBestOf5(bool bol)
        {
            if (bol)
            {
                tvlTeamASet4.Visibility = ViewStates.Visible;
                tvlTeamBSet4.Visibility = ViewStates.Visible;
                tvlTeamASet5.Visibility = ViewStates.Visible;
                tvlTeamBSet5.Visibility = ViewStates.Visible;

                tvlTeamATimeout4.Visibility = ViewStates.Visible;
                tvlTeamBTimeout4.Visibility = ViewStates.Visible;
                tvlTeamATimeout5.Visibility = ViewStates.Visible;
                tvlTeamBTimeout5.Visibility = ViewStates.Visible;

                tvTeamASet4.Visibility = ViewStates.Visible;
                tvTeamBSet4.Visibility = ViewStates.Visible;
                tvTeamASet5.Visibility = ViewStates.Visible;
                tvTeamBSet5.Visibility = ViewStates.Visible;

                tvTeamATimeou4.Visibility = ViewStates.Visible;
                tvTeamBTimeou4.Visibility = ViewStates.Visible;
                tvTeamATimeou5.Visibility = ViewStates.Visible;
                tvTeamBTimeou5.Visibility = ViewStates.Visible;
            }
            else
            {
                tvlTeamASet4.Visibility = ViewStates.Invisible;
                tvlTeamBSet4.Visibility = ViewStates.Invisible;
                tvlTeamASet5.Visibility = ViewStates.Invisible;
                tvlTeamBSet5.Visibility = ViewStates.Invisible;

                tvlTeamATimeout4.Visibility = ViewStates.Invisible;
                tvlTeamBTimeout4.Visibility = ViewStates.Invisible;
                tvlTeamATimeout5.Visibility = ViewStates.Invisible;
                tvlTeamBTimeout5.Visibility = ViewStates.Invisible;

                tvTeamASet4.Visibility = ViewStates.Invisible;
                tvTeamBSet4.Visibility = ViewStates.Invisible;
                tvTeamASet5.Visibility = ViewStates.Invisible;
                tvTeamBSet5.Visibility = ViewStates.Invisible;

                tvTeamATimeou4.Visibility = ViewStates.Invisible;
                tvTeamBTimeou4.Visibility = ViewStates.Invisible;
                tvTeamATimeou5.Visibility = ViewStates.Invisible;
                tvTeamBTimeou5.Visibility = ViewStates.Invisible;
            }
        }

        public bool UpdateMatch()
        {
            if (matchDL.Update(matchEL))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_match_information);
            initialize();

            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;

            btnSelectDate.Click += btnSelectDate_Click;
            btnSelectTime.Click += btnSelectTime_Click;



            sBestof.ItemSelected += sBestof_ItemSelected;
            sDivision.ItemSelected += sDivision_ItemSelected;

            etDate.Enabled = false;
            etTime.Enabled = false;

            GetInformation();

            if (matchEL.Bestof.Equals("3"))
            {
                ShowBestOf5(false);
            }

            if (matchEL.Bestof.Equals("5"))
            {
                ShowBestOf5(true);
            }

            if (matchEL.Currentset == 1 & matchEL.Teamaset1 == 0 & matchEL.Teambset1 == 0 & matchEL.Teamatimeout1 == 0 & matchEL.Teambtimeout1 == 0)
            {
                sBestof.Enabled = true;
            }
            else
            {
                sBestof.Enabled = false;
            }


        }

        private void btnSelectTime_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectDate_Click(object sender, EventArgs e)
        {
            ShowDialog(DATE_DIALOG);

        }

        public void OnDateSet(DatePicker view, int year, int month, int dayOfMonth)
        {
            etDate.Text = year + "/" + month + "/" + dayOfMonth;
        }

        protected override Dialog OnCreateDialog(int id)
        {
            switch (id)
            {
                case DATE_DIALOG:
                    {
                        return new DatePickerDialog(this, this, year, month, day);
                    }
                default:
                    break;
            }
            return null;
        }

        private void sDivision_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            val2 = spinner.GetItemAtPosition(e.Position).ToString();
        }


        private void sBestof_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            val = spinner.GetItemAtPosition(e.Position).ToString();

            if (val.Equals("3"))
            {
                ShowBestOf5(false);
            }

            if (val.Equals("5"))
            {
                ShowBestOf5(true);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Intent cp = new Intent(this, typeof(ControlPanelActivity));
            StartActivity(cp);
            this.Finish();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            matchEL.Bestof = Convert.ToInt32(val);
            matchEL.Matchnumber = etMatchNumber.Text;
            matchEL.Refereeaname = etRefereeA.Text;
            matchEL.Refereebname = etRefereeB.Text;
            matchEL.Scorername = etScorer.Text;
            matchEL.Linejudges1name = etLineJudge1.Text;
            matchEL.Linejudges2name = etLineJudge2.Text;
            matchEL.Linejudges3name = etLineJudge3.Text;
            matchEL.Linejudges4name = etLineJudge4.Text;
            matchEL.Division = val2;
            matchEL.Matchdate = etDate.Text;

            matchEL.Teamaname = etTeamAName.Text;
            matchEL.Teamacoach = etTeamACoach.Text;
            matchEL.Teambname = etTeamBName.Text;
            matchEL.Teambcoach = etTeamBCoach.Text;

            if (UpdateMatch())
            {
                Intent cp = new Intent(this, typeof(ControlPanelActivity));
                StartActivity(cp);
                this.Finish();
            }
            else
                Toast.MakeText(this, "Error!", ToastLength.Long).Show();
        }


    }
}