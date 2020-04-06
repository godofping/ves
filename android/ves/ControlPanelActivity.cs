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
    [Activity(Label = "ControlPanelActivity")]
    public class ControlPanelActivity : Activity
    {

        EL.Matches matchEL = new EL.Matches();
        DL.Matches matchDL = new DL.Matches();

        Button btnTeamAAddScore, btnTeamAMinusScore, btnTeamAAddTimeout, btnTeamAMinusTimeout, btnTeamBAddScore, btnTeamBMinusScore, btnTeamBAddTimeout, btnTeamBMinusTimeout, btnMatchInformation, btnEndSet, btnSaveMatch, btnReset;
        TextView tvSetNumber, tvTeamAName, tvTeamAWonSet, tvTeamAScore, tvTeamATimeout, tvTeamBName, tvTeamBWonSet, tvTeamBScore, tvTeamBTimeout;


        private void initialize()
        {

            btnTeamAAddScore = (Button)FindViewById(Resource.Id.btnTeamAAddScore);
            btnTeamAMinusScore = (Button)FindViewById(Resource.Id.btnTeamAMinusScore);
            btnTeamAAddTimeout = (Button)FindViewById(Resource.Id.btnTeamAAddTimeout);
            btnTeamAMinusTimeout = (Button)FindViewById(Resource.Id.btnTeamAMinusTimeout);
            btnTeamBAddScore = (Button)FindViewById(Resource.Id.btnTeamBAddScore);
            btnTeamBMinusScore = (Button)FindViewById(Resource.Id.btnTeamBMinusScore);
            btnTeamBAddTimeout = (Button)FindViewById(Resource.Id.btnTeamBAddTimeout);
            btnTeamBMinusTimeout = (Button)FindViewById(Resource.Id.btnTeamBMinusTimeout);
            btnMatchInformation = (Button)FindViewById(Resource.Id.btnMatchInformation);
            btnEndSet = (Button)FindViewById(Resource.Id.btnEndSet);
            btnSaveMatch = (Button)FindViewById(Resource.Id.btnSaveMatch);
            btnReset = (Button)FindViewById(Resource.Id.btnReset);

            tvSetNumber = (TextView)FindViewById(Resource.Id.tvSetNumber);
            tvTeamAName = (TextView)FindViewById(Resource.Id.tvTeamAName);
            tvTeamAWonSet = (TextView)FindViewById(Resource.Id.tvTeamAWonSet);
            tvTeamAScore = (TextView)FindViewById(Resource.Id.tvTeamAScore);
            tvTeamATimeout = (TextView)FindViewById(Resource.Id.tvTeamATimeout);
            tvTeamBName = (TextView)FindViewById(Resource.Id.tvTeamBName);
            tvTeamBWonSet = (TextView)FindViewById(Resource.Id.tvTeamBWonSet);
            tvTeamBScore = (TextView)FindViewById(Resource.Id.tvTeamBScore);
            tvTeamBTimeout = (TextView)FindViewById(Resource.Id.tvTeamBTimeout);


        }

        public bool UpdateMatch()
        {
            if (matchDL.Update(matchEL))
            {
                GetMatchInformation();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ResetMatch()
        {
            matchEL.Matchnumber = "";
            matchEL.Refereename = "";
            matchEL.Scorername = "";
            matchEL.Linejudges1name = "";
            matchEL.Linejudges2name = "";
            matchEL.Linejudges3name = "";
            matchEL.Linejudges4name = "";
            matchEL.Division = "";
            matchEL.Matchdate = "";
            matchEL.Matchtime = "";
            matchEL.Teamaname = "-";
            matchEL.Teamacoach = "";
            matchEL.Teamaset1 = 0;
            matchEL.Teamaset2 = 0;
            matchEL.Teamaset3 = 0;
            matchEL.Teamaset4 = 0;
            matchEL.Teamaset5 = 0;
            matchEL.Teamatimeout1 = 0;
            matchEL.Teamatimeout2 = 0;
            matchEL.Teamatimeout3 = 0;
            matchEL.Teamatimeout4 = 0;
            matchEL.Teamatimeout5 = 0;
            matchEL.Teamawonsets = 0;
            matchEL.Teamaresult = "";
            matchEL.Teambname = "-";
            matchEL.Teambcoach = "";
            matchEL.Teambset1 = 0;
            matchEL.Teambset2 = 0;
            matchEL.Teambset3 = 0;
            matchEL.Teambset4 = 0;
            matchEL.Teambset5 = 0;
            matchEL.Teambtimeout1 = 0;
            matchEL.Teambtimeout2 = 0;
            matchEL.Teambtimeout3 = 0;
            matchEL.Teambtimeout4 = 0;
            matchEL.Teambtimeout5 = 0;
            matchEL.Teambwonsets = 0;
            matchEL.Teambresult = "";
            matchEL.Currentset = 1;
            matchEL.Matchsaveddatetime = "";
            matchEL.Bestof = 3;

            if (UpdateMatch())
            {
                btnSaveMatch.Visibility = ViewStates.Invisible;
            }

            CheckIfCanSet();
            ShowAddMinusButtons(true);


        }

        private void CheckIfCanSet()
        {
            if (matchEL.Currentset != matchEL.Bestof)
            {
                if ((Convert.ToInt32(tvTeamAScore.Text) >= 25 & Convert.ToInt32(tvTeamAScore.Text) > (Convert.ToInt32(tvTeamBScore.Text) + 1)) | (Convert.ToInt32(tvTeamBScore.Text) >= 25 & Convert.ToInt32(tvTeamBScore.Text) > (Convert.ToInt32(tvTeamAScore.Text) + 1)))
                {
                    btnEndSet.Visibility = ViewStates.Visible;
                }
                else
                {
                    btnEndSet.Visibility = ViewStates.Invisible;
                }
            }
            else
            {
                if ((Convert.ToInt32(tvTeamAScore.Text) >= 15 & Convert.ToInt32(tvTeamAScore.Text) > (Convert.ToInt32(tvTeamBScore.Text) + 1)) | (Convert.ToInt32(tvTeamBScore.Text) >= 15 & Convert.ToInt32(tvTeamBScore.Text) > (Convert.ToInt32(tvTeamAScore.Text) + 1)))
                {
                    btnEndSet.Visibility = ViewStates.Visible;
                }
                else
                {
                    btnEndSet.Visibility = ViewStates.Invisible;
                }
            }
        }

        private void CheckIfCanEndMatch()
        {
            bool bol = false;
            if (matchEL.Bestof == 3)
            {
                if (matchEL.Teamawonsets == 2 | matchEL.Teambwonsets == 2)
                {
                    btnSaveMatch.Visibility = ViewStates.Visible;
                    ShowAddMinusButtons(false);
                    bol = true;
                }
                else
                {
                    btnSaveMatch.Visibility = ViewStates.Invisible;
                    ShowAddMinusButtons(true);
                }

            }

            if (matchEL.Bestof == 5)
            {
                if (matchEL.Teamawonsets == 3 | matchEL.Teambwonsets == 3)
                {
                    btnSaveMatch.Visibility = ViewStates.Visible;
                    ShowAddMinusButtons(false);
                    bol = true;
                }
                else
                {
                    btnSaveMatch.Visibility = ViewStates.Visible;
                    ShowAddMinusButtons(true);
                }

            }

            if (bol)
            {
                if (matchEL.Teamawonsets > matchEL.Teambwonsets)
                {
                    matchEL.Teamaresult = "WIN";
                    matchEL.Teambresult = "LOSE";
                }

                if (matchEL.Teambwonsets > matchEL.Teamawonsets)
                {
                    matchEL.Teamaresult = "LOSE";
                    matchEL.Teambresult = "WIN";
                }

                if (matchEL.Teamawonsets == matchEL.Teambwonsets)
                {
                    matchEL.Teamaresult = "DRAW";
                    matchEL.Teambresult = "DRAW";
                }
            }

            btnEndSet.Visibility = ViewStates.Invisible;
            UpdateMatch();
        }

        private void ShowAddMinusButtons(bool bol)
        {
            if (bol == true)
            {
                btnTeamAAddScore.Visibility = ViewStates.Visible;
                btnTeamBAddScore.Visibility = ViewStates.Visible;

                btnTeamAMinusScore.Visibility = ViewStates.Visible;
                btnTeamBMinusScore.Visibility = ViewStates.Visible;

                btnTeamAAddTimeout.Visibility = ViewStates.Visible;
                btnTeamBAddTimeout.Visibility = ViewStates.Visible;

                btnTeamAMinusTimeout.Visibility = ViewStates.Visible;
                btnTeamBMinusTimeout.Visibility = ViewStates.Visible;
            }
            else
            {
                btnTeamAAddScore.Visibility = ViewStates.Invisible;
                btnTeamBAddScore.Visibility = ViewStates.Invisible;

                btnTeamAMinusScore.Visibility = ViewStates.Invisible;
                btnTeamBMinusScore.Visibility = ViewStates.Invisible;

                btnTeamAAddTimeout.Visibility = ViewStates.Invisible;
                btnTeamBAddTimeout.Visibility = ViewStates.Invisible;

                btnTeamAMinusTimeout.Visibility = ViewStates.Invisible;
                btnTeamBMinusTimeout.Visibility = ViewStates.Invisible;
            }

        }

        public  void GetMatchInformation()
        {
            matchEL.Matchid = 1;
            matchEL = matchDL.Select(matchEL);

            tvSetNumber.Text = matchEL.Currentset.ToString();


            tvTeamAName.Text = matchEL.Teamaname;
            tvTeamAWonSet.Text = matchEL.Teamawonsets.ToString();
            tvTeamBName.Text = matchEL.Teambname;
            tvTeamBWonSet.Text = matchEL.Teambwonsets.ToString();


            if (matchEL.Currentset == 1)
            {
                tvTeamAScore.Text = matchEL.Teamaset1.ToString();
                tvTeamBScore.Text = matchEL.Teambset1.ToString();
                tvTeamATimeout.Text = matchEL.Teamatimeout1.ToString();
                tvTeamBTimeout.Text = matchEL.Teambtimeout1.ToString();
            }

            if (matchEL.Currentset == 2)
            {
                tvTeamAScore.Text = matchEL.Teamaset2.ToString();
                tvTeamBScore.Text = matchEL.Teambset2.ToString();
                tvTeamATimeout.Text = matchEL.Teamatimeout2.ToString();
                tvTeamBTimeout.Text = matchEL.Teambtimeout2.ToString();
            }

            if (matchEL.Currentset == 3)
            {
                tvTeamAScore.Text = matchEL.Teamaset3.ToString();
                tvTeamBScore.Text = matchEL.Teambset3.ToString();
                tvTeamATimeout.Text = matchEL.Teamatimeout3.ToString();
                tvTeamBTimeout.Text = matchEL.Teambtimeout3.ToString();
            }

            if (matchEL.Currentset == 4)
            {
                tvTeamAScore.Text = matchEL.Teamaset4.ToString();
                tvTeamBScore.Text = matchEL.Teambset4.ToString();
                tvTeamATimeout.Text = matchEL.Teamatimeout4.ToString();
                tvTeamBTimeout.Text = matchEL.Teambtimeout4.ToString();
            }

            if (matchEL.Currentset == 5)
            {
                tvTeamAScore.Text = matchEL.Teamaset5.ToString();
                tvTeamBScore.Text = matchEL.Teambset5.ToString();
                tvTeamATimeout.Text = matchEL.Teamatimeout5.ToString();
                tvTeamBTimeout.Text = matchEL.Teambtimeout5.ToString();
            }



        }


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_controlpanel);

            initialize();

            GetMatchInformation();
            CheckIfCanSet();
            CheckIfCanEndMatch();

            btnTeamAAddScore.Click += btnTeamAAddScore_Click;
            btnTeamAMinusScore.Click += btnTeamAMinusScore_Click;

            btnTeamBAddScore.Click += btnTeamBAddScore_Click;
            btnTeamBMinusScore.Click += btnTeamBMinusScore_Click;

            btnTeamAAddTimeout.Click += btnTeamAAddTimeout_Click;
            btnTeamAMinusTimeout.Click += btnTeamAMinusTimeout_Click;

            btnTeamBAddTimeout.Click += btnTeamBAddTimeout_Click;
            btnTeamBMinusTimeout.Click += btnTeamBMinusTimeout_Click;


            btnReset.Click += btnReset_Click;
            btnEndSet.Click += btnEndSet_Click;
            btnSaveMatch.Click += btnSaveMatch_Click;
            btnMatchInformation.Click += btnMatchInformation_Click;


        }

        private void btnMatchInformation_Click(object sender, EventArgs e)
        {
           Intent cp = new Intent(this, typeof(MatchInformationActivity));
            StartActivity(cp);
            this.Finish();
        }

        private void btnSaveMatch_Click(object sender, EventArgs e)
        {

            AlertDialog.Builder alertDiag = new AlertDialog.Builder(this);
            alertDiag.SetTitle("Warning");
            alertDiag.SetMessage("Are you sure to save this match?");
            alertDiag.SetPositiveButton("Yes", (senderAlert, args) => {
                if (UpdateMatch())
                {
                    matchEL.Matchsaveddatetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    matchDL.Insert(matchEL);
                    ShowAddMinusButtons(false);
                    ResetMatch();
                    Toast.MakeText(this, "Match information is saved to the database.", ToastLength.Long).Show();
                }
            });
            alertDiag.SetNegativeButton("No", (senderAlert, args) => {
                alertDiag.Dispose();
            });
            Dialog diag = alertDiag.Create();
            diag.Show();
        }

        private void btnEndSet_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tvSetNumber.Text) != 5)
            {
                if (Convert.ToInt32(tvTeamAScore.Text) == 0 & Convert.ToInt32(tvTeamBScore.Text) == 0)
                {
                    Toast.MakeText(this, "Failed to end the set. Both team has no score.", ToastLength.Long).Show();
                }
                else
                {
                    bool bol = false;
                    if (matchEL.Currentset == 3 | matchEL.Currentset == 5)
                    {
                        if (Convert.ToInt32(tvTeamAScore.Text) < 15 & Convert.ToInt32(tvTeamBScore.Text) < 15)
                        {
                            Toast.MakeText(this, "Atleast one team should score 15 or more.", ToastLength.Long).Show();
                        }
                        else
                        {
                            bol = true;
                        }
                    }

                    if (matchEL.Currentset == 1 | matchEL.Currentset == 2 | matchEL.Currentset == 4)
                    {
                        if (Convert.ToInt32(tvTeamAScore.Text) < 25 & Convert.ToInt32(tvTeamBScore.Text) < 25)
                        {
                            Toast.MakeText(this, "Atleast one team should score 25 or more.", ToastLength.Long).Show();
                        }
                        else
                        {
                            bol = true;
                        }
                    }


                    if (bol)
                    {


                        AlertDialog.Builder alertDiag = new AlertDialog.Builder(this);
                        alertDiag.SetTitle("Warning");
                        alertDiag.SetMessage("Are you sure to end this set?");
                        alertDiag.SetPositiveButton("Yes", (senderAlert, args) => {
                            if (matchEL.Currentset == 1)
                            {
                                if (matchEL.Teamaset1 > matchEL.Teambset1)
                                {
                                    matchEL.Teamawonsets += 1;
                                }

                                if (matchEL.Teamaset1 < matchEL.Teambset1)
                                {
                                    matchEL.Teambwonsets += 1;
                                }

                                if (matchEL.Teamaset1 == matchEL.Teambset1)
                                {
                                    matchEL.Teamawonsets += 1;
                                    matchEL.Teambwonsets += 1;
                                }
                            }

                            if (matchEL.Currentset == 2)
                            {
                                if (matchEL.Teamaset2 > matchEL.Teambset2)
                                {
                                    matchEL.Teamawonsets += 1;
                                }

                                if (matchEL.Teamaset2 < matchEL.Teambset2)
                                {
                                    matchEL.Teambwonsets += 1;
                                }

                                if (matchEL.Teamaset2 == matchEL.Teambset2)
                                {
                                    matchEL.Teamawonsets += 1;
                                    matchEL.Teambwonsets += 1;
                                }


                            }

                            if (matchEL.Currentset == 3)
                            {
                                if (matchEL.Teamaset3 > matchEL.Teambset3)
                                {
                                    matchEL.Teamawonsets += 1;
                                }

                                if (matchEL.Teamaset3 < matchEL.Teambset3)
                                {
                                    matchEL.Teambwonsets += 1;
                                }

                                if (matchEL.Teamaset3 == matchEL.Teambset3)
                                {
                                    matchEL.Teamawonsets += 1;
                                    matchEL.Teambwonsets += 1;
                                }
                            }

                            if (matchEL.Currentset == 4)
                            {
                                if (matchEL.Teamaset4 > matchEL.Teambset4)
                                {
                                    matchEL.Teamawonsets += 1;
                                }

                                if (matchEL.Teamaset4 < matchEL.Teambset4)
                                {
                                    matchEL.Teambwonsets += 1;
                                }

                                if (matchEL.Teamaset4 == matchEL.Teambset4)
                                {
                                    matchEL.Teamawonsets += 1;
                                    matchEL.Teambwonsets += 1;
                                }
                            }

                            if (matchEL.Currentset == 5)
                            {
                                if (matchEL.Teamaset5 > matchEL.Teambset5)
                                {
                                    matchEL.Teamawonsets += 1;
                                }

                                if (matchEL.Teamaset5 < matchEL.Teambset5)
                                {
                                    matchEL.Teambwonsets += 1;
                                }

                                if (matchEL.Teamaset5 == matchEL.Teambset5)
                                {
                                    matchEL.Teamawonsets += 1;
                                    matchEL.Teambwonsets += 1;
                                }
                            }

                            if (matchEL.Bestof == 3)
                            {
                                if (matchEL.Teamawonsets == 2 | matchEL.Teambwonsets == 2)
                                {
                                }
                                else
                                {
                                    matchEL.Currentset = matchEL.Currentset + 1;
                                }
                            }

                            if (matchEL.Bestof == 5)
                            {
                                if (matchEL.Teamawonsets == 3 | matchEL.Teambwonsets == 3)
                                {
                                }
                                else
                                {
                                    matchEL.Currentset = matchEL.Currentset + 1;
                                }
                            }

                            CheckIfCanSet();
                            CheckIfCanEndMatch();
                        });
                        alertDiag.SetNegativeButton("No", (senderAlert, args) => {
                            alertDiag.Dispose();
                        });
                        Dialog diag = alertDiag.Create();
                        diag.Show();


                    }
                }


            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            AlertDialog.Builder alertDiag = new AlertDialog.Builder(this);
            alertDiag.SetTitle("Warning");
            alertDiag.SetMessage("Are you sure to reset this match?");
            alertDiag.SetPositiveButton("Yes", (senderAlert, args) => {
                ResetMatch();
            });
            alertDiag.SetNegativeButton("No", (senderAlert, args) => {
                alertDiag.Dispose();
            });
            Dialog diag = alertDiag.Create();
            diag.Show();
        }

        private void btnTeamBAddTimeout_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tvTeamBTimeout.Text) != 3)
            {
                if (matchEL.Currentset == 1)
                {
                    matchEL.Teambtimeout1 = matchEL.Teambtimeout1 + 1;
                }

                if (matchEL.Currentset == 2)
                {
                    matchEL.Teambtimeout2 = matchEL.Teambtimeout2 + 1;
                }

                if (matchEL.Currentset == 3)
                {
                    matchEL.Teambtimeout3 = matchEL.Teambtimeout3 + 1;
                }

                if (matchEL.Currentset == 4)
                {
                    matchEL.Teambtimeout4 = matchEL.Teambtimeout4 + 1;
                }

                if (matchEL.Currentset == 5)
                {
                    matchEL.Teambtimeout5 = matchEL.Teambtimeout5 + 1;
                }

                UpdateMatch();
            }
        }

        private void btnTeamBMinusTimeout_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tvTeamBTimeout.Text) != 0)
            {
                if (matchEL.Currentset == 1)
                {
                    matchEL.Teambtimeout1 = matchEL.Teambtimeout1 - 1;
                }

                if (matchEL.Currentset == 2)
                {
                    matchEL.Teambtimeout2 = matchEL.Teambtimeout2 - 1;
                }

                if (matchEL.Currentset == 3)
                {
                    matchEL.Teambtimeout3 = matchEL.Teambtimeout3 - 1;
                }

                if (matchEL.Currentset == 4)
                {
                    matchEL.Teambtimeout4 = matchEL.Teambtimeout4 - 1;
                }

                if (matchEL.Currentset == 5)
                {
                    matchEL.Teambtimeout5 = matchEL.Teambtimeout5 - 1;
                }

                UpdateMatch();
            }
        }


        private void btnTeamAMinusTimeout_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tvTeamATimeout.Text) != 0)
            {
                if (matchEL.Currentset == 1)
                {
                    matchEL.Teamatimeout1 = matchEL.Teamatimeout1 - 1;
                }

                if (matchEL.Currentset == 2)
                {
                    matchEL.Teamatimeout2 = matchEL.Teamatimeout2 - 1;
                }

                if (matchEL.Currentset == 3)
                {
                    matchEL.Teamatimeout3 = matchEL.Teamatimeout3 - 1;
                }

                if (matchEL.Currentset == 4)
                {
                    matchEL.Teamatimeout4 = matchEL.Teamatimeout4 - 1;
                }

                if (matchEL.Currentset == 5)
                {
                    matchEL.Teamatimeout5 = matchEL.Teamatimeout5 - 1;
                }

                UpdateMatch();
            }
        }

        private void btnTeamAAddTimeout_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tvTeamATimeout.Text) != 3)
            {
                if (matchEL.Currentset == 1)
                {
                    matchEL.Teamatimeout1 = matchEL.Teamatimeout1 + 1;
                }

                if (matchEL.Currentset == 2)
                {
                    matchEL.Teamatimeout2 = matchEL.Teamatimeout2 + 1;
                }

                if (matchEL.Currentset == 3)
                {
                    matchEL.Teamatimeout3 = matchEL.Teamatimeout3 + 1;
                }

                if (matchEL.Currentset == 4)
                {
                    matchEL.Teamatimeout4 = matchEL.Teamatimeout4 + 1;
                }

                if (matchEL.Currentset == 5)
                {
                    matchEL.Teamatimeout5 = matchEL.Teamatimeout5 + 1;
                }

                UpdateMatch();
            }
        }

        private void btnTeamAMinusScore_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tvTeamAScore.Text) != 0)
            {
                if (matchEL.Currentset == 1)
                {
                    matchEL.Teamaset1 = matchEL.Teamaset1 - 1;
                }

                if (matchEL.Currentset == 2)
                {
                    matchEL.Teamaset2 = matchEL.Teamaset2 - 1;
                }

                if (matchEL.Currentset == 3)
                {
                    matchEL.Teamaset3 = matchEL.Teamaset3 - 1;
                }

                if (matchEL.Currentset == 4)
                {
                    matchEL.Teamaset4 = matchEL.Teamaset4 - 1;
                }

                if (matchEL.Currentset == 5)
                {
                    matchEL.Teamaset5 = matchEL.Teamaset5 - 1;
                }

                UpdateMatch();

                CheckIfCanSet();
            }
        }

        private void btnTeamBMinusScore_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tvTeamBScore.Text) != 0)
            {
                if (matchEL.Currentset == 1)
                {
                    matchEL.Teambset1 = matchEL.Teambset1 - 1;
                }

                if (matchEL.Currentset == 2)
                {
                    matchEL.Teambset2 = matchEL.Teambset2 - 1;
                }

                if (matchEL.Currentset == 3)
                {
                    matchEL.Teambset3 = matchEL.Teambset3 - 1;
                }

                if (matchEL.Currentset == 4)
                {
                    matchEL.Teambset4 = matchEL.Teambset4 - 1;
                }

                if (matchEL.Currentset == 5)
                {
                    matchEL.Teambset5 = matchEL.Teambset5 - 1;
                }

                UpdateMatch();
                CheckIfCanSet();
            }
        }

        

        private void btnTeamAAddScore_Click(object sender, EventArgs e)
        {
            if (matchEL.Currentset == 1)
            {
                matchEL.Teamaset1 = matchEL.Teamaset1 + 1;
            }

            if (matchEL.Currentset == 2)
            {
                matchEL.Teamaset2 = matchEL.Teamaset2 + 1;
            }

            if (matchEL.Currentset == 3)
            {
                matchEL.Teamaset3 = matchEL.Teamaset3 + 1;
            }

            if (matchEL.Currentset == 4)
            {
                matchEL.Teamaset4 = matchEL.Teamaset4 + 1;
            }

            if (matchEL.Currentset == 5)
            {
                matchEL.Teamaset5 = matchEL.Teamaset5 + 1;
            }

            UpdateMatch();
            CheckIfCanSet();
        }

        private void btnTeamBAddScore_Click(object sender, EventArgs e)
        {
            if (matchEL.Currentset == 1)
            {
                matchEL.Teambset1 = matchEL.Teambset1 + 1;
            }

            if (matchEL.Currentset == 2)
            {
                matchEL.Teambset2 = matchEL.Teambset2 + 1;
            }

            if (matchEL.Currentset == 3)
            {
                matchEL.Teambset3 = matchEL.Teambset3 + 1;
            }

            if (matchEL.Currentset == 4)
            {
                matchEL.Teambset4 = matchEL.Teambset4 + 1;
            }

            if (matchEL.Currentset == 5)
            {
                matchEL.Teambset5 = matchEL.Teambset5 + 1;
            }

            UpdateMatch();
            CheckIfCanSet();
        }

        
    }
}