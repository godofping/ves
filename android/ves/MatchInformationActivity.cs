﻿using System;
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
    [Activity(Label = "MatchInformationActivity")]
    public class MatchInformationActivity : Activity
    {
        EL.Matches matchEL = new EL.Matches();
        DL.Matches matchDL = new DL.Matches();

        Spinner sBestof;
        EditText etMatchNumber, etReferee, etScorer, etLineJudge1, etLineJudge2, etLineJudge3, etLineJudge4, etDivision, etDate, etTime, etTeamAName, etTeamACoach, etTeamBName, etTeamBCoach;
        TextView tvTeamBSet1, tvTeamBSet2, tvTeamBSet3, tvTeamBSet4, tvTeamBSet5, tvTeamBTimeou1, tvTeamBTimeou2, tvTeamBTimeou3, tvTeamBTimeou4, tvTeamBTimeou5, tvTeamBResult;
        TextView tvTeamASet1, tvTeamASet2, tvTeamASet3, tvTeamASet4, tvTeamASet5, tvTeamATimeou1, tvTeamATimeou2, tvTeamATimeou3, tvTeamATimeou4, tvTeamATimeou5, tvTeamAResult;
        TextView tvlTeamASet4, tvlTeamASet5, tvlTeamBSet4, tvlTeamBSet5, tvlTeamATimeout4, tvlTeamATimeout5, tvlTeamBTimeout4, tvlTeamBTimeout5;
        Button btnSave, btnCancel;

        private void initialize()
        {

            btnSave = FindViewById<Button>(Resource.Id.btnSave);
            btnCancel = FindViewById<Button>(Resource.Id.btnCancel);

            sBestof = FindViewById<Spinner>(Resource.Id.sBestof);
            etMatchNumber = FindViewById<EditText>(Resource.Id.etMatchNumber);
            etReferee = FindViewById<EditText>(Resource.Id.etReferee);
            etScorer = FindViewById<EditText>(Resource.Id.etScorer);
            etLineJudge1 = FindViewById<EditText>(Resource.Id.etLineJudge1);
            etLineJudge2 = FindViewById<EditText>(Resource.Id.etLineJudge2);
            etLineJudge3 = FindViewById<EditText>(Resource.Id.etLineJudge3);
            etLineJudge4 = FindViewById<EditText>(Resource.Id.etLineJudge4);
            etDivision = FindViewById<EditText>(Resource.Id.etDivision);
            etDate = FindViewById<EditText>(Resource.Id.etDate);
            etTime = FindViewById<EditText>(Resource.Id.etTime);
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


            var adapter = ArrayAdapter.CreateFromResource(
                    this, Resource.Array.bestof_array, Android.Resource.Layout.SimpleSpinnerItem);

            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            sBestof.Adapter = adapter;

            sBestof.SetSelection(adapter.GetPosition(matchEL.Bestof.ToString()));




            etMatchNumber.Text = matchEL.Matchnumber;
            etReferee.Text = matchEL.Refereename;
            etScorer.Text = matchEL.Scorername;
            etLineJudge1.Text = matchEL.Linejudges1name;
            etLineJudge2.Text = matchEL.Linejudges2name;
            etLineJudge3.Text = matchEL.Linejudges3name;
            etLineJudge4.Text = matchEL.Linejudges4name;
            etDivision.Text = matchEL.Division;
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

            SetContentView(Resource.Layout.activity_matchinformation);
            initialize();

            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;


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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Finish();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            matchEL.Bestof = 3;
            matchEL.Matchnumber = etMatchNumber.Text;
            matchEL.Refereename = etReferee.Text;
            matchEL.Scorername = etScorer.Text;
            matchEL.Linejudges1name = etLineJudge1.Text;
            matchEL.Linejudges2name = etLineJudge2.Text;
            matchEL.Linejudges3name = etLineJudge3.Text;
            matchEL.Linejudges4name = etLineJudge4.Text;
            matchEL.Division = etDivision.Text;
            matchEL.Matchdate = etDate.Text;
            matchEL.Matchtime = etTime.Text;
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