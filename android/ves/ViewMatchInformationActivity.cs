using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using System;

namespace ves
{
    [Activity(Label = "ViewMatchInformationActivity")]
    public class ViewMatchInformationActivity : Activity
    {

        EL.Matches matchEL = new EL.Matches();
        DL.Matches matchDL = new DL.Matches();

   
        TextView sBestof, tvMatchModified;
        TextView etMatchNumber, etReferee, etScorer, etLineJudge1, etLineJudge2, etLineJudge3, etLineJudge4, etDivision, etDate, etTime, etTeamAName, etTeamACoach, etTeamBName, etTeamBCoach;
        TextView tvTeamBSet1, tvTeamBSet2, tvTeamBSet3, tvTeamBSet4, tvTeamBSet5, tvTeamBTimeou1, tvTeamBTimeou2, tvTeamBTimeou3, tvTeamBTimeou4, tvTeamBTimeou5, tvTeamBResult;
        TextView tvTeamASet1, tvTeamASet2, tvTeamASet3, tvTeamASet4, tvTeamASet5, tvTeamATimeou1, tvTeamATimeou2, tvTeamATimeou3, tvTeamATimeou4, tvTeamATimeou5, tvTeamAResult;
        TextView tvlTeamASet4, tvlTeamASet5, tvlTeamBSet4, tvlTeamBSet5, tvlTeamATimeout4, tvlTeamATimeout5, tvlTeamBTimeout4, tvlTeamBTimeout5;
        Button btnViewDelete, btnViewBack;

        private void initialize()
        {

            btnViewDelete = FindViewById<Button>(Resource.Id.btnViewDelete);
            btnViewBack = FindViewById<Button>(Resource.Id.btnViewBack);

            tvMatchModified = FindViewById<TextView>(Resource.Id.tvMatchModified);
            sBestof = FindViewById<TextView>(Resource.Id.tvBestOf);
            etMatchNumber = FindViewById<TextView>(Resource.Id.tvMatchNumber);
            etReferee = FindViewById<TextView>(Resource.Id.tvReferee);
            etScorer = FindViewById<TextView>(Resource.Id.tvScorer);
            etLineJudge1 = FindViewById<TextView>(Resource.Id.tvLineJudges1);
            etLineJudge2 = FindViewById<TextView>(Resource.Id.tvLineJudges2);
            etLineJudge3 = FindViewById<TextView>(Resource.Id.tvLineJudges3);
            etLineJudge4 = FindViewById<TextView>(Resource.Id.tvLineJudges4);
            etDivision = FindViewById<TextView>(Resource.Id.tvDivision);
            etDate = FindViewById<TextView>(Resource.Id.tvDate);
            etTime = FindViewById<TextView>(Resource.Id.tvTime);
            etTeamAName = FindViewById<TextView>(Resource.Id.tvTeamAName);
            etTeamACoach = FindViewById<TextView>(Resource.Id.tvTeamACoach);
            etTeamBName = FindViewById<TextView>(Resource.Id.tvTeamBName);
            etTeamBCoach = FindViewById<TextView>(Resource.Id.tvTeamBCoach);
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

            matchEL = matchDL.Select(matchEL);


            tvMatchModified.Text = matchEL.Matchsaveddatetime;
            sBestof.Text = matchEL.Bestof.ToString();
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

            SetContentView(Resource.Layout.activity_view_match_information);
            initialize();

            btnViewDelete.Click += btnViewDelete_Click;
            btnViewBack.Click += btnViewBack_Click;


            string matchid = Intent.GetStringExtra("matchid") ?? string.Empty;


            matchEL.Matchid = Convert.ToInt32(matchid);

            GetInformation();



        }

        private void btnViewDelete_Click(object sender, EventArgs e)
        {



            AlertDialog.Builder alertDiag = new AlertDialog.Builder(this);
            alertDiag.SetTitle("Warning");
            alertDiag.SetMessage("Are you sure to delete this match?");
            alertDiag.SetPositiveButton("Yes", (senderAlert, args) =>
            {
                if (matchDL.Delete(matchEL))
                {
                    Toast.MakeText(this, "Deleted!", ToastLength.Long).Show();

                    Intent cp = new Intent(this, typeof(MatchesActivity));
                    StartActivity(cp);
                    this.Finish();

                }
            });
            alertDiag.SetNegativeButton("No", (senderAlert, args) =>
            {
                alertDiag.Dispose();
            });
            Dialog diag = alertDiag.Create();
            diag.Show();


        }

        private void btnViewBack_Click(object sender, EventArgs e)
        {
            base.OnBackPressed();

        }
    }
}